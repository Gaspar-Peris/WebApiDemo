using Newtonsoft.Json;
using Shared;
using Shared.Dto;
using System.Net.Http.Json;
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
            using (HttpClient client = new HttpClient())
            {
                var listaCategorias = await client.GetFromJsonAsync<List<CategoryResponseDto>>("https://localhost:7164/api/Category");

                comboCategory.DisplayMember = "Name";       // Lo que ve el usuario
                comboCategory.ValueMember = "IdCategory";
                comboCategory.DataSource = listaCategorias;

                if (this.Id != null && this.Id > 0)
                {
                    var producto = await client.GetFromJsonAsync<ProductResponseDto>($"https://localhost:7164/api/Products/{this.Id}");

                    if (producto != null)
                    {
                        txtName.Text = producto.Name;
                        txtDescription.Text = producto.Description;
                        txtPrice.Text = producto.Price.ToString();
                        comboCategory.SelectedValue = producto.IdCategory;
                    }
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            var datos = new
            {
                Id = this.Id ?? 0,
                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = price,
                IdCategory = comboCategory.SelectedValue,
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
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {response.StatusCode}. Detalle: {error}");
                }
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
