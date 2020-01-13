namespace Banco01.MDC.Cajero
{
    partial class AddProfile
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProfile));
            this.textSucursal = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textClave = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isAdminBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textSucursal
            // 
            this.textSucursal.Location = new System.Drawing.Point(85, 152);
            this.textSucursal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSucursal.Name = "textSucursal";
            this.textSucursal.Size = new System.Drawing.Size(116, 20);
            this.textSucursal.TabIndex = 37;
            this.textSucursal.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(85, 125);
            this.textCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(116, 20);
            this.textCorreo.TabIndex = 35;
            this.textCorreo.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Sucursal:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(132, 206);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(69, 19);
            this.buttonCancelar.TabIndex = 39;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(29, 206);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(66, 19);
            this.buttonGuardar.TabIndex = 38;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(85, 96);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(116, 20);
            this.textNombre.TabIndex = 33;
            this.textNombre.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Correo:";
            // 
            // textClave
            // 
            this.textClave.Location = new System.Drawing.Point(86, 58);
            this.textClave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textClave.Name = "textClave";
            this.textClave.Size = new System.Drawing.Size(116, 20);
            this.textClave.TabIndex = 30;
            this.textClave.UseSystemPasswordChar = true;
            this.textClave.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(86, 23);
            this.textUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(116, 20);
            this.textUsuario.TabIndex = 29;
            this.textUsuario.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Usuario:";
            // 
            // isAdminBox
            // 
            this.isAdminBox.AutoSize = true;
            this.isAdminBox.Location = new System.Drawing.Point(68, 179);
            this.isAdminBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isAdminBox.Name = "isAdminBox";
            this.isAdminBox.Size = new System.Drawing.Size(101, 17);
            this.isAdminBox.TabIndex = 40;
            this.isAdminBox.Text = "¿Administrador?";
            this.isAdminBox.UseVisualStyleBackColor = true;
            // 
            // AddProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 246);
            this.Controls.Add(this.isAdminBox);
            this.Controls.Add(this.textSucursal);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textClave);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProfile";
            this.Text = "Nuevo Perfil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProfile_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSucursal;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isAdminBox;
    }
}