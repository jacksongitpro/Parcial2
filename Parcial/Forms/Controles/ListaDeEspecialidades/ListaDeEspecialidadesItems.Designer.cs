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
            this.panelEspecialidad = new System.Windows.Forms.Panel();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.Nombrelabel1 = new System.Windows.Forms.Label();
            this.panelEspecialidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEspecialidad
            // 
            this.panelEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEspecialidad.AutoScroll = true;
            this.panelEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEspecialidad.Controls.Add(this.NombreLabel);
            this.panelEspecialidad.Controls.Add(this.textDescripcion);
            this.panelEspecialidad.Controls.Add(this.Descripcionlabel);
            this.panelEspecialidad.Controls.Add(this.Nombrelabel1);
            this.panelEspecialidad.Location = new System.Drawing.Point(4, 4);
            this.panelEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.panelEspecialidad.Name = "panelEspecialidad";
            this.panelEspecialidad.Size = new System.Drawing.Size(357, 100);
            this.panelEspecialidad.TabIndex = 1;
            this.panelEspecialidad.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(113, 8);
            this.NombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(59, 20);
            this.NombreLabel.TabIndex = 5;
            this.NombreLabel.Text = "label6";
            this.NombreLabel.Click += new System.EventHandler(this.NombreApellidoLabel_Click_1);
            // 
            // textDescripcion
            // 
            this.textDescripcion.AutoSize = true;
            this.textDescripcion.Location = new System.Drawing.Point(6, 91);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(0, 17);
            this.textDescripcion.TabIndex = 4;
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcionlabel.Location = new System.Drawing.Point(6, 37);
            this.Descripcionlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(82, 17);
            this.Descripcionlabel.TabIndex = 1;
            this.Descripcionlabel.Text = "Descripcion";
            this.Descripcionlabel.Click += new System.EventHandler(this.Descripcionlabel_Click);
            // 
            // Nombrelabel1
            // 
            this.Nombrelabel1.AutoSize = true;
            this.Nombrelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrelabel1.Location = new System.Drawing.Point(6, 8);
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
            this.Controls.Add(this.panelEspecialidad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListaDeEspecialidadesItems";
            this.Size = new System.Drawing.Size(367, 117);
            this.panelEspecialidad.ResumeLayout(false);
            this.panelEspecialidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEspecialidad;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label textDescripcion;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Label Nombrelabel1;
    }
}
