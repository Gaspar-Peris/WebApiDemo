using Microsoft.Graph.Models;
using Newtonsoft.Json;
using System.Text;


namespace WinFormsApp1
{
    public partial class FrmTabla : Form
    {
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int? Id { get; set; }
        public FrmTabla(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private async void FrmTabla_Load(object sender, EventArgs e)
        {
            if (Id != null)
            {
                await CargarDatos();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Validamos que el precio sea un número válido
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            var datos = new
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = price
            };

            using (var client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(datos);
                var contenido = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response;

                if (this.Id == null)
                {
                    
                    response = await client.PostAsync("https://localhost:7164/api/Products", contenido);
                }
                else
                {
                    
                    response = await client.PutAsync($"https://localhost:7164/api/Products/{this.Id}", contenido);
                }

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("¡Operación realizada con éxito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar los datos.");
                }
            }
        }
        private async Task CargarDatos()
        {
            using (var client = new HttpClient())
            {

                var response = await client.GetStringAsync($"https://localhost:7164/api/Products/{this.Id}");
                var prod = JsonConvert.DeserializeObject<dynamic>(response);


                txtName.Text = prod?.name;
                txtDescription.Text = prod?.description;
                txtPrice.Text = prod?.price.ToString();

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
