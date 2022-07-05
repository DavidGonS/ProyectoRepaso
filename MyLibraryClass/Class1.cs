using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLibraryClass
{
    public class Utilidades
    {
        public static DataSet ejecutar(string cmd)
        {
            SqlConnection connection = new SqlConnection("Data Source=TERESA\\SERVERSQL;Initial Catalog=Administracion;Integrated Security=True");
            connection.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, connection);

            sqlDataAdapter.Fill(ds);

            connection.Close();
            return ds;
        }

        public static Boolean validarFormulario(Control objeto, ErrorProvider errorProvider)
        {
            Boolean hayErrores = false;

            foreach (Control item in objeto.Controls)
            {
                if (item is ErrorTextBox)
                {
                    ErrorTextBox obj = (ErrorTextBox)item;
                    if (obj.validar == true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            errorProvider.SetError(obj, "No puede estar vacio");
                            hayErrores = true;
                        }
                    }
                    else
                    {
                        errorProvider.SetError(obj, "");
                    }
                }
            }
            return hayErrores;
        }
    }
}
