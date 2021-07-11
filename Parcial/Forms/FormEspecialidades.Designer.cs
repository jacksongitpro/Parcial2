
namespace Parcial
{
    partial class FormEspecialidades
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
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEspecialidades
            // 
            this.labelEspecialidades.AutoSize = true;
            this.labelEspecialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecialidades.Location = new System.Drawing.Point(1, 9);
            this.labelEspecialidades.Name = "labelEspecialidades";
            this.labelEspecialidades.Size = new System.Drawing.Size(193, 29);
            this.labelEspecialidades.TabIndex = 0;
            this.labelEspecialidades.Text = "Especialidades";
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(3, 56);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(55, 18);
            this.labelBuscar.TabIndex = 1;
            this.labelBuscar.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(290, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 30);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FormEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 480);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.labelEspecialidades);
            this.Name = "FormEspecialidades";
            this.Text = "FormEspecialidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEspecialidades;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
    }
}