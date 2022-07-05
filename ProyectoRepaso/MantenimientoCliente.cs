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
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        public override bool guardar()
        {
            try
            {
                string cmd = string.Format("EXEC ActualizaCliente '{0}', '{1}', '{2}'", tbIdCliente.Text.Trim(), tbNombre.Text.Trim(), tbApellido.Text.Trim());
                Utilidades.ejecutar(cmd);
                MessageBox.Show("Se ha guardado correctamente");
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error", error.Message);
                return false;
            }
        }

        public override void eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarClientes '{0}'", tbIdCliente.Text.Trim());
                Utilidades.ejecutar(cmd);
                MessageBox.Show("Se ha eliminado correctamente");

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error", error.Message);
                throw;
            }
        }
    }
}
