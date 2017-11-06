namespace Empresita
{
    partial class frmAltaSucursal
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
            this.lblNombreSucursal = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreSucursal
            // 
            this.lblNombreSucursal.AutoSize = true;
            this.lblNombreSucursal.Location = new System.Drawing.Point(32, 38);
            this.lblNombreSucursal.Name = "lblNombreSucursal";
            this.lblNombreSucursal.Size = new System.Drawing.Size(88, 13);
            this.lblNombreSucursal.TabIndex = 0;
            this.lblNombreSucursal.Text = "Nombre Sucursal";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(32, 91);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 1;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(162, 38);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSucursal.TabIndex = 2;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(162, 84);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(100, 20);
            this.txtDomicilio.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(195, 146);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAltaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 210);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtNombreSucursal);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblNombreSucursal);
            this.Name = "frmAltaSucursal";
            this.Text = "Alta Sucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreSucursal;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Button btnAceptar;
    }
}