using WinFormsApp1.Login_Register_Token;

namespace WinFormsApp1.Presentation
{
    public partial class Register : Form
    {
        private readonly AuthApiService _authService = new AuthApiService();
        public Register()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = await _authService.RegisterAsync(textBox4.Text, textBox3.Text, textBox1.Text, textBox2.Text);

            if (result)
            {
                MessageBox.Show("Cuenta Creada");

                var mainForm = new Form1();
                mainForm.FormClosed += (s, args) => Application.Exit(); // Si cierro Form1, mato la app completa
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
