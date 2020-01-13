namespace Banco01.MDC
{
    partial class OperacionesCliente
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
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonBackOPCLiente = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(270, 188);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(260, 70);
            this.buttonWithdraw.TabIndex = 7;
            this.buttonWithdraw.Text = "Realizar un retiro";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBackOPCLiente
            // 
            this.buttonBackOPCLiente.Location = new System.Drawing.Point(270, 309);
            this.buttonBackOPCLiente.Name = "buttonBackOPCLiente";
            this.buttonBackOPCLiente.Size = new System.Drawing.Size(260, 70);
            this.buttonBackOPCLiente.TabIndex = 6;
            this.buttonBackOPCLiente.Text = "Volver al menu anterior";
            this.buttonBackOPCLiente.UseVisualStyleBackColor = true;
            this.buttonBackOPCLiente.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(270, 72);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(260, 70);
            this.buttonDeposit.TabIndex = 5;
            this.buttonDeposit.Text = "Realizar un Deposito";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.button1_Click);
            // 
            // OperacionesCLiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.buttonBackOPCLiente);
            this.Controls.Add(this.buttonDeposit);
            this.Name = "OperacionesCLiente";
            this.Text = "Operaciones con el cliente";
            this.Load += new System.EventHandler(this.OperacionesCLiente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonBackOPCLiente;
        private System.Windows.Forms.Button buttonDeposit;
    }
}