
namespace Parcial.Forms
{
    partial class AltaEmpleadoForm
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.labelEspecialidad = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.DniLabel = new System.Windows.Forms.Label();
            this.Matriculalabel = new System.Windows.Forms.Label();
            this.labelContacto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.labelCalle = new System.Windows.Forms.Label();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.DnitexBox = new System.Windows.Forms.TextBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.labelPovincia = new System.Windows.Forms.Label();
            this.comboBoxEspecialidad = new System.Windows.Forms.ComboBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.CalletextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.guardarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(9, 19);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(195, 25);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Informacion Basica";
            // 
            // labelEspecialidad
            // 
            this.labelEspecialidad.AutoSize = true;
            this.labelEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecialidad.Location = new System.Drawing.Point(263, 19);
            this.labelEspecialidad.Name = "labelEspecialidad";
            this.labelEspecialidad.Size = new System.Drawing.Size(135, 25);
            this.labelEspecialidad.TabIndex = 1;
            this.labelEspecialidad.Text = "Especialidad";
            this.labelEspecialidad.Click += new System.EventHandler(this.labelEspecialidad_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(13, 54);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(64, 17);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // DniLabel
            // 
            this.DniLabel.AutoSize = true;
            this.DniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DniLabel.Location = new System.Drawing.Point(13, 96);
            this.DniLabel.Name = "DniLabel";
            this.DniLabel.Size = new System.Drawing.Size(34, 17);
            this.DniLabel.TabIndex = 3;
            this.DniLabel.Text = "DNI";
            // 
            // Matriculalabel
            // 
            this.Matriculalabel.AutoSize = true;
            this.Matriculalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matriculalabel.Location = new System.Drawing.Point(10, 129);
            this.Matriculalabel.Name = "Matriculalabel";
            this.Matriculalabel.Size = new System.Drawing.Size(87, 20);
            this.Matriculalabel.TabIndex = 4;
            this.Matriculalabel.Text = "Matricula";
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContacto.Location = new System.Drawing.Point(9, 177);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(99, 25);
            this.labelContacto.TabIndex = 5;
            this.labelContacto.Text = "Contacto";
            this.labelContacto.Click += new System.EventHandler(this.labelContacto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(263, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Domicilio Particular";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(10, 228);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(81, 20);
            this.labelTelefono.TabIndex = 9;
            this.labelTelefono.Text = "Telefono";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(12, 267);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(56, 20);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "Email";
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalle.Location = new System.Drawing.Point(263, 230);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(52, 20);
            this.labelCalle.TabIndex = 11;
            this.labelCalle.Text = "Calle";
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalidad.Location = new System.Drawing.Point(263, 267);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(90, 20);
            this.labelLocalidad.TabIndex = 12;
            this.labelLocalidad.Text = "Localidad";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(114, 51);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(126, 22);
            this.NombretextBox.TabIndex = 13;
            this.NombretextBox.Tag = "";
            // 
            // DnitexBox
            // 
            this.DnitexBox.Location = new System.Drawing.Point(114, 93);
            this.DnitexBox.Name = "DnitexBox";
            this.DnitexBox.Size = new System.Drawing.Size(126, 22);
            this.DnitexBox.TabIndex = 14;
            this.DnitexBox.Tag = "";
            this.DnitexBox.TextChanged += new System.EventHandler(this.DnitexBox_TextChanged);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(114, 127);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(126, 22);
            this.textBoxMatricula.TabIndex = 15;
            this.textBoxMatricula.Tag = "";
            // 
            // labelPovincia
            // 
            this.labelPovincia.AutoSize = true;
            this.labelPovincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPovincia.Location = new System.Drawing.Point(263, 300);
            this.labelPovincia.Name = "labelPovincia";
            this.labelPovincia.Size = new System.Drawing.Size(87, 20);
            this.labelPovincia.TabIndex = 16;
            this.labelPovincia.Text = "Provincia";
            // 
            // comboBoxEspecialidad
            // 
            this.comboBoxEspecialidad.FormattingEnabled = true;
            this.comboBoxEspecialidad.Location = new System.Drawing.Point(267, 51);
            this.comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            this.comboBoxEspecialidad.Size = new System.Drawing.Size(199, 24);
            this.comboBoxEspecialidad.TabIndex = 17;
            this.comboBoxEspecialidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspecialidad_SelectedIndexChanged);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(114, 226);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(126, 22);
            this.textBoxTelefono.TabIndex = 18;
            this.textBoxTelefono.Tag = "";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(114, 265);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(126, 22);
            this.textBoxEmail.TabIndex = 19;
            this.textBoxEmail.Tag = "";
            // 
            // CalletextBox
            // 
            this.CalletextBox.Location = new System.Drawing.Point(365, 226);
            this.CalletextBox.Name = "CalletextBox";
            this.CalletextBox.Size = new System.Drawing.Size(126, 22);
            this.CalletextBox.TabIndex = 20;
            this.CalletextBox.Tag = "";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(365, 267);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(126, 22);
            this.textBox5.TabIndex = 21;
            this.textBox5.Tag = "";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(365, 300);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(126, 22);
            this.textBox6.TabIndex = 22;
            this.textBox6.Tag = "";
            // 
            // guardarButton
            // 
            this.guardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarButton.Location = new System.Drawing.Point(30, 342);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(461, 34);
            this.guardarButton.TabIndex = 23;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click_1);
            // 
            // AltaEmpleadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 388);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.CalletextBox);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.comboBoxEspecialidad);
            this.Controls.Add(this.labelPovincia);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.DnitexBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.labelLocalidad);
            this.Controls.Add(this.labelCalle);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelContacto);
            this.Controls.Add(this.Matriculalabel);
            this.Controls.Add(this.DniLabel);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelEspecialidad);
            this.Controls.Add(this.InfoLabel);
            this.Name = "AltaEmpleadoForm";
            this.Text = "AltaEmpleado";
            this.Load += new System.EventHandler(this.AltaEmpleadoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label labelEspecialidad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label DniLabel;
        private System.Windows.Forms.Label Matriculalabel;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label labelCalle;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox DnitexBox;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label labelPovincia;
        private System.Windows.Forms.ComboBox comboBoxEspecialidad;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox CalletextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button guardarButton;
    }
}