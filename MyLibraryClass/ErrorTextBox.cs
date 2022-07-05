using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryClass
{
    public partial class ErrorTextBox : TextBox
    {
        public ErrorTextBox()
        {
            InitializeComponent();
        }

        public Boolean validar
        {
            set;
            get;
        }
    }
}
