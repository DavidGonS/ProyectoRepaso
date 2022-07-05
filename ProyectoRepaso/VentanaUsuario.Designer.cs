
namespace ProyectoRepaso
{
    partial class VentanaUsuario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUs = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 160);
            this.button1.Size = new System.Drawing.Size(138, 23);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(76, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lbCodigo
            // 
            this.lbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCodigo.Location = new System.Drawing.Point(181, 164);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(84, 21);
            this.lbCodigo.TabIndex = 17;
            this.lbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUsuario
            // 
            this.lbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbUsuario.Location = new System.Drawing.Point(181, 106);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(84, 20);
            this.lbUsuario.TabIndex = 16;
            this.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNombre
            // 
            this.lbNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNombre.Location = new System.Drawing.Point(181, 52);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(84, 21);
            this.lbNombre.TabIndex = 15;
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Código:";
            // 
            // lbUs
            // 
            this.lbUs.AutoSize = true;
            this.lbUs.Location = new System.Drawing.Point(73, 107);
            this.lbUs.Name = "lbUs";
            this.lbUs.Size = new System.Drawing.Size(46, 13);
            this.lbUs.TabIndex = 13;
            this.lbUs.Text = "Usuario:";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Location = new System.Drawing.Point(73, 53);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(47, 13);
            this.lbNombreUsuario.TabIndex = 12;
            this.lbNombreUsuario.Text = "Nombre:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(334, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 27);
            this.button4.TabIndex = 22;
            this.button4.Text = "Cerrrar Sesión";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 27);
            this.button3.TabIndex = 21;
            this.button3.Text = "Cambiar Contraseña";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 27);
            this.button2.TabIndex = 23;
            this.button2.Text = "Contenedor Principal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VentanaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbUs);
            this.Controls.Add(this.lbNombreUsuario);
            this.Name = "VentanaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaUsuario_FormClosing);
            this.Load += new System.EventHandler(this.VentanaUsuario_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.lbNombreUsuario, 0);
            this.Controls.SetChildIndex(this.lbUs, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lbNombre, 0);
            this.Controls.SetChildIndex(this.lbUsuario, 0);
            this.Controls.SetChildIndex(this.lbCodigo, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUs;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}