namespace Empresita
{
    partial class frmAltaDepartamento
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
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lstSucursal = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.nudPiso = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(32, 25);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(98, 17);
            this.lblDepartamento.TabIndex = 0;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(32, 70);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(35, 17);
            this.lblPiso.TabIndex = 1;
            this.lblPiso.Text = "Piso";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(161, 23);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(247, 23);
            this.txtDepartamento.TabIndex = 2;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(32, 116);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(63, 17);
            this.lblSucursal.TabIndex = 4;
            this.lblSucursal.Text = "Sucursal";
            // 
            // lstSucursal
            // 
            this.lstSucursal.FormattingEnabled = true;
            this.lstSucursal.ItemHeight = 16;
            this.lstSucursal.Location = new System.Drawing.Point(161, 116);
            this.lstSucursal.Name = "lstSucursal";
            this.lstSucursal.ScrollAlwaysVisible = true;
            this.lstSucursal.Size = new System.Drawing.Size(247, 100);
            this.lstSucursal.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(333, 245);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // nudPiso
            // 
            this.nudPiso.Location = new System.Drawing.Point(161, 70);
            this.nudPiso.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudPiso.Name = "nudPiso";
            this.nudPiso.Size = new System.Drawing.Size(122, 23);
            this.nudPiso.TabIndex = 7;
            // 
            // frmAltaDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 292);
            this.Controls.Add(this.nudPiso);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lstSucursal);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblDepartamento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAltaDepartamento";
            this.Text = "frmAltaDepartamento";
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.ListBox lstSucursal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown nudPiso;
    }
}