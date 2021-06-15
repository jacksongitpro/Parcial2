
namespace Parcial
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
            this.SuspendLayout();

            //label1


            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar :";
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(82, 68);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(194, 20);
            this.filtroTextBox.TabIndex = 2;
            // 
            // crearButton
            // 
            this.crearButton.Location = new System.Drawing.Point(282, 66);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(75, 23);
            this.crearButton.TabIndex = 3;
            this.crearButton.Text = "Nuevo";
            this.crearButton.UseVisualStyleBackColor = true;
            // 
            // listaDeDeptosControl
            // 
            this.listaDeDeptosControl.BackColor = System.Drawing.Color.AliceBlue;
            this.listaDeDeptosControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaDeDeptosControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listaDeDeptosControl.Location = new System.Drawing.Point(20, 95);
            this.listaDeDeptosControl.Name = "listaDeDeptosControl";
            this.listaDeDeptosControl.Size = new System.Drawing.Size(367, 343);
            this.listaDeDeptosControl.TabIndex = 0;

            //GestionMaterial


            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.crearButton);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaDeDeptosControl);
            this.Name = "GestionMaterial";
            this.Text = "Gestion de Materiales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Forms.Controles.ListaDeDeptos.ListaDeDeptosControl listaDeDeptosControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Button crearButton;
    }
}