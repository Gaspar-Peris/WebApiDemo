using Newtonsoft.Json;
using System.Security.Policy;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            WinFormsApp1.FrmTabla frmTabla = new WinFormsApp1.FrmTabla();

            frmTabla.ShowDialog();

            CargarLista();
        }

        public async void CargarLista()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:7164/api/Products";

                var response = await client.GetStringAsync(url);

                var listaOriginal = JsonConvert.DeserializeObject<List<dynamic>>(response);

                var lista = listaOriginal?.Select(p => new
                {
                    Id = (int)p.id,
                    Name = (string)p.name,
                    Description = (string)p.description,
                    Price = (decimal)p.price
                }).ToList();

                dataGridView1.DataSource = lista;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarLista();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {

                return null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                WinFormsApp1.FrmTabla frmTabla = new WinFormsApp1.FrmTabla();
                frmTabla.Id = id;
                frmTabla.ShowDialog();
            }
            CargarLista();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            int? IdSeleccionado = GetId();
            if (IdSeleccionado != null)
            {
                using (var client = new HttpClient())
                {
                    var response = await client.DeleteAsync($"https://localhost:7164/api/Products/{IdSeleccionado}");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Eliminado con éxito");
                        CargarLista();
                    }
                }
            }
        }
    }
}
