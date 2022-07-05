using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyLibraryClass;

namespace ProyectoRepaso
{
    public partial class VentanaLogin : FormBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        public static String codigo = "";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("SELECT * FROM Usuarios WHERE account='{0}' AND password='{1}'", tbUsuario.Text.Trim(), tbContrasena.Text.Trim());
                DataSet dataSet = Utilidades.ejecutar(cmd);

                codigo = dataSet.Tables[0].Rows[0]["idUsuario"].ToString().Trim();

                string cuenta = dataSet.Tables[0].Rows[0]["account"].ToString().Trim();
                string contrasena = dataSet.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == tbUsuario.Text.Trim() || contrasena == tbContrasena.Text.Trim())
                {
                    if (Convert.ToBoolean(dataSet.Tables[0].Rows[0]["esAdmin"]) == true)
                    {
                        VentanaAdmin ventanaAdmin = new VentanaAdmin();
                        this.Hide();
                        ventanaAdmin.Show();
                    }
                     else
                    {
                        VentanaUsuario ventanaUsuario = new VentanaUsuario();
                        this.Hide();
                        ventanaUsuario.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
                throw;
            }
        }

        private void VentanaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
