using Newtonsoft.Json;
using Shared;
using System.Security.Policy;
using WinFormsApp1.Presentation;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            EditRole role = new EditRole();
            AbrirFormEnPanel(role);
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();

            AbrirFormEnPanel(categoryForm);
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirFormEnPanel(Form formHijo)
        {
            if (this.panelDesktop.Controls.Count > 0)
                this.panelDesktop.Controls.Clear();

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.panelDesktop.Controls.Add(formHijo);
            this.panelDesktop.Tag = formHijo;
            formHijo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm();
            AbrirFormEnPanel(productListForm);
        }
    }
}
