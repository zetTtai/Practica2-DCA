
namespace DCA_Practica1
{
    partial class Report
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonImportante = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextDesc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonMenor = new System.Windows.Forms.RadioButton();
            this.radioButtonSugerencia = new System.Windows.Forms.RadioButton();
            this.radioButtonCritico = new System.Windows.Forms.RadioButton();
            this.radioButtonGrave = new System.Windows.Forms.RadioButton();
            this.radioButtonSerio = new System.Windows.Forms.RadioButton();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelGravedad = new System.Windows.Forms.Label();
            this.TipoError = new System.Windows.Forms.GroupBox();
            this.GravedadError = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.TipoError.SuspendLayout();
            this.GravedadError.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureLogo);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 98);
            this.panel1.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "¿Has encontrado un bug? ¡Reportarlo!";
            // 
            // radioButtonImportante
            // 
            this.radioButtonImportante.AutoSize = true;
            this.radioButtonImportante.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButtonImportante.ForeColor = System.Drawing.Color.Red;
            this.radioButtonImportante.Location = new System.Drawing.Point(7, 30);
            this.radioButtonImportante.Name = "radioButtonImportante";
            this.radioButtonImportante.Size = new System.Drawing.Size(104, 24);
            this.radioButtonImportante.TabIndex = 4;
            this.radioButtonImportante.TabStop = true;
            this.radioButtonImportante.Text = "Importante";
            this.radioButtonImportante.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Comenzar la cacería";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LetsHunt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Título";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(36, 133);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(278, 27);
            this.textNombre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Breve descripción";
            // 
            // richTextDesc
            // 
            this.richTextDesc.Location = new System.Drawing.Point(37, 214);
            this.richTextDesc.Name = "richTextDesc";
            this.richTextDesc.Size = new System.Drawing.Size(277, 147);
            this.richTextDesc.TabIndex = 10;
            this.richTextDesc.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(2, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo de error";
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButtonNormal.ForeColor = System.Drawing.Color.OrangeRed;
            this.radioButtonNormal.Location = new System.Drawing.Point(6, 74);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(80, 24);
            this.radioButtonNormal.TabIndex = 13;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = false;
            // 
            // radioButtonMenor
            // 
            this.radioButtonMenor.AutoSize = true;
            this.radioButtonMenor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButtonMenor.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radioButtonMenor.Location = new System.Drawing.Point(7, 119);
            this.radioButtonMenor.Name = "radioButtonMenor";
            this.radioButtonMenor.Size = new System.Drawing.Size(73, 24);
            this.radioButtonMenor.TabIndex = 14;
            this.radioButtonMenor.TabStop = true;
            this.radioButtonMenor.Text = "Menor";
            this.radioButtonMenor.UseVisualStyleBackColor = false;
            // 
            // radioButtonSugerencia
            // 
            this.radioButtonSugerencia.AutoSize = true;
            this.radioButtonSugerencia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButtonSugerencia.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radioButtonSugerencia.Location = new System.Drawing.Point(6, 163);
            this.radioButtonSugerencia.Name = "radioButtonSugerencia";
            this.radioButtonSugerencia.Size = new System.Drawing.Size(103, 24);
            this.radioButtonSugerencia.TabIndex = 15;
            this.radioButtonSugerencia.TabStop = true;
            this.radioButtonSugerencia.Text = "Sugerencia";
            this.radioButtonSugerencia.UseVisualStyleBackColor = false;
            // 
            // radioButtonCritico
            // 
            this.radioButtonCritico.AutoSize = true;
            this.radioButtonCritico.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButtonCritico.ForeColor = System.Drawing.Color.Red;
            this.radioButtonCritico.Location = new System.Drawing.Point(600, 161);
            this.radioButtonCritico.Name = "radioButtonCritico";
            this.radioButtonCritico.Size = new System.Drawing.Size(73, 24);
            this.radioButtonCritico.TabIndex = 16;
            this.radioButtonCritico.TabStop = true;
            this.radioButtonCritico.Text = "Crítico";
            this.radioButtonCritico.UseVisualStyleBackColor = false;
            // 
            // radioButtonGrave
            // 
            this.radioButtonGrave.AutoSize = true;
            this.radioButtonGrave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButtonGrave.ForeColor = System.Drawing.Color.OrangeRed;
            this.radioButtonGrave.Location = new System.Drawing.Point(600, 207);
            this.radioButtonGrave.Name = "radioButtonGrave";
            this.radioButtonGrave.Size = new System.Drawing.Size(68, 24);
            this.radioButtonGrave.TabIndex = 17;
            this.radioButtonGrave.TabStop = true;
            this.radioButtonGrave.Text = "Grave";
            this.radioButtonGrave.UseVisualStyleBackColor = false;
            // 
            // radioButtonSerio
            // 
            this.radioButtonSerio.AutoSize = true;
            this.radioButtonSerio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButtonSerio.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radioButtonSerio.Location = new System.Drawing.Point(600, 252);
            this.radioButtonSerio.Name = "radioButtonSerio";
            this.radioButtonSerio.Size = new System.Drawing.Size(64, 24);
            this.radioButtonSerio.TabIndex = 18;
            this.radioButtonSerio.TabStop = true;
            this.radioButtonSerio.Text = "Serio";
            this.radioButtonSerio.UseVisualStyleBackColor = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.SystemColors.Control;
            this.labelNombre.ForeColor = System.Drawing.Color.Red;
            this.labelNombre.Location = new System.Drawing.Point(37, 163);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(13, 20);
            this.labelNombre.TabIndex = 21;
            this.labelNombre.Text = " ";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.BackColor = System.Drawing.SystemColors.Control;
            this.labelDesc.ForeColor = System.Drawing.Color.Red;
            this.labelDesc.Location = new System.Drawing.Point(37, 364);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(13, 20);
            this.labelDesc.TabIndex = 22;
            this.labelDesc.Text = " ";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.BackColor = System.Drawing.SystemColors.Control;
            this.labelTipo.ForeColor = System.Drawing.Color.Red;
            this.labelTipo.Location = new System.Drawing.Point(388, 364);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(13, 20);
            this.labelTipo.TabIndex = 23;
            this.labelTipo.Text = " ";
            // 
            // labelGravedad
            // 
            this.labelGravedad.AutoSize = true;
            this.labelGravedad.BackColor = System.Drawing.SystemColors.Control;
            this.labelGravedad.ForeColor = System.Drawing.Color.Red;
            this.labelGravedad.Location = new System.Drawing.Point(593, 364);
            this.labelGravedad.Name = "labelGravedad";
            this.labelGravedad.Size = new System.Drawing.Size(13, 20);
            this.labelGravedad.TabIndex = 24;
            this.labelGravedad.Text = " ";
            // 
            // TipoError
            // 
            this.TipoError.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TipoError.Controls.Add(this.radioButtonImportante);
            this.TipoError.Controls.Add(this.radioButtonNormal);
            this.TipoError.Controls.Add(this.radioButtonMenor);
            this.TipoError.Controls.Add(this.radioButtonSugerencia);
            this.TipoError.Location = new System.Drawing.Point(388, 133);
            this.TipoError.Name = "TipoError";
            this.TipoError.Size = new System.Drawing.Size(155, 228);
            this.TipoError.TabIndex = 25;
            this.TipoError.TabStop = false;
            // 
            // GravedadError
            // 
            this.GravedadError.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GravedadError.Controls.Add(this.radioButton1);
            this.GravedadError.Controls.Add(this.radioButton2);
            this.GravedadError.Controls.Add(this.radioButton3);
            this.GravedadError.Location = new System.Drawing.Point(593, 133);
            this.GravedadError.Name = "GravedadError";
            this.GravedadError.Size = new System.Drawing.Size(155, 228);
            this.GravedadError.TabIndex = 26;
            this.GravedadError.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton1.ForeColor = System.Drawing.Color.Red;
            this.radioButton1.Location = new System.Drawing.Point(7, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Crítico";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton2.ForeColor = System.Drawing.Color.OrangeRed;
            this.radioButton2.Location = new System.Drawing.Point(6, 74);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 24);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Grave";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radioButton3.Location = new System.Drawing.Point(7, 119);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 24);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Serio";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(388, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 29);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(593, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 29);
            this.panel3.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(2, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gravedad del error";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GravedadError);
            this.Controls.Add(this.TipoError);
            this.Controls.Add(this.labelGravedad);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.radioButtonSerio);
            this.Controls.Add(this.radioButtonGrave);
            this.Controls.Add(this.radioButtonCritico);
            this.Controls.Add(this.richTextDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Report";
            this.Text = "Bug Hunter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.TipoError.ResumeLayout(false);
            this.TipoError.PerformLayout();
            this.GravedadError.ResumeLayout(false);
            this.GravedadError.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonImportante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonMenor;
        private System.Windows.Forms.RadioButton radioButtonSugerencia;
        private System.Windows.Forms.RadioButton radioButtonCritico;
        private System.Windows.Forms.RadioButton radioButtonGrave;
        private System.Windows.Forms.RadioButton radioButtonSerio;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelGravedad;
        private System.Windows.Forms.GroupBox TipoError;
        private System.Windows.Forms.GroupBox GravedadError;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
    }
}