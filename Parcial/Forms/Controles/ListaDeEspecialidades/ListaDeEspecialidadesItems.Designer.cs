namespace Parcial.Forms.Controles.ListaDeEspecialidades
{
    partial class ListaDeEspecialidadesItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.NombreApellidoLabel = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.Nombrelabel1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NombreApellidoLabel);
            this.panel2.Controls.Add(this.textDescripcion);
            this.panel2.Controls.Add(this.Descripcionlabel);
            this.panel2.Controls.Add(this.Nombrelabel1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // NombreApellidoLabel
            // 
            this.NombreApellidoLabel.AutoSize = true;
            this.NombreApellidoLabel.Location = new System.Drawing.Point(90, 6);
            this.NombreApellidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreApellidoLabel.Name = "NombreApellidoLabel";
            this.NombreApellidoLabel.Size = new System.Drawing.Size(46, 17);
            this.NombreApellidoLabel.TabIndex = 5;
            this.NombreApellidoLabel.Text = "label6";
            this.NombreApellidoLabel.Click += new System.EventHandler(this.NombreApellidoLabel_Click_1);
            // 
            // textDescripcion
            // 
            this.textDescripcion.AutoSize = true;
            this.textDescripcion.Location = new System.Drawing.Point(5, 73);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(0, 17);
            this.textDescripcion.TabIndex = 4;
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcionlabel.Location = new System.Drawing.Point(5, 40);
            this.Descripcionlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(98, 17);
            this.Descripcionlabel.TabIndex = 1;
            this.Descripcionlabel.Text = "Descripcion:";
            this.Descripcionlabel.Click += new System.EventHandler(this.Descripcionlabel_Click);
            // 
            // Nombrelabel1
            // 
            this.Nombrelabel1.AutoSize = true;
            this.Nombrelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrelabel1.Location = new System.Drawing.Point(5, 6);
            this.Nombrelabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombrelabel1.Name = "Nombrelabel1";
            this.Nombrelabel1.Size = new System.Drawing.Size(69, 17);
            this.Nombrelabel1.TabIndex = 0;
            this.Nombrelabel1.Text = "Nombre:";
            this.Nombrelabel1.Click += new System.EventHandler(this.Nombrelabel1_Click);
            // 
            // ListaDeEspecialidadesItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListaDeEspecialidadesItems";
            this.Size = new System.Drawing.Size(363, 107);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NombreApellidoLabel;
        private System.Windows.Forms.Label textDescripcion;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Label Nombrelabel1;
    }
}

