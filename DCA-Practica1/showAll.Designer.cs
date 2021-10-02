
namespace DCA_Practica1
{
    partial class showAll
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
            this.dataGridViewReportes = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureLogo);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 98);
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
            this.button2.Location = new System.Drawing.Point(647, 39);
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
            this.label1.Size = new System.Drawing.Size(479, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de reportes de Bug Hunter";
            // 
            // dataGridViewReportes
            // 
            this.dataGridViewReportes.AllowUserToAddRows = false;
            this.dataGridViewReportes.AllowUserToDeleteRows = false;
            this.dataGridViewReportes.AllowUserToOrderColumns = true;
            this.dataGridViewReportes.AllowUserToResizeColumns = false;
            this.dataGridViewReportes.AllowUserToResizeRows = false;
            this.dataGridViewReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportes.Location = new System.Drawing.Point(12, 171);
            this.dataGridViewReportes.Name = "dataGridViewReportes";
            this.dataGridViewReportes.ReadOnly = true;
            this.dataGridViewReportes.RowHeadersVisible = false;
            this.dataGridViewReportes.RowHeadersWidth = 51;
            this.dataGridViewReportes.RowTemplate.Height = 29;
            this.dataGridViewReportes.Size = new System.Drawing.Size(756, 267);
            this.dataGridViewReportes.TabIndex = 5;
            this.dataGridViewReportes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonBuscar.Location = new System.Drawing.Point(11, 142);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscar.TabIndex = 7;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(101, 143);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(249, 27);
            this.textBoxTitulo.TabIndex = 8;
            // 
            // showAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dataGridViewReportes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "showAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Hunter";
            this.Load += new System.EventHandler(this.showAll_Load);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewReportes;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxTitulo;
    }
}