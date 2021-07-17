using Parcial.Controls;
using Parcial.Modelo;
using Parcial.Forms;
namespace Parcial.Forms
{
    partial class GestionEspecialidadesForm
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
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.ListaDeEspecialidadesControl = new Parcial.Forms.Controles.ListaDeEspecialidades.ListaDeEspecialidadesControl();
            this.SuspendLayout();
            // 
            // labelEspecialidades
            // 
            this.labelEspecialidades.AutoSize = true;
            this.labelEspecialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecialidades.Location = new System.Drawing.Point(1, 14);
            this.labelEspecialidades.Name = "labelEspecialidades";
            this.labelEspecialidades.Size = new System.Drawing.Size(193, 29);
            this.labelEspecialidades.TabIndex = 0;
            this.labelEspecialidades.Text = "Especialidades";
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(3, 54);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(55, 18);
            this.labelBuscar.TabIndex = 1;
            this.labelBuscar.Text = "Buscar";
            this.labelBuscar.Click += new System.EventHandler(this.labelBuscar_Click);
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(64, 54);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(193, 22);
            this.filtroTextBox.TabIndex = 2;
            this.filtroTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(291, 53);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(111, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Nuevo";
            this.btnCrear.UseVisualStyleBackColor = true;
            //this.btnCrear.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(708, 883);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(346, 463);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(56, 20);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Volver";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ListaDeEspecialidadesControl
            // 
            this.ListaDeEspecialidadesControl.AutoScroll = true;
            this.ListaDeEspecialidadesControl.Location = new System.Drawing.Point(12, 93);
            this.ListaDeEspecialidadesControl.Name = "ListaDeEspecialidadesControl";
            this.ListaDeEspecialidadesControl.Size = new System.Drawing.Size(390, 356);
            this.ListaDeEspecialidadesControl.TabIndex = 4;
            // 
            // GestionEspecialidadesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(455, 514);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ListaDeEspecialidadesControl);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.labelEspecialidades);
            this.Name = "GestionEspecialidadesForm";
            this.Text = "Gestion de Especialidades";
            this.Load += new System.EventHandler(this.FormEspecialidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEspecialidades;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Button btnCrear;
        private Forms.Controles.ListaDeEspecialidades.ListaDeEspecialidadesControl listaDeEspecialidadesControl1;
        private Controles.ListaDeEspecialidades.ListaDeEspecialidadesControl ListaDeEspecialidadesControl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}