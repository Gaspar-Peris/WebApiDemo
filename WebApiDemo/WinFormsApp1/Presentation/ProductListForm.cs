using Newtonsoft.Json;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Presentation
{
    public partial class ProductListForm : Form
    {
        public ProductListForm()
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

                var lista = JsonConvert.DeserializeObject<List<ProductResponseDto>>(response);

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
                var valor = dataGridView1.CurrentRow.Cells["Id"].Value;
                return int.Parse(valor.ToString());
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

                WinFormsApp1.FrmTabla frmTabla = new WinFormsApp1.FrmTabla(id);
                frmTabla.ShowDialog();


                CargarLista();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista.");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            int? IdSeleccionado = GetId();
            if (IdSeleccionado != null)
            {

                var confirmacion = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {
                    using (var client = new HttpClient())
                    {
                        var response = await client.DeleteAsync($"https://localhost:7164/api/Products/{IdSeleccionado}");
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Producto eliminado con éxito");
                            CargarLista();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el producto.");
                        }
                    }
                }
            }
        }
    }
}
