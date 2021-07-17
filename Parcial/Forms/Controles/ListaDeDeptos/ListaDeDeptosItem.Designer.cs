

namespace Parcial.Controls.ListaDeDeptos
{
    partial class ListaDeDeptosItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion :";
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(227, 99);
            this.infoButton.Margin = new System.Windows.Forms.Padding(4);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(100, 28);
            this.infoButton.TabIndex = 4;
            this.infoButton.Text = "Ver";
            this.infoButton.UseVisualStyleBackColor = true;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(131, 21);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(60, 24);
            this.nombreLabel.TabIndex = 5;
            this.nombreLabel.Text = "label3";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionLabel.Location = new System.Drawing.Point(131, 59);
            this.direccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(60, 24);
            this.direccionLabel.TabIndex = 6;
            this.direccionLabel.Text = "label4";
            // 
            // ListaDeDeptosItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.direccionLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListaDeDeptosItem";
            this.Size = new System.Drawing.Size(425, 151);
            this.Load += new System.EventHandler(this.ListaDeDeptosItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label direccionLabel;
    }
}