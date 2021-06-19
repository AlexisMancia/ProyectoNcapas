
namespace Proyecto.Presentacion
{
    partial class FrmRegistro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbRegistro = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbbRegistro);
            this.groupBox1.Location = new System.Drawing.Point(61, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar reporte";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbRegistro
            // 
            this.cbbRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRegistro.FormattingEnabled = true;
            this.cbbRegistro.Items.AddRange(new object[] {
            "Libros Registrados",
            "Prestamos activos de libros"});
            this.cbbRegistro.Location = new System.Drawing.Point(6, 36);
            this.cbbRegistro.Name = "cbbRegistro";
            this.cbbRegistro.Size = new System.Drawing.Size(188, 21);
            this.cbbRegistro.TabIndex = 0;
            this.cbbRegistro.SelectedIndexChanged += new System.EventHandler(this.cbbRegistro_SelectedIndexChanged);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 222);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistro";
            this.Text = "Reporte";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbRegistro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}