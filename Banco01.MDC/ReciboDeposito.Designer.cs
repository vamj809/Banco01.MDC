namespace Banco01.MDC
{
    partial class ReciboDeposito
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DepositoDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetParaRecibos = new Banco01.MDC.DataSetParaRecibos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DepositoDatosTableAdapter = new Banco01.MDC.DataSetParaRecibosTableAdapters.DepositoDatosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DepositoDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetParaRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // DepositoDatosBindingSource
            // 
            this.DepositoDatosBindingSource.DataMember = "DepositoDatos";
            this.DepositoDatosBindingSource.DataSource = this.DataSetParaRecibos;
            // 
            // DataSetParaRecibos
            // 
            this.DataSetParaRecibos.DataSetName = "DataSetParaRecibos";
            this.DataSetParaRecibos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DatosDeDeposito";
            reportDataSource3.Value = this.DepositoDatosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Banco01.MDC.ReciboDep.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 346);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver al menu principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DepositoDatosTableAdapter
            // 
            this.DepositoDatosTableAdapter.ClearBeforeFill = true;
            // 
            // ReciboDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReciboDeposito";
            this.Text = "Recibo";
            this.Load += new System.EventHandler(this.ReciboDeposito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepositoDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetParaRecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DepositoDatosBindingSource;
        private DataSetParaRecibos DataSetParaRecibos;
        private DataSetParaRecibosTableAdapters.DepositoDatosTableAdapter DepositoDatosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}