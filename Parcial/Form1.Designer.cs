﻿
namespace Parcial
{
    partial class MenuPrincipal
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
            this.buttonpersonal = new System.Windows.Forms.Button();
            this.buttonEspecialidades = new System.Windows.Forms.Button();
            this.Especialidades = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonpersonal
            // 
            this.buttonpersonal.Location = new System.Drawing.Point(40, 137);
            this.buttonpersonal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonpersonal.Name = "buttonpersonal";
            this.buttonpersonal.Size = new System.Drawing.Size(153, 144);
            this.buttonpersonal.TabIndex = 0;
            this.buttonpersonal.Text = "Personal";
            this.buttonpersonal.UseVisualStyleBackColor = true;
            this.buttonpersonal.Click += new System.EventHandler(this.buttonpersonal_Click);
            // 
            // buttonEspecialidades
            // 
            this.buttonEspecialidades.Location = new System.Drawing.Point(279, 137);
            this.buttonEspecialidades.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEspecialidades.Name = "buttonEspecialidades";
            this.buttonEspecialidades.Size = new System.Drawing.Size(168, 144);
            this.buttonEspecialidades.TabIndex = 1;
            this.buttonEspecialidades.Text = "Especialidades";
            this.buttonEspecialidades.UseVisualStyleBackColor = true;
            // 
            // Especialidades
            // 
            this.Especialidades.Location = new System.Drawing.Point(531, 137);
            this.Especialidades.Margin = new System.Windows.Forms.Padding(4);
            this.Especialidades.Name = "Especialidades";
            this.Especialidades.Size = new System.Drawing.Size(169, 144);
            this.Especialidades.TabIndex = 2;
            this.Especialidades.Text = "Materiales";
            this.Especialidades.UseVisualStyleBackColor = true;
            this.Especialidades.Click += new System.EventHandler(this.Especialidades_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 91);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clinica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "ISTEA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bienvenido/a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(579, 58);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mi cuenta";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(675, 58);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(36, 17);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Salir";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(745, 378);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Especialidades);
            this.Controls.Add(this.buttonEspecialidades);
            this.Controls.Add(this.buttonpersonal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonpersonal;
        private System.Windows.Forms.Button buttonEspecialidades;
        private System.Windows.Forms.Button Especialidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}
