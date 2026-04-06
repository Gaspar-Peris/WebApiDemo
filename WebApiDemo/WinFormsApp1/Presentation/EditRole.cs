using DataAccess.Models;
using Shared;
using WinFormsApp1.Login_Register_Token;

namespace WinFormsApp1.Presentation
{
    public partial class EditRole : Form
    {
        private AuthApiService authApiService = new AuthApiService();
        public EditRole()
        {
            InitializeComponent();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            if (UserSession.CurrentRole != Role.Admin)
            {
                MessageBox.Show("No tienes permisos para realizar esta operación.");
                return;
            }

            var updateDto = new UpdateUserRoleDto
            {
                UserId = (Guid)cmbUsuarios.SelectedValue,
                Role = (Role)cmbRoles.SelectedItem
            };

            bool exito = await authApiService.UpdateRoleAsync(updateDto);

            if (exito)
            {
                MessageBox.Show("Rol actualizado con éxito.");
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar.");
            }
        }

        private async void EditRole_Load(object sender, EventArgs e)
        {
            var usuarios = await authApiService.GetAllUsersAsync();

            if (usuarios != null && usuarios.Count > 0)
            {
                cmbUsuarios.DisplayMember = "Email";
                cmbUsuarios.ValueMember = "Id";
                cmbUsuarios.DataSource = usuarios;
            }

            cmbRoles.DataSource = Enum.GetValues(typeof(Role));
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
