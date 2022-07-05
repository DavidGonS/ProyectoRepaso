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
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE idUsuario=" + VentanaLogin.codigo;

            DataSet ds = Utilidades.ejecutar(cmd);

            lbAdmin.Text = ds.Tables[0].Rows[0]["nombreUsuario"].ToString();
            lbUsuario.Text = ds.Tables[0].Rows[0]["account"].ToString();
            lbCodigo.Text = ds.Tables[0].Rows[0]["idUsuario"].ToString();

            string url  = ds.Tables[0].Rows[0]["foto"].ToString();
            pictureBox1.Image = Image.FromFile(url);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal contenedor = new ContenedorPrincipal();
            this.Hide();
            contenedor.Show();


        }
    }
}
