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
    public partial class VentanaUsuario : FormBase
    {
        public VentanaUsuario()
        {
            InitializeComponent();
        }

        private void VentanaUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaUsuario_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE idUsuario=" + VentanaLogin.codigo;

            DataSet ds = Utilidades.ejecutar(cmd);

            lbNombre.Text = ds.Tables[0].Rows[0]["nombreUsuario"].ToString();
            lbUsuario.Text = ds.Tables[0].Rows[0]["account"].ToString();
            lbCodigo.Text = ds.Tables[0].Rows[0]["idUsuario"].ToString();

            string url = ds.Tables[0].Rows[0]["foto"].ToString();
            pictureBox1.Image = Image.FromFile(url);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal usuario = new ContenedorPrincipal();
            this.Hide();
            usuario.Show();
        }
    }
}
