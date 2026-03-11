using DataAccess.Models;
using Newtonsoft.Json;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
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

            cmbUsuarios.DataSource = usuarios;

           
            cmbUsuarios.DisplayMember = "Email";

            
            cmbUsuarios.ValueMember = "Id";

            cmbRoles.DataSource = Enum.GetValues(typeof(Role));
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedItem is User selectedUser)
            {
                cmbRoles.SelectedItem = selectedUser.Role;
            }
        }
    }
}
