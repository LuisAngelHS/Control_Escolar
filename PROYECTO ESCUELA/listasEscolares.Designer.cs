namespace PROYECTO_ESCUELA
{
    partial class listasEscolares
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.listassexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Control_Escolar1DataSet = new PROYECTO_ESCUELA.Control_Escolar1DataSet();
            this.listasgrado1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fastasma1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fastasmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listasgradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fastasmaTableAdapter = new PROYECTO_ESCUELA.Control_Escolar1DataSetTableAdapters.fastasmaTableAdapter();
            this.listassexoTableAdapter = new PROYECTO_ESCUELA.Control_Escolar1DataSetTableAdapters.listassexoTableAdapter();
            this.listasgradoTableAdapter = new PROYECTO_ESCUELA.Control_Escolar1DataSetTableAdapters.listasgradoTableAdapter();
            this.listasgrado1TableAdapter = new PROYECTO_ESCUELA.Control_Escolar1DataSetTableAdapters.listasgrado1TableAdapter();
            this.gradoesTableAdapter = new PROYECTO_ESCUELA.Control_Escolar1DataSetTableAdapters.gradoesTableAdapter();
            this.fastasma1TableAdapter = new PROYECTO_ESCUELA.Control_Escolar1DataSetTableAdapters.fastasma1TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fantas2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fantas2TableAdapter = new PROYECTO_ESCUELA.Control_Escolar1DataSetTableAdapters.fantas2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listassexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_Escolar1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasgrado1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastasma1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastasmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasgradoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantas2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listassexoBindingSource
            // 
            this.listassexoBindingSource.DataMember = "listassexo";
            this.listassexoBindingSource.DataSource = this.Control_Escolar1DataSet;
            // 
            // Control_Escolar1DataSet
            // 
            this.Control_Escolar1DataSet.DataSetName = "Control_Escolar1DataSet";
            this.Control_Escolar1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listasgrado1BindingSource
            // 
            this.listasgrado1BindingSource.DataMember = "listasgrado1";
            this.listasgrado1BindingSource.DataSource = this.Control_Escolar1DataSet;
            // 
            // gradoesBindingSource
            // 
            this.gradoesBindingSource.DataMember = "gradoes";
            this.gradoesBindingSource.DataSource = this.Control_Escolar1DataSet;
            // 
            // fastasma1BindingSource
            // 
            this.fastasma1BindingSource.DataMember = "fastasma1";
            this.fastasma1BindingSource.DataSource = this.Control_Escolar1DataSet;
            // 
            // fastasmaBindingSource
            // 
            this.fastasmaBindingSource.DataMember = "fastasma";
            this.fastasmaBindingSource.DataSource = this.Control_Escolar1DataSet;
            // 
            // listasgradoBindingSource
            // 
            this.listasgradoBindingSource.DataMember = "listasgrado";
            this.listasgradoBindingSource.DataSource = this.Control_Escolar1DataSet;
            // 
            // fastasmaTableAdapter
            // 
            this.fastasmaTableAdapter.ClearBeforeFill = true;
            // 
            // listassexoTableAdapter
            // 
            this.listassexoTableAdapter.ClearBeforeFill = true;
            // 
            // listasgradoTableAdapter
            // 
            this.listasgradoTableAdapter.ClearBeforeFill = true;
            // 
            // listasgrado1TableAdapter
            // 
            this.listasgrado1TableAdapter.ClearBeforeFill = true;
            // 
            // gradoesTableAdapter
            // 
            this.gradoesTableAdapter.ClearBeforeFill = true;
            // 
            // fastasma1TableAdapter
            // 
            this.fastasma1TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.listassexoBindingSource;
            reportDataSource2.Name = "DataSet4";
            reportDataSource2.Value = this.listasgrado1BindingSource;
            reportDataSource3.Name = "DataSet5";
            reportDataSource3.Value = this.gradoesBindingSource;
            reportDataSource4.Name = "DataSet6";
            reportDataSource4.Value = this.fastasma1BindingSource;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.fantas2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTO_ESCUELA.listas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(651, 369);
            this.reportViewer1.TabIndex = 0;
            // 
            // fantas2BindingSource
            // 
            this.fantas2BindingSource.DataMember = "fantas2";
            this.fantas2BindingSource.DataSource = this.Control_Escolar1DataSet;
            // 
            // fantas2TableAdapter
            // 
            this.fantas2TableAdapter.ClearBeforeFill = true;
            // 
            // listasEscolares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 369);
            this.Controls.Add(this.reportViewer1);
            this.Name = "listasEscolares";
            this.Text = "listasEscolares";
            this.Load += new System.EventHandler(this.listasEscolares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listassexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_Escolar1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasgrado1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastasma1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastasmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasgradoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantas2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource fastasmaBindingSource;
        private Control_Escolar1DataSet Control_Escolar1DataSet;
        private System.Windows.Forms.BindingSource listassexoBindingSource;
        private System.Windows.Forms.BindingSource listasgradoBindingSource;
        private Control_Escolar1DataSetTableAdapters.fastasmaTableAdapter fastasmaTableAdapter;
        private Control_Escolar1DataSetTableAdapters.listassexoTableAdapter listassexoTableAdapter;
        private Control_Escolar1DataSetTableAdapters.listasgradoTableAdapter listasgradoTableAdapter;
        private System.Windows.Forms.BindingSource listasgrado1BindingSource;
        private System.Windows.Forms.BindingSource gradoesBindingSource;
        private Control_Escolar1DataSetTableAdapters.listasgrado1TableAdapter listasgrado1TableAdapter;
        private Control_Escolar1DataSetTableAdapters.gradoesTableAdapter gradoesTableAdapter;
        private System.Windows.Forms.BindingSource fastasma1BindingSource;
        private Control_Escolar1DataSetTableAdapters.fastasma1TableAdapter fastasma1TableAdapter;
        private System.Windows.Forms.BindingSource fantas2BindingSource;
        private Control_Escolar1DataSetTableAdapters.fantas2TableAdapter fantas2TableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}