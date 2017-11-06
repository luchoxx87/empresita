namespace Empresita
{
    partial class frmAltaEmpleado
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lstDepartamento = new System.Windows.Forms.ListBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lstJefe = new System.Windows.Forms.ListBox();
            this.chkJefe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(20, 63);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lstDepartamento
            // 
            this.lstDepartamento.FormattingEnabled = true;
            this.lstDepartamento.HorizontalScrollbar = true;
            this.lstDepartamento.ItemHeight = 16;
            this.lstDepartamento.Location = new System.Drawing.Point(410, 39);
            this.lstDepartamento.Name = "lstDepartamento";
            this.lstDepartamento.ScrollAlwaysVisible = true;
            this.lstDepartamento.Size = new System.Drawing.Size(142, 228);
            this.lstDepartamento.TabIndex = 2;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(425, 9);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(98, 17);
            this.lblDepartamento.TabIndex = 3;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(121, 63);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(222, 23);
            this.txtApellido.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(477, 292);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lstJefe
            // 
            this.lstJefe.FormattingEnabled = true;
            this.lstJefe.HorizontalScrollbar = true;
            this.lstJefe.ItemHeight = 16;
            this.lstJefe.Location = new System.Drawing.Point(131, 121);
            this.lstJefe.Name = "lstJefe";
            this.lstJefe.ScrollAlwaysVisible = true;
            this.lstJefe.Size = new System.Drawing.Size(212, 164);
            this.lstJefe.TabIndex = 8;
            // 
            // chkJefe
            // 
            this.chkJefe.AutoSize = true;
            this.chkJefe.Checked = true;
            this.chkJefe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJefe.Location = new System.Drawing.Point(15, 121);
            this.chkJefe.Name = "chkJefe";
            this.chkJefe.Size = new System.Drawing.Size(110, 21);
            this.chkJefe.TabIndex = 9;
            this.chkJefe.Text = "¿Tiene Jefe?";
            this.chkJefe.UseVisualStyleBackColor = true;
            this.chkJefe.CheckStateChanged += new System.EventHandler(this.chkJefe_CheckStateChanged);
            // 
            // frmAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 351);
            this.Controls.Add(this.chkJefe);
            this.Controls.Add(this.lstJefe);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lstDepartamento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAltaEmpleado";
            this.Text = "Alta Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ListBox lstDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox lstJefe;
        private System.Windows.Forms.CheckBox chkJefe;
    }
}