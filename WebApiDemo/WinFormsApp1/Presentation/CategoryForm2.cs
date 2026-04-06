using Newtonsoft.Json;
using System.Text;

namespace WinFormsApp1.Presentation
{
    public partial class CategoryForm2 : Form
    {
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int? Id { get; set; }
        public CategoryForm2(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            
            object datos;

            if (this.Id == null)
            {
                datos = new { Name = textBox1.Text };
            }
            else
            {
                datos = new { IdCategory = this.Id, Name = textBox1.Text };
            }

            using (var client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(datos);
                var contenido = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response;

                if (this.Id == null)
                {
                    response = await client.PostAsync("https://localhost:7164/api/Category", contenido);
                }
                else
                {
                    response = await client.PutAsync($"https://localhost:7164/api/Category/{this.Id}", contenido);
                }

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("¡Operación realizada con éxito!");
                    this.Close();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error de la API: {error}");
                }
            }
        }

        private async Task CargarDatos()
        {
            using (var client = new HttpClient())
            {
                
                var response = await client.GetStringAsync($"https://localhost:7164/api/Category/{this.Id}");

                
                var cat = JsonConvert.DeserializeObject<dynamic>(response);

                if (cat != null)
                {
                    textBox1.Text = cat.name;
                }
            }
        }

        private async void CategoryForm2_Load(object sender, EventArgs e)
        {
            if (Id != null)
            {

                await CargarDatos();

            }
        }
    }
}
