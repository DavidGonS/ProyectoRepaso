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
        public static double total;

        private void btColocar_Click(object sender, EventArgs e)
        {
            if (Utilidades.validarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int numFila = 0;

                if (contarFilas == 0)
                {
                    dataGridView1.Rows.Add(tbCodigo.Text, tbDescripcion.Text, tbPrecio.Text, tbCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[contarFilas].Cells[2].Value) 
                        * Convert.ToDouble(dataGridView1.Rows[contarFilas].Cells[3].Value);

                    dataGridView1.Rows[numFila].Cells[4].Value = importe;

                    contarFilas++;
                }
                else
                {
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (fila.Cells[0].Value.ToString() == tbCodigo.Text)
                        {
                            existe = true;
                            numFila = fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        dataGridView1.Rows[numFila].Cells[3].Value = (Convert.ToDouble(tbCantidad.Text)
                           + Convert.ToDouble(dataGridView1.Rows[numFila].Cells[3].Value)).ToString();

                        double importe = Convert.ToDouble(dataGridView1.Rows[numFila].Cells[2].Value)
                            * Convert.ToDouble(dataGridView1.Rows[numFila].Cells[3].Value);

                        dataGridView1.Rows[numFila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(tbCodigo.Text, tbDescripcion.Text, tbPrecio.Text, tbCantidad.Text);
                        double importe = Convert.ToDouble(dataGridView1.Rows[contarFilas].Cells[2].Value)
                            * Convert.ToDouble(dataGridView1.Rows[contarFilas].Cells[3].Value);

                        dataGridView1.Rows[numFila].Cells[4].Value = importe;

                        contarFilas++;
                    }
                }

                total = 0;

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(fila.Cells[4].Value);
                    lbTotal.Text = total.ToString() + "€";
                }
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (contarFilas > 0)
            {
                total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                lbTotal.Text = total.ToString() + "€";

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                contarFilas--;
            }
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            ConsultasClientes consultasClientes = new ConsultasClientes();
            consultasClientes.ShowDialog();
            if (consultasClientes.DialogResult == DialogResult.OK)
            {
                tbCodigoCliente.Text = consultasClientes.dataGridView1.Rows[consultasClientes.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                tbCliente.Text = consultasClientes.dataGridView1.Rows[consultasClientes.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                tbCodigo.Focus();
            }
        }

        private void btProductos_Click(object sender, EventArgs e)
        {
            ConsultasProductos consultas = new ConsultasProductos();
            consultas.ShowDialog();

            if (consultas.DialogResult == DialogResult.OK)
            {
                tbCodigo.Text = consultas.dataGridView1.Rows[consultas.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                tbDescripcion.Text = consultas.dataGridView1.Rows[consultas.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                tbPrecio.Text = consultas.dataGridView1.Rows[consultas.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

                tbCantidad.Focus();
            }
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        public override void nuevo()
        {
            tbCodigo.Text = "";
            tbCliente.Text = "";
            tbCodigoCliente.Text = "";
            tbDescripcion.Text = "";
            tbPrecio.Text = "";
            lbTotal.Text = "0€";
            dataGridView1.Rows.Clear();
            contarFilas = 0;
            total = 0;
            tbCodigoCliente.Focus();
        }
    }
}
