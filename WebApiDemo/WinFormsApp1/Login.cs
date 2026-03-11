using Microsoft.AspNetCore.Identity;
using Shared;
using System.Net.Http.Json;
using WinFormsApp1.Login_Register_Token;
using WinFormsApp1.Presentation;



namespace WinFormsApp1
{
    public partial class Login : Form
    {
        private readonly AuthApiService _authService = new AuthApiService();
        public Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = await _authService.LoginAsync(textBox1.Text, textBox2.Text);

            if (result != null)
            {
                MessageBox.Show("Login correcto");

                var mainForm = new Form1();
                mainForm.FormClosed += (s, args) => Application.Exit();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = new Register();
            mainForm.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
