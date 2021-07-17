using Parcial.Modelo;
using Parcial.Controls;
using Parcial.Forms;
namespace Parcial//.Forms.Controles.ListaDeDeptos.ListaDeDeptosControl
{
    partial class GestionMaterial
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
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.crearButton = new System.Windows.Forms.Button();
            this.listaDeDeptosControl = new Parcial.Forms.Controles.ListaDeDeptos.ListaDeDeptosControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar :";
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(97, 83);
            this.filtroTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(200, 22);
            this.filtroTextBox.TabIndex = 2;
            this.filtroTextBox.TextChanged += new System.EventHandler(this.filtroTextBox_TextChanged_1);
            // 
            // crearButton
            // 
            this.crearButton.Location = new System.Drawing.Point(305, 80);
            this.crearButton.Margin = new System.Windows.Forms.Padding(4);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(100, 28);
            this.crearButton.TabIndex = 3;
            this.crearButton.Text = "Nuevo";
            this.crearButton.UseVisualStyleBackColor = true;
            this.crearButton.Click += new System.EventHandler(this.crearButton_Click_1);
            // 
            // listaDeDeptosControl
            // 
            this.listaDeDeptosControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaDeDeptosControl.Location = new System.Drawing.Point(32, 133);
            this.listaDeDeptosControl.Margin = new System.Windows.Forms.Padding(4);
            this.listaDeDeptosControl.Name = "listaDeDeptosControl";
            this.listaDeDeptosControl.Size = new System.Drawing.Size(373, 446);
            this.listaDeDeptosControl.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(323, 586);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 21);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // GestionMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 612);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.listaDeDeptosControl);
            this.Controls.Add(this.crearButton);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionMaterial";
            this.Text = "Gestion de Materiales";
            this.Load += new System.EventHandler(this.GestionMaterial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Button crearButton;
        private Forms.Controles.ListaDeDeptos.ListaDeDeptosControl listaDeDeptosControl;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}