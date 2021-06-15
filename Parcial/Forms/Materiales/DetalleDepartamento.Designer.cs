
namespace Parcial.Forms.Materiales
{  
    partial class DetalleDepartamento
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
            this.crearButton = new System.Windows.Forms.Button();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.listaDeMatControl = new Parcial.Forms.Controles.ListaDeMat.ListaDeMatControl();
            this.SuspendLayout();
            // 
            // crearButton
            // 
            this.crearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearButton.Location = new System.Drawing.Point(324, 76);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(87, 23);
            this.crearButton.TabIndex = 7;
            this.crearButton.Text = "Nuevo";
            this.crearButton.UseVisualStyleBackColor = true;
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(91, 78);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(226, 20);
            this.filtroTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar :";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(14, 9);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(106, 37);
            this.nombreLabel.TabIndex = 4;
            this.nombreLabel.Text = "label1";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionLabel.Location = new System.Drawing.Point(22, 50);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(51, 16);
            this.direccionLabel.TabIndex = 8;
            this.direccionLabel.Text = "label3";
            // 
            // listaDeMatControl
            // 
            this.listaDeMatControl.BackColor = System.Drawing.SystemColors.Control;
            this.listaDeMatControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaDeMatControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listaDeMatControl.Location = new System.Drawing.Point(14, 105);
            this.listaDeMatControl.Name = "listaDeMatControl";
            this.listaDeMatControl.Size = new System.Drawing.Size(410, 333);
            this.listaDeMatControl.TabIndex = 0;
            // 
            // DetalleDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.direccionLabel);
            this.Controls.Add(this.crearButton);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.listaDeMatControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DetalleDepartamento";
            this.Text = "Detalle de Departamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Forms.Controles.ListaDeMat.ListaDeMatControl listaDeMatControl;
        private System.Windows.Forms.Button crearButton;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label direccionLabel;
    }
}