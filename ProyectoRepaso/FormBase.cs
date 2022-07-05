using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRepaso
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public virtual void eliminar()
        {

        }

        public virtual void nuevo()
        {

        }

        public virtual void consultar()
        {

        }

        public virtual Boolean guardar()
        {
            return false;
        }
    }
}
