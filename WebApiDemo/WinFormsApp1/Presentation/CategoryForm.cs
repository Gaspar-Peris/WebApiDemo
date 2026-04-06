using Newtonsoft.Json;
using Shared;
using Shared.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Presentation
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            CategoryForm2 categoryForm2 = new CategoryForm2();

            categoryForm2.ShowDialog();

            CargarLista();
        }

        public async void CargarLista()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:7164/api/Category";

                var response = await client.GetStringAsync(url);

                var lista = JsonConvert.DeserializeObject<List<CategoryResponseDto>>(response);

                dataGridView1.DataSource = lista;
            }
        }

        private int? GetId()
        {
            try
            {
                var valor = dataGridView1.CurrentRow.Cells["IdCategory"].Value;
                return int.Parse(valor.ToString());
            }
            catch
            {

                return null;
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {

                CategoryForm2 categoryForm2 = new CategoryForm2(id);
                categoryForm2.ShowDialog();


                CargarLista();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoria de la lista.");
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
                        var response = await client.DeleteAsync($"https://localhost:7164/api/Category/{IdSeleccionado}");
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

        private void button5_Click(object sender, EventArgs e)
        {
            CargarLista();
        }
        

    }
}
