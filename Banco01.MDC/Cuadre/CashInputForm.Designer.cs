namespace Banco01.MDC.Cuadre
{
    partial class CashInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashInputForm));
            this.Monto = new System.Windows.Forms.NumericUpDown();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Monto)).BeginInit();
            this.SuspendLayout();
            // 
            // Monto
            // 
            this.Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Monto.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Monto.Location = new System.Drawing.Point(36, 107);
            this.Monto.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(288, 26);
            this.Monto.TabIndex = 1;
            this.Monto.ThousandsSeparator = true;
            this.Monto.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAceptar.Location = new System.Drawing.Point(36, 155);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 27);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(249, 155);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 27);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Esta opción enviará una solicitud a la sucursal principal para que envien más fon" +
    "dos a esta sucursal.";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Especifique monto:";
            // 
            // CashInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(364, 194);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.Monto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CashInputForm";
            this.Text = "Solicitud de Fondos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CashInputForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Monto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.NumericUpDown Monto;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}