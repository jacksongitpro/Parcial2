
namespace Parcial.Forms.Controles.ListaDeEmpleados
{
    partial class GestionPersonalForm
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
            this.labelPersonal = new System.Windows.Forms.Label();
            this.labelBuscador = new System.Windows.Forms.Label();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.ListaDeEmpleadosControl = new Parcial.Forms.Controles.ListaDeEmpleados.ListaDeEmpleadosControl();
            this.SuspendLayout();
            // 
            // labelPersonal
            // 
            this.labelPersonal.AutoSize = true;
            this.labelPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonal.Location = new System.Drawing.Point(14, 9);
            this.labelPersonal.Name = "labelPersonal";
            this.labelPersonal.Size = new System.Drawing.Size(136, 32);
            this.labelPersonal.TabIndex = 1;
            this.labelPersonal.Text = "Personal";
            this.labelPersonal.Click += new System.EventHandler(this.label13_Click);
            // 
            // labelBuscador
            // 
            this.labelBuscador.AutoSize = true;
            this.labelBuscador.Location = new System.Drawing.Point(13, 59);
            this.labelBuscador.Name = "labelBuscador";
            this.labelBuscador.Size = new System.Drawing.Size(52, 17);
            this.labelBuscador.TabIndex = 2;
            this.labelBuscador.Text = "Buscar";
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTextBox.Location = new System.Drawing.Point(71, 59);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(136, 27);
            this.filtroTextBox.TabIndex = 3;
            this.filtroTextBox.TextChanged += new System.EventHandler(this.BuscartextBox_TextChanged);
            // 
            // BtnCrear
            // 
            this.BtnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.Location = new System.Drawing.Point(322, 53);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(91, 27);
            this.BtnCrear.TabIndex = 4;
            this.BtnCrear.Text = "Nuevo";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // ListaDeEmpleadosControl
            // 
            this.ListaDeEmpleadosControl.Location = new System.Drawing.Point(12, 92);
            this.ListaDeEmpleadosControl.Name = "ListaDeEmpleadosControl";
            this.ListaDeEmpleadosControl.Size = new System.Drawing.Size(392, 503);
            this.ListaDeEmpleadosControl.TabIndex = 5;
            // 
            // GestionPersonalForm
            // 
            this.ClientSize = new System.Drawing.Size(463, 585);
            this.Controls.Add(this.ListaDeEmpleadosControl);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.labelBuscador);
            this.Controls.Add(this.labelPersonal);
            this.Name = "GestionPersonalForm";
            this.Text = "Gestion Del Personal";
            this.Load += new System.EventHandler(this.GestionPersonalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPersonal;
        private System.Windows.Forms.Label labelBuscador;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Button BtnCrear;
        private ListaDeEmpleadosControl ListaDeEmpleadosControl;
    }
}