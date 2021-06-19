
namespace Proyecto.Presentacion
{
    partial class FrmReportePrestamos
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
            this.DataSetPrestamos = new Proyecto.Presentacion.DataSetPrestamos();
            this.prestamo_listarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamo_listarTableAdapter = new Proyecto.Presentacion.DataSetPrestamosTableAdapters.prestamo_listarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamo_listarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPrestamo";
            reportDataSource1.Value = this.prestamo_listarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.ReportPrestamo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetPrestamos
            // 
            this.DataSetPrestamos.DataSetName = "DataSetPrestamos";
            this.DataSetPrestamos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamo_listarBindingSource
            // 
            this.prestamo_listarBindingSource.DataMember = "prestamo_listar";
            this.prestamo_listarBindingSource.DataSource = this.DataSetPrestamos;
            // 
            // prestamo_listarTableAdapter
            // 
            this.prestamo_listarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportePrestamos";
            this.Text = "Reporte Prestamos";
            this.Load += new System.EventHandler(this.FrmReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamo_listarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource prestamo_listarBindingSource;
        private DataSetPrestamos DataSetPrestamos;
        private DataSetPrestamosTableAdapters.prestamo_listarTableAdapter prestamo_listarTableAdapter;
    }
}