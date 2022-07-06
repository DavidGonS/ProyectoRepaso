
namespace ProyectoRepaso
{
    partial class MantenimientoProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescripcion = new MyLibraryClass.ErrorTextBox();
            this.tbPrecio = new MyLibraryClass.ErrorTextBox();
            this.tbIdProducto = new MyLibraryClass.ErrorTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 23);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(406, 175);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(406, 124);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(406, 75);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 294);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(144, 124);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(120, 20);
            this.tbDescripcion.soloNumeros = false;
            this.tbDescripcion.TabIndex = 13;
            this.tbDescripcion.validar = true;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(144, 174);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(120, 20);
            this.tbPrecio.soloNumeros = true;
            this.tbPrecio.TabIndex = 12;
            this.tbPrecio.validar = true;
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.Location = new System.Drawing.Point(144, 73);
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.Size = new System.Drawing.Size(120, 20);
            this.tbIdProducto.soloNumeros = true;
            this.tbIdProducto.TabIndex = 11;
            this.tbIdProducto.validar = true;
            // 
            // MantenimientoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 330);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbIdProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoProductos";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbIdProducto, 0);
            this.Controls.SetChildIndex(this.tbPrecio, 0);
            this.Controls.SetChildIndex(this.tbDescripcion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MyLibraryClass.ErrorTextBox tbIdProducto;
        private MyLibraryClass.ErrorTextBox tbPrecio;
        private MyLibraryClass.ErrorTextBox tbDescripcion;
    }
}