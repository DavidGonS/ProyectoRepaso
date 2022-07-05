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
    public partial class Mantenimiento : FormBase
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nuevo();
        }
    }
}
