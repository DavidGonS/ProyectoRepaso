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
    public partial class Consultas : FormBase
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public DataSet llenarGreed(string tabla)
        {
            DataSet ds;

            string cmd = string.Format("SELECT * FROM " + tabla);
            ds = Utilidades.ejecutar(cmd);
            return ds;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
