
namespace Parcial
{
    partial class MiCuenta
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
            this.usuariocombo = new System.Windows.Forms.ComboBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.Clavelabel = new System.Windows.Forms.Label();
            this.ClaveActualtextBox = new System.Windows.Forms.TextBox();
            this.BTNGestionar = new System.Windows.Forms.Button();
            this.CambiarClavetextBox = new System.Windows.Forms.TextBox();
            this.CambiarCodigotextBox = new System.Windows.Forms.TextBox();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.ClaveNuevalabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usuariocombo
            // 
            this.usuariocombo.FormattingEnabled = true;
            this.usuariocombo.Location = new System.Drawing.Point(182, 16);
            this.usuariocombo.Name = "usuariocombo";
            this.usuariocombo.Size = new System.Drawing.Size(166, 24);
            this.usuariocombo.TabIndex = 0;
            this.usuariocombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(11, 20);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(74, 20);
            this.UsuarioLabel.TabIndex = 1;
            this.UsuarioLabel.Text = "Usuario";
            this.UsuarioLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Clavelabel
            // 
            this.Clavelabel.AutoSize = true;
            this.Clavelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clavelabel.Location = new System.Drawing.Point(13, 58);
            this.Clavelabel.Name = "Clavelabel";
            this.Clavelabel.Size = new System.Drawing.Size(115, 20);
            this.Clavelabel.TabIndex = 2;
            this.Clavelabel.Text = "Clave Actual";
            // 
            // ClaveActualtextBox
            // 
            this.ClaveActualtextBox.Location = new System.Drawing.Point(182, 56);
            this.ClaveActualtextBox.Name = "ClaveActualtextBox";
            this.ClaveActualtextBox.Size = new System.Drawing.Size(166, 22);
            this.ClaveActualtextBox.TabIndex = 3;
            // 
            // BTNGestionar
            // 
            this.BTNGestionar.Location = new System.Drawing.Point(182, 93);
            this.BTNGestionar.Name = "BTNGestionar";
            this.BTNGestionar.Size = new System.Drawing.Size(166, 23);
            this.BTNGestionar.TabIndex = 4;
            this.BTNGestionar.Text = "Gestionar Cuenta";
            this.BTNGestionar.UseVisualStyleBackColor = true;
            this.BTNGestionar.Click += new System.EventHandler(this.BTNGestionar_Click);
            // 
            // CambiarClavetextBox
            // 
            this.CambiarClavetextBox.Enabled = false;
            this.CambiarClavetextBox.Location = new System.Drawing.Point(182, 133);
            this.CambiarClavetextBox.Name = "CambiarClavetextBox";
            this.CambiarClavetextBox.Size = new System.Drawing.Size(166, 22);
            this.CambiarClavetextBox.TabIndex = 5;
            // 
            // CambiarCodigotextBox
            // 
            this.CambiarCodigotextBox.Enabled = false;
            this.CambiarCodigotextBox.Location = new System.Drawing.Point(182, 173);
            this.CambiarCodigotextBox.Name = "CambiarCodigotextBox";
            this.CambiarCodigotextBox.Size = new System.Drawing.Size(166, 22);
            this.CambiarCodigotextBox.TabIndex = 7;
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Location = new System.Drawing.Point(182, 212);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(166, 23);
            this.BTNActualizar.TabIndex = 8;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            this.BTNActualizar.Click += new System.EventHandler(this.BTNActualizar_Click);
            // 
            // ClaveNuevalabel
            // 
            this.ClaveNuevalabel.AutoSize = true;
            this.ClaveNuevalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveNuevalabel.Location = new System.Drawing.Point(12, 133);
            this.ClaveNuevalabel.Name = "ClaveNuevalabel";
            this.ClaveNuevalabel.Size = new System.Drawing.Size(102, 18);
            this.ClaveNuevalabel.TabIndex = 9;
            this.ClaveNuevalabel.Text = "Nueva Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Codigo Secreto";
            // 
            // MiCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 259);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClaveNuevalabel);
            this.Controls.Add(this.BTNActualizar);
            this.Controls.Add(this.CambiarCodigotextBox);
            this.Controls.Add(this.CambiarClavetextBox);
            this.Controls.Add(this.BTNGestionar);
            this.Controls.Add(this.ClaveActualtextBox);
            this.Controls.Add(this.Clavelabel);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.usuariocombo);
            this.Name = "MiCuenta";
            this.Text = "GestionCuenta";
            this.Load += new System.EventHandler(this.MiCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox usuariocombo;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label Clavelabel;
        private System.Windows.Forms.TextBox ClaveActualtextBox;
        private System.Windows.Forms.Button BTNGestionar;
        private System.Windows.Forms.TextBox CambiarClavetextBox;
        private System.Windows.Forms.TextBox CambiarCodigotextBox;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Label ClaveNuevalabel;
        private System.Windows.Forms.Label label3;
    }
}