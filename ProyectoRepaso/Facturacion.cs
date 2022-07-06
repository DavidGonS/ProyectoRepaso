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
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE idUsuario=" + VentanaLogin.codigo;
            DataSet ds = Utilidades.ejecutar(cmd);

            lbAtencion.Text = ds.Tables[0].Rows[0]["nombreUsuario"].ToString().Trim();

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodigoCliente.Text.Trim()) == false)
            {
                try
                {
                    string cmd = string.Format("SELECT nombre FROM Clientes WHERE idCliente='{0}'", tbCodigoCliente.Text.Trim());
                    DataSet ds = Utilidades.ejecutar(cmd);
                    tbCliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
                    tbCodigo.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                    throw;
                }
            }
        }

        public static int contarFilas = 0;

        private void btColocar_Click(object sender, EventArgs e)
        {
            if (Utilidades.validarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int numFila = 0;

                if (contarFilas == 0)
                {
                    dataGridView1.Rows.Add(tbCodigo.Text, tbDescripcion.Text, tbPrecio.Text, tbCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[numFila].Cells[2].Value) 
                        * Convert.ToDouble(dataGridView1.Rows[numFila].Cells[3].Value);

                    dataGridView1.Rows[numFila].Cells[4].Value = importe;

                    contarFilas++;
                }
                else
                {

                }
            }
        }
    }
}
