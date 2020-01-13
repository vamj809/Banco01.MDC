namespace Banco01.MDC
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// /*<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>*/
        
        

        
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAcceso = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PassTXT = new System.Windows.Forms.TextBox();
            this.UserTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSalir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonAcceso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PassTXT);
            this.groupBox1.Controls.Add(this.UserTXT);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(194, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "test/test";
            // 
            // buttonSalir
            // 
            this.buttonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSalir.Location = new System.Drawing.Point(33, 106);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(84, 30);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // buttonAcceso
            // 
            this.buttonAcceso.Location = new System.Drawing.Point(155, 106);
            this.buttonAcceso.Name = "buttonAcceso";
            this.buttonAcceso.Size = new System.Drawing.Size(84, 30);
            this.buttonAcceso.TabIndex = 2;
            this.buttonAcceso.Text = "Acceder";
            this.buttonAcceso.UseVisualStyleBackColor = true;
            this.buttonAcceso.Click += new System.EventHandler(this.ButtonAcceso_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // PassTXT
            // 
            this.PassTXT.Location = new System.Drawing.Point(33, 80);
            this.PassTXT.Name = "PassTXT";
            this.PassTXT.Size = new System.Drawing.Size(206, 20);
            this.PassTXT.TabIndex = 1;
            this.PassTXT.Text = "test";
            this.PassTXT.UseSystemPasswordChar = true;
            // 
            // UserTXT
            // 
            this.UserTXT.Location = new System.Drawing.Point(33, 34);
            this.UserTXT.Name = "UserTXT";
            this.UserTXT.Size = new System.Drawing.Size(206, 20);
            this.UserTXT.TabIndex = 0;
            this.UserTXT.Text = "test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buenos dias. Por favor inicie sesion para continuar";
            // 
            // Login
            // 
            this.AcceptButton = this.buttonAcceso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSalir;
            this.ClientSize = new System.Drawing.Size(298, 190);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(315, 265);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PassTXT;
        private System.Windows.Forms.TextBox UserTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAcceso;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label1;
    }
}

