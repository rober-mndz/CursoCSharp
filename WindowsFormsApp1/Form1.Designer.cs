using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnSaludar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelSaludo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreU = new System.Windows.Forms.Label();
            this.lblApellidoU = new System.Windows.Forms.Label();
            this.lblPesoU = new System.Windows.Forms.Label();
            this.lblAlturaU = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GridUsers = new System.Windows.Forms.DataGridView();
            this.NombreGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlturaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaludar.Location = new System.Drawing.Point(125, 164);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(77, 23);
            this.btnSaludar.TabIndex = 4;
            this.btnSaludar.Text = "Aceptar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // labelSaludo
            // 
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.Location = new System.Drawing.Point(372, 326);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(0, 13);
            this.labelSaludo.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(20, 76);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(76, 73);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(178, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Peso:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(76, 112);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(178, 20);
            this.txtPeso.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(76, 138);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(178, 20);
            this.txtAltura.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese sus datos:";
            // 
            // lblNombreU
            // 
            this.lblNombreU.AutoSize = true;
            this.lblNombreU.Location = new System.Drawing.Point(468, 50);
            this.lblNombreU.Name = "lblNombreU";
            this.lblNombreU.Size = new System.Drawing.Size(0, 13);
            this.lblNombreU.TabIndex = 11;
            // 
            // lblApellidoU
            // 
            this.lblApellidoU.AutoSize = true;
            this.lblApellidoU.Location = new System.Drawing.Point(468, 77);
            this.lblApellidoU.Name = "lblApellidoU";
            this.lblApellidoU.Size = new System.Drawing.Size(0, 13);
            this.lblApellidoU.TabIndex = 12;
            // 
            // lblPesoU
            // 
            this.lblPesoU.AutoSize = true;
            this.lblPesoU.Location = new System.Drawing.Point(468, 116);
            this.lblPesoU.Name = "lblPesoU";
            this.lblPesoU.Size = new System.Drawing.Size(0, 13);
            this.lblPesoU.TabIndex = 13;
            // 
            // lblAlturaU
            // 
            this.lblAlturaU.AutoSize = true;
            this.lblAlturaU.Location = new System.Drawing.Point(468, 142);
            this.lblAlturaU.Name = "lblAlturaU";
            this.lblAlturaU.Size = new System.Drawing.Size(0, 13);
            this.lblAlturaU.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Datos del Usuario:";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(488, 77);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(146, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // GridUsers
            // 
            this.GridUsers.AllowUserToAddRows = false;
            this.GridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreGrid,
            this.ApellidoGrid,
            this.PesoGrid,
            this.AlturaGrid});
            this.GridUsers.Enabled = false;
            this.GridUsers.Location = new System.Drawing.Point(125, 222);
            this.GridUsers.Name = "GridUsers";
            this.GridUsers.ReadOnly = true;
            this.GridUsers.Size = new System.Drawing.Size(443, 192);
            this.GridUsers.TabIndex = 17;
            // 
            // NombreGrid
            // 
            this.NombreGrid.HeaderText = "Nombre";
            this.NombreGrid.Name = "NombreGrid";
            this.NombreGrid.ReadOnly = true;
            // 
            // ApellidoGrid
            // 
            this.ApellidoGrid.HeaderText = "Apellido";
            this.ApellidoGrid.Name = "ApellidoGrid";
            this.ApellidoGrid.ReadOnly = true;
            // 
            // PesoGrid
            // 
            this.PesoGrid.HeaderText = "Peso";
            this.PesoGrid.Name = "PesoGrid";
            this.PesoGrid.ReadOnly = true;
            // 
            // AlturaGrid
            // 
            this.AlturaGrid.HeaderText = "Altura";
            this.AlturaGrid.Name = "AlturaGrid";
            this.AlturaGrid.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 459);
            this.Controls.Add(this.GridUsers);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAlturaU);
            this.Controls.Add(this.lblPesoU);
            this.Controls.Add(this.lblApellidoU);
            this.Controls.Add(this.lblNombreU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.labelSaludo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSaludar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(714, 498);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreU;
        private System.Windows.Forms.Label lblApellidoU;
        private System.Windows.Forms.Label lblPesoU;
        private System.Windows.Forms.Label lblAlturaU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView GridUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlturaGrid;
    }
}

