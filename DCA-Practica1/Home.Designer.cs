
namespace DCA_Practica1
{
    partial class Home
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.Saludo = new System.Windows.Forms.Label();
            this.pictureBuscar = new System.Windows.Forms.PictureBox();
            this.pictureCuenta = new System.Windows.Forms.PictureBox();
            this.pictureNotificar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Agradecimiento = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNotificar)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(668, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cerrar sesión";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureLogo);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Saludo);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 98);
            this.panel1.TabIndex = 2;
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
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Saludo.Location = new System.Drawing.Point(92, 23);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(535, 45);
            this.Saludo.TabIndex = 3;
            this.Saludo.Text = "¡Te doy la bienvenida a Bug Hunter!";
            // 
            // pictureBuscar
            // 
            this.pictureBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBuscar.Image = global::DCA_Practica1.Properties.Resources.search;
            this.pictureBuscar.Location = new System.Drawing.Point(322, 169);
            this.pictureBuscar.Name = "pictureBuscar";
            this.pictureBuscar.Size = new System.Drawing.Size(133, 129);
            this.pictureBuscar.TabIndex = 4;
            this.pictureBuscar.TabStop = false;
            this.pictureBuscar.Click += new System.EventHandler(this.pictureBuscar_Click);
            // 
            // pictureCuenta
            // 
            this.pictureCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCuenta.Image = global::DCA_Practica1.Properties.Resources.user;
            this.pictureCuenta.Location = new System.Drawing.Point(561, 169);
            this.pictureCuenta.Name = "pictureCuenta";
            this.pictureCuenta.Size = new System.Drawing.Size(125, 129);
            this.pictureCuenta.TabIndex = 5;
            this.pictureCuenta.TabStop = false;
            this.pictureCuenta.Click += new System.EventHandler(this.pictureCuenta_Click);
            // 
            // pictureNotificar
            // 
            this.pictureNotificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureNotificar.Image = global::DCA_Practica1.Properties.Resources.file_icon;
            this.pictureNotificar.Location = new System.Drawing.Point(86, 169);
            this.pictureNotificar.Name = "pictureNotificar";
            this.pictureNotificar.Size = new System.Drawing.Size(129, 129);
            this.pictureNotificar.TabIndex = 6;
            this.pictureNotificar.TabStop = false;
            this.pictureNotificar.Click += new System.EventHandler(this.pictureNotificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Notificar un error";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(311, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar errores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(566, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mi cuenta";
            // 
            // Agradecimiento
            // 
            this.Agradecimiento.AutoSize = true;
            this.Agradecimiento.BackColor = System.Drawing.SystemColors.Control;
            this.Agradecimiento.ForeColor = System.Drawing.Color.OliveDrab;
            this.Agradecimiento.Location = new System.Drawing.Point(92, 100);
            this.Agradecimiento.Name = "Agradecimiento";
            this.Agradecimiento.Size = new System.Drawing.Size(0, 20);
            this.Agradecimiento.TabIndex = 10;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.Agradecimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureNotificar);
            this.Controls.Add(this.pictureCuenta);
            this.Controls.Add(this.pictureBuscar);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Bug Hunter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNotificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Saludo;
        private System.Windows.Forms.PictureBox pictureBuscar;
        private System.Windows.Forms.PictureBox pictureCuenta;
        private System.Windows.Forms.PictureBox pictureNotificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label Agradecimiento;
    }
}