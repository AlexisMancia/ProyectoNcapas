
namespace Proyecto.Presentacion
{
    partial class FrmReporteLibro
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
            this.DataSetLibro = new Proyecto.Presentacion.DataSetLibro();
            this.libro_listarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libro_listarTableAdapter = new Proyecto.Presentacion.DataSetLibroTableAdapters.libro_listarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libro_listarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetLibro";
            reportDataSource1.Value = this.libro_listarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.ReportLibro.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataSetLibro
            // 
            this.DataSetLibro.DataSetName = "DataSetLibro";
            this.DataSetLibro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libro_listarBindingSource
            // 
            this.libro_listarBindingSource.DataMember = "libro_listar";
            this.libro_listarBindingSource.DataSource = this.DataSetLibro;
            // 
            // libro_listarTableAdapter
            // 
            this.libro_listarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteLibro";
            this.Text = "Reporte Libro";
            this.Load += new System.EventHandler(this.FrmReporteLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libro_listarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource libro_listarBindingSource;
        private DataSetLibro DataSetLibro;
        private DataSetLibroTableAdapters.libro_listarTableAdapter libro_listarTableAdapter;
    }
}