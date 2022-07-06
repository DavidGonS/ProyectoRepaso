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
    public partial class MantenimientoProductos : Mantenimiento
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        public override bool guardar()
        {
            if (Utilidades.validarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format(
                        "EXEC ActualizaArticulos '{0}', '{1}', '{2}'", 
                        tbIdProducto.Text.Trim(), tbDescripcion.Text.Trim(), tbPrecio.Text.Trim()
                        );

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
            else
            {
                return false;
            }
        }

        public override void eliminar()
        {
            try
            {
                string cmd = string.Format(
                    "EXEC EliminarArticulos '{0}'", 
                    tbIdProducto.Text.Trim()
                    );

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
