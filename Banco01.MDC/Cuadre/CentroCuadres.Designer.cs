namespace Banco01.MDC.Cuadre
{
    partial class CentroCuadres
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
            this.DetallesCuadre = new System.Windows.Forms.GroupBox();
            this.BalanceActualLabel = new System.Windows.Forms.Label();
            this.BalanceTitleLabel = new System.Windows.Forms.Label();
            this.CashInputButton = new System.Windows.Forms.Button();
            this.DetallesCuadre.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetallesCuadre
            // 
            this.DetallesCuadre.Controls.Add(this.BalanceActualLabel);
            this.DetallesCuadre.Controls.Add(this.BalanceTitleLabel);
            this.DetallesCuadre.Controls.Add(this.CashInputButton);
            this.DetallesCuadre.Location = new System.Drawing.Point(305, 89);
            this.DetallesCuadre.Margin = new System.Windows.Forms.Padding(4);
            this.DetallesCuadre.Name = "DetallesCuadre";
            this.DetallesCuadre.Padding = new System.Windows.Forms.Padding(4);
            this.DetallesCuadre.Size = new System.Drawing.Size(282, 264);
            this.DetallesCuadre.TabIndex = 0;
            this.DetallesCuadre.TabStop = false;
            this.DetallesCuadre.Text = "Auditoría";
            // 
            // BalanceActualLabel
            // 
            this.BalanceActualLabel.Location = new System.Drawing.Point(19, 145);
            this.BalanceActualLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BalanceActualLabel.Name = "BalanceActualLabel";
            this.BalanceActualLabel.Size = new System.Drawing.Size(246, 29);
            this.BalanceActualLabel.TabIndex = 2;
            this.BalanceActualLabel.Text = "$0.00";
            this.BalanceActualLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BalanceTitleLabel
            // 
            this.BalanceTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BalanceTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BalanceTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTitleLabel.Location = new System.Drawing.Point(8, 89);
            this.BalanceTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BalanceTitleLabel.Name = "BalanceTitleLabel";
            this.BalanceTitleLabel.Size = new System.Drawing.Size(268, 114);
            this.BalanceTitleLabel.TabIndex = 1;
            this.BalanceTitleLabel.Text = "\r\nBalance de Caja:";
            this.BalanceTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CashInputButton
            // 
            this.CashInputButton.Location = new System.Drawing.Point(8, 26);
            this.CashInputButton.Margin = new System.Windows.Forms.Padding(4);
            this.CashInputButton.Name = "CashInputButton";
            this.CashInputButton.Size = new System.Drawing.Size(268, 48);
            this.CashInputButton.TabIndex = 0;
            this.CashInputButton.Text = "Entrada Manual de Efectivo";
            this.CashInputButton.UseVisualStyleBackColor = true;
            this.CashInputButton.Click += new System.EventHandler(this.CashInputButton_Click);
            // 
            // CentroCuadres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 378);
            this.Controls.Add(this.DetallesCuadre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CentroCuadres";
            this.Text = "CentroCuadres";
            this.Load += new System.EventHandler(this.CentroCuadres_Load);
            this.DetallesCuadre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DetallesCuadre;
        private System.Windows.Forms.Label BalanceActualLabel;
        private System.Windows.Forms.Label BalanceTitleLabel;
        private System.Windows.Forms.Button CashInputButton;
    }
}