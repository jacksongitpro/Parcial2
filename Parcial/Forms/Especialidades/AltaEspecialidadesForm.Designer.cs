
namespace Parcial.Forms
{
    partial class AltaEspecialidadesForm
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
            this.labelEspecialidades = new System.Windows.Forms.Label();
            this.labelNombreEsp = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEspecialidades
            // 
            this.labelEspecialidades.AutoSize = true;
            this.labelEspecialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecialidades.Location = new System.Drawing.Point(21, 19);
            this.labelEspecialidades.Name = "labelEspecialidades";
            this.labelEspecialidades.Size = new System.Drawing.Size(320, 36);
            this.labelEspecialidades.TabIndex = 0;
            this.labelEspecialidades.Text = "Alta De Especialidad";
            // 
            // labelNombreEsp
            // 
            this.labelNombreEsp.AutoSize = true;
            this.labelNombreEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEsp.Location = new System.Drawing.Point(22, 78);
            this.labelNombreEsp.Name = "labelNombreEsp";
            this.labelNombreEsp.Size = new System.Drawing.Size(74, 20);
            this.labelNombreEsp.TabIndex = 1;
            this.labelNombreEsp.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(112, 78);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(125, 22);
            this.NombreTextBox.TabIndex = 2;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(22, 116);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(110, 20);
            this.labelDescripcion.TabIndex = 3;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(26, 139);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(330, 28);
            this.DescripcionTextBox.TabIndex = 4;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(167, 186);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(189, 38);
            this.GuardarBtn.TabIndex = 5;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // AltaEspecialidadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 236);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.labelNombreEsp);
            this.Controls.Add(this.labelEspecialidades);
            this.Name = "AltaEspecialidadesForm";
            this.Text = "AltaEspecialidadesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEspecialidades;
        private System.Windows.Forms.Label labelNombreEsp;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Button GuardarBtn;
    }
}