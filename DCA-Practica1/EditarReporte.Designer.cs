
namespace DCA_Practica1
{
    partial class EditarReporte
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGravedad = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureLogo);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 98);
            this.panel1.TabIndex = 12;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureLogo.Image = global::DCA_Practica1.Properties.Resources.Sin_nombre;
            this.pictureLogo.Location = new System.Drawing.Point(12, 13);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(74, 80);
            this.pictureLogo.TabIndex = 10;
            this.pictureLogo.TabStop = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(92, 23);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(122, 45);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "[Título]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(203, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "¡Te doy la bienvenida a Bug Hunter!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descripción";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.labelDesc);
            this.panel2.Location = new System.Drawing.Point(12, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 235);
            this.panel2.TabIndex = 14;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(12, 20);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(97, 20);
            this.labelDesc.TabIndex = 7;
            this.labelDesc.Text = "[Descripción]";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAutor.Location = new System.Drawing.Point(12, 118);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(92, 31);
            this.labelAutor.TabIndex = 13;
            this.labelAutor.Text = "[Autor]";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(642, 183);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(127, 28);
            this.comboBoxEstado.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(642, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Estado";
            // 
            // labelGravedad
            // 
            this.labelGravedad.AutoSize = true;
            this.labelGravedad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGravedad.Location = new System.Drawing.Point(431, 253);
            this.labelGravedad.Name = "labelGravedad";
            this.labelGravedad.Size = new System.Drawing.Size(18, 28);
            this.labelGravedad.TabIndex = 19;
            this.labelGravedad.Text = " ";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTipo.Location = new System.Drawing.Point(431, 183);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(18, 28);
            this.labelTipo.TabIndex = 18;
            this.labelTipo.Text = " ";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(431, 389);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(175, 29);
            this.buttonConfirmar.TabIndex = 20;
            this.buttonConfirmar.Text = "Confirmar cambios";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // EditarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.labelGravedad);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "EditarReporte";
            this.Text = "Bug Hunter";
            this.Load += new System.EventHandler(this.EditarReporte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGravedad;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Button buttonConfirmar;
    }
}