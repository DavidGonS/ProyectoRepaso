using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibraryClass;

namespace ProyectoRepaso
{
    public partial class ConsultasProductos : Consultas
    {
        public ConsultasProductos()
        {
            InitializeComponent();
        }

        private void ConsultasProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarGreed("Productos").Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombreConsulta.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "SELECT * FROM Productos WHERE nombre LIKE ('%" + tbNombreConsulta.Text.Trim() + "&'";
                    ds = Utilidades.ejecutar(cmd);

                    dataGridView1.DataSource = ds.Tables[0];

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                    throw;
                }
            }
        }
    }
}
