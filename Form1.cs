using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioApp_DAL;
using InventarioApp_BLL;

namespace InventarrioApp.UI
{
    public partial class Form1 : Form
    {
        private InventarioManager manager = new InventarioManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarProductos()
        {
            lstProductos.Items.Clear();
            foreach (Producto p in manager.ListarProductos())
            {
                lstProductos.Items.Add($"{p.Nombre} - {p.Cantidad}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int cantidad;
            if (int.TryParse(txtCantidad.Text, out cantidad))
            {
                manager.AgregarProducto(nombre, cantidad);
                MostrarProductos();
            }
        }
    }
}
