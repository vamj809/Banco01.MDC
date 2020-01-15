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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetParaRecibos = new Banco01.MDC.DataSetParaRecibos();
            this.DepositoDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DepositoDatosTableAdapter = new Banco01.MDC.DataSetParaRecibosTableAdapters.DepositoDatosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetParaRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositoDatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosDeDeposito";
            reportDataSource1.Value = this.DepositoDatosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Banco01.MDC.ReciboDep.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetParaRecibos
            // 
            this.DataSetParaRecibos.DataSetName = "DataSetParaRecibos";
            this.DataSetParaRecibos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DepositoDatosBindingSource
            // 
            this.DepositoDatosBindingSource.DataMember = "DepositoDatos";
            this.DepositoDatosBindingSource.DataSource = this.DataSetParaRecibos;
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
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReciboDeposito";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReciboDeposito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetParaRecibos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositoDatosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DepositoDatosBindingSource;
        private DataSetParaRecibos DataSetParaRecibos;
        private DataSetParaRecibosTableAdapters.DepositoDatosTableAdapter DepositoDatosTableAdapter;
    }
}