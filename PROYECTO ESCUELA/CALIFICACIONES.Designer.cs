namespace PROYECTO_ESCUELA
{
    partial class CALIFICACIONES
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.fastasmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Control_Escolar1DataSet = new PROYECTO_ESCUELA.Control_Escolar1DataSet();
            this.mtralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fastasmaTableAdapter = new PROYECTO_ESCUELA.Control_Escolar1DataSetTableAdapters.fastasmaTableAdapter();
            this.mtralTableAdapter = new PROYECTO_ESCUELA.Control_Escolar1DataSetTableAdapters.mtralTableAdapter();
            this.materTableAdapter = new PROYECTO_ESCUELA.Control_Escolar1DataSetTableAdapters.materTableAdapter();
            this.gradoesTableAdapter = new PROYECTO_ESCUELA.Control_Escolar1DataSetTableAdapters.gradoesTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.promgeneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promgeneTableAdapter = new PROYECTO_ESCUELA.Control_Escolar1DataSetTableAdapters.promgeneTableAdapter();
            this.FANTASMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FANTASMTableAdapter = new PROYECTO_ESCUELA.Control_Escolar1DataSetTableAdapters.FANTASMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fastasmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_Escolar1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promgeneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FANTASMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fastasmaBindingSource
            // 
            this.fastasmaBindingSource.DataMember = "fastasma";
            this.fastasmaBindingSource.DataSource = this.Control_Escolar1DataSet;
            // 
            // Control_Escolar1DataSet
            // 
            this.Control_Escolar1DataSet.DataSetName = "Control_Escolar1DataSet";
            this.Control_Escolar1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mtralBindingSource
            // 
            this.mtralBindingSource.DataMember = "mtral";
            this.mtralBindingSource.DataSource = this.Control_Escolar1DataSet;
            // 
            // materBindingSource
            // 
            this.materBindingSource.DataMember = "mater";
            this.materBindingSource.DataSource = this.Control_Escolar1DataSet;
            // 
            // gradoesBindingSource
            // 
            this.gradoesBindingSource.DataMember = "gradoes";
            this.gradoesBindingSource.DataSource = this.Control_Escolar1DataSet;
            // 
            // fastasmaTableAdapter
            // 
            this.fastasmaTableAdapter.ClearBeforeFill = true;
            // 
            // mtralTableAdapter
            // 
            this.mtralTableAdapter.ClearBeforeFill = true;
            // 
            // materTableAdapter
            // 
            this.materTableAdapter.ClearBeforeFill = true;
            // 
            // gradoesTableAdapter
            // 
            this.gradoesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.fastasmaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.mtralBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.materBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.gradoesBindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.promgeneBindingSource;
            reportDataSource6.Name = "DataSet6";
            reportDataSource6.Value = this.FANTASMBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTO_ESCUELA.calificaciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_2);
            // 
            // promgeneBindingSource
            // 
            this.promgeneBindingSource.DataMember = "promgene";
            this.promgeneBindingSource.DataSource = this.Control_Escolar1DataSet;
            // 
            // promgeneTableAdapter
            // 
            this.promgeneTableAdapter.ClearBeforeFill = true;
            // 
            // FANTASMBindingSource
            // 
            this.FANTASMBindingSource.DataMember = "FANTASM";
            this.FANTASMBindingSource.DataSource = this.Control_Escolar1DataSet;
            // 
            // FANTASMTableAdapter
            // 
            this.FANTASMTableAdapter.ClearBeforeFill = true;
            // 
            // CALIFICACIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CALIFICACIONES";
            this.Text = "CALIFICACIONES";
            this.Load += new System.EventHandler(this.CALIFICACIONES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fastasmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_Escolar1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promgeneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FANTASMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource fastasmaBindingSource;
        private Control_Escolar1DataSet Control_Escolar1DataSet;
        private System.Windows.Forms.BindingSource mtralBindingSource;
        private System.Windows.Forms.BindingSource materBindingSource;
        private Control_Escolar1DataSetTableAdapters.fastasmaTableAdapter fastasmaTableAdapter;
        private Control_Escolar1DataSetTableAdapters.mtralTableAdapter mtralTableAdapter;
        private Control_Escolar1DataSetTableAdapters.materTableAdapter materTableAdapter;
        private System.Windows.Forms.BindingSource gradoesBindingSource;
        private Control_Escolar1DataSetTableAdapters.gradoesTableAdapter gradoesTableAdapter;
        private System.Windows.Forms.BindingSource promgeneBindingSource;
        private System.Windows.Forms.BindingSource FANTASMBindingSource;
        private Control_Escolar1DataSetTableAdapters.promgeneTableAdapter promgeneTableAdapter;
        private Control_Escolar1DataSetTableAdapters.FANTASMTableAdapter FANTASMTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}