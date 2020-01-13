namespace Banco01.MDC.Cuadre
{
    partial class FinalDelDia
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.historialTransaccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDCLocalDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDC_LocalDBDataSet = new Banco01.MDC.Resources.MDC_LocalDBDataSet();
            this.historialTransaccionesTableAdapter = new Banco01.MDC.Resources.MDC_LocalDBDataSetTableAdapters.HistorialTransaccionesTableAdapter();
            this.getTransactionsHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getTransactionsHistoryTableAdapter = new Banco01.MDC.Resources.MDC_LocalDBDataSetTableAdapters.GetTransactionsHistoryTableAdapter();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLabel = new System.Windows.Forms.Label();
            this.MontoInicioLabel = new System.Windows.Forms.Label();
            this.MontoFinLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialTransaccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDCLocalDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDC_LocalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTransactionsHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Nombre,
            this.tipoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getTransactionsHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // historialTransaccionesBindingSource
            // 
            this.historialTransaccionesBindingSource.DataMember = "HistorialTransacciones";
            this.historialTransaccionesBindingSource.DataSource = this.mDCLocalDBDataSetBindingSource;
            // 
            // mDCLocalDBDataSetBindingSource
            // 
            this.mDCLocalDBDataSetBindingSource.DataSource = this.mDC_LocalDBDataSet;
            this.mDCLocalDBDataSetBindingSource.Position = 0;
            // 
            // mDC_LocalDBDataSet
            // 
            this.mDC_LocalDBDataSet.DataSetName = "MDC_LocalDBDataSet";
            this.mDC_LocalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historialTransaccionesTableAdapter
            // 
            this.historialTransaccionesTableAdapter.ClearBeforeFill = true;
            // 
            // getTransactionsHistoryBindingSource
            // 
            this.getTransactionsHistoryBindingSource.DataMember = "GetTransactionsHistory";
            this.getTransactionsHistoryBindingSource.DataSource = this.mDC_LocalDBDataSet;
            // 
            // getTransactionsHistoryTableAdapter
            // 
            this.getTransactionsHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Cajero/a";
            this.Nombre.Name = "Nombre";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(100, 365);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(35, 13);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "label1";
            // 
            // MontoInicioLabel
            // 
            this.MontoInicioLabel.AutoSize = true;
            this.MontoInicioLabel.Location = new System.Drawing.Point(306, 365);
            this.MontoInicioLabel.Name = "MontoInicioLabel";
            this.MontoInicioLabel.Size = new System.Drawing.Size(35, 13);
            this.MontoInicioLabel.TabIndex = 2;
            this.MontoInicioLabel.Text = "label1";
            // 
            // MontoFinLabel
            // 
            this.MontoFinLabel.AutoSize = true;
            this.MontoFinLabel.Location = new System.Drawing.Point(526, 365);
            this.MontoFinLabel.Name = "MontoFinLabel";
            this.MontoFinLabel.Size = new System.Drawing.Size(35, 13);
            this.MontoFinLabel.TabIndex = 3;
            this.MontoFinLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Monto Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monto Final:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver al menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FinalDelDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 398);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MontoFinLabel);
            this.Controls.Add(this.MontoInicioLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FinalDelDia";
            this.Text = "FinalDelDia";
            this.Load += new System.EventHandler(this.FinalDelDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialTransaccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDCLocalDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDC_LocalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTransactionsHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mDCLocalDBDataSetBindingSource;
        private Resources.MDC_LocalDBDataSet mDC_LocalDBDataSet;
        private System.Windows.Forms.BindingSource historialTransaccionesBindingSource;
        private Resources.MDC_LocalDBDataSetTableAdapters.HistorialTransaccionesTableAdapter historialTransaccionesTableAdapter;
        private System.Windows.Forms.BindingSource getTransactionsHistoryBindingSource;
        private Resources.MDC_LocalDBDataSetTableAdapters.GetTransactionsHistoryTableAdapter getTransactionsHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label MontoInicioLabel;
        private System.Windows.Forms.Label MontoFinLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}