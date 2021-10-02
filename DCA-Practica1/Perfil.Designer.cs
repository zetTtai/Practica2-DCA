
namespace DCA_Practica1
{
    partial class Perfil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.Saludo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.showConfirm = new System.Windows.Forms.CheckBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.textPasswordConfirm = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewReportes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureLogo);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.Saludo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 98);
            this.panel1.TabIndex = 11;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLogo.Image = global::DCA_Practica1.Properties.Resources.Sin_nombre;
            this.pictureLogo.Location = new System.Drawing.Point(12, 13);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(74, 80);
            this.pictureLogo.TabIndex = 10;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogOut.Location = new System.Drawing.Point(767, 39);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(120, 29);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "Cerrar sesión";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Saludo.Location = new System.Drawing.Point(92, 23);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(153, 45);
            this.Saludo.TabIndex = 3;
            this.Saludo.Text = "Mi perfil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(12, 146);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(192, 27);
            this.textNombre.TabIndex = 13;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.Color.Red;
            this.labelNombre.Location = new System.Drawing.Point(12, 176);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(13, 20);
            this.labelNombre.TabIndex = 14;
            this.labelNombre.Text = " ";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(12, 236);
            this.textEmail.Name = "textEmail";
            this.textEmail.ReadOnly = true;
            this.textEmail.Size = new System.Drawing.Size(192, 27);
            this.textEmail.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Correo electrónico";
            // 
            // showConfirm
            // 
            this.showConfirm.AutoSize = true;
            this.showConfirm.Location = new System.Drawing.Point(467, 237);
            this.showConfirm.Name = "showConfirm";
            this.showConfirm.Size = new System.Drawing.Size(158, 24);
            this.showConfirm.TabIndex = 26;
            this.showConfirm.Text = "Mostrar contraseña";
            this.showConfirm.UseVisualStyleBackColor = true;
            this.showConfirm.CheckedChanged += new System.EventHandler(this.showConfirm_CheckedChanged);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(467, 148);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(158, 24);
            this.showPassword.TabIndex = 25;
            this.showPassword.Text = "Mostrar contraseña";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.Color.Red;
            this.labelPassword.Location = new System.Drawing.Point(243, 176);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(13, 20);
            this.labelPassword.TabIndex = 24;
            this.labelPassword.Text = " ";
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.ForeColor = System.Drawing.Color.Red;
            this.labelConfirm.Location = new System.Drawing.Point(243, 267);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(13, 20);
            this.labelConfirm.TabIndex = 23;
            this.labelConfirm.Text = " ";
            // 
            // textPasswordConfirm
            // 
            this.textPasswordConfirm.Location = new System.Drawing.Point(243, 237);
            this.textPasswordConfirm.Name = "textPasswordConfirm";
            this.textPasswordConfirm.Size = new System.Drawing.Size(218, 27);
            this.textPasswordConfirm.TabIndex = 22;
            this.textPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(243, 146);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(218, 27);
            this.textPassword.TabIndex = 21;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(243, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Confirmar contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(243, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contraseña";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmar.Location = new System.Drawing.Point(712, 170);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(120, 63);
            this.buttonConfirmar.TabIndex = 27;
            this.buttonConfirmar.Text = "Confirmar\r\nCambios";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "MIS REPORTES";
            // 
            // dataGridViewReportes
            // 
            this.dataGridViewReportes.AllowUserToAddRows = false;
            this.dataGridViewReportes.AllowUserToDeleteRows = false;
            this.dataGridViewReportes.AllowUserToOrderColumns = true;
            this.dataGridViewReportes.AllowUserToResizeColumns = false;
            this.dataGridViewReportes.AllowUserToResizeRows = false;
            this.dataGridViewReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportes.Location = new System.Drawing.Point(12, 307);
            this.dataGridViewReportes.Name = "dataGridViewReportes";
            this.dataGridViewReportes.ReadOnly = true;
            this.dataGridViewReportes.RowHeadersVisible = false;
            this.dataGridViewReportes.RowHeadersWidth = 51;
            this.dataGridViewReportes.RowTemplate.Height = 29;
            this.dataGridViewReportes.Size = new System.Drawing.Size(880, 131);
            this.dataGridViewReportes.TabIndex = 30;
            this.dataGridViewReportes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReportes_CellContentClick);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.dataGridViewReportes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.showConfirm);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelConfirm);
            this.Controls.Add(this.textPasswordConfirm);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Hunter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label Saludo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showConfirm;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.TextBox textPasswordConfirm;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewReportes;
    }
}