
namespace Proyecto.Presentacion
{
    partial class FrmPrestamo
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
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscarLibro = new System.Windows.Forms.TextBox();
            this.txtBuscarPersona = new System.Windows.Forms.TextBox();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnBuscarPersona = new System.Windows.Forms.Button();
            this.btnIngresarPrestamo = new System.Windows.Forms.Button();
            this.cbbBuscarLibro = new System.Windows.Forms.ComboBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.SeleccionarPrestamo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLibro
            // 
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvLibro.Location = new System.Drawing.Point(18, 83);
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibro.Size = new System.Drawing.Size(940, 133);
            this.dgvLibro.TabIndex = 0;
            this.dgvLibro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvLibro_MouseClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // dgvPersona
            // 
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dgvPersona.Location = new System.Drawing.Point(29, 79);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersona.Size = new System.Drawing.Size(434, 199);
            this.dgvPersona.TabIndex = 1;
            this.dgvPersona.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPersona_MouseClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleccionar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // txtBuscarLibro
            // 
            this.txtBuscarLibro.Location = new System.Drawing.Point(6, 37);
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.Size = new System.Drawing.Size(238, 20);
            this.txtBuscarLibro.TabIndex = 2;
            // 
            // txtBuscarPersona
            // 
            this.txtBuscarPersona.Location = new System.Drawing.Point(29, 35);
            this.txtBuscarPersona.Name = "txtBuscarPersona";
            this.txtBuscarPersona.Size = new System.Drawing.Size(238, 20);
            this.txtBuscarPersona.TabIndex = 3;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(348, 35);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(92, 23);
            this.btnBuscarLibro.TabIndex = 4;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // btnBuscarPersona
            // 
            this.btnBuscarPersona.Location = new System.Drawing.Point(273, 33);
            this.btnBuscarPersona.Name = "btnBuscarPersona";
            this.btnBuscarPersona.Size = new System.Drawing.Size(190, 23);
            this.btnBuscarPersona.TabIndex = 5;
            this.btnBuscarPersona.Text = "Buscar";
            this.btnBuscarPersona.UseVisualStyleBackColor = true;
            this.btnBuscarPersona.Click += new System.EventHandler(this.btnBuscarPersona_Click);
            // 
            // btnIngresarPrestamo
            // 
            this.btnIngresarPrestamo.Location = new System.Drawing.Point(284, 35);
            this.btnIngresarPrestamo.Name = "btnIngresarPrestamo";
            this.btnIngresarPrestamo.Size = new System.Drawing.Size(190, 21);
            this.btnIngresarPrestamo.TabIndex = 6;
            this.btnIngresarPrestamo.Text = "REGISTRAR";
            this.btnIngresarPrestamo.UseVisualStyleBackColor = true;
            this.btnIngresarPrestamo.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbbBuscarLibro
            // 
            this.cbbBuscarLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuscarLibro.FormattingEnabled = true;
            this.cbbBuscarLibro.Items.AddRange(new object[] {
            "Titulo",
            "Autor"});
            this.cbbBuscarLibro.Location = new System.Drawing.Point(250, 37);
            this.cbbBuscarLibro.Name = "cbbBuscarLibro";
            this.cbbBuscarLibro.Size = new System.Drawing.Size(92, 21);
            this.cbbBuscarLibro.TabIndex = 7;
            this.cbbBuscarLibro.SelectedIndexChanged += new System.EventHandler(this.cbbBuscarLibro_SelectedIndexChanged);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(18, 47);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(177, 20);
            this.dtpFechaDevolucion.TabIndex = 11;
            this.dtpFechaDevolucion.ValueChanged += new System.EventHandler(this.dtpFechaDevolucion_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha limite de devolucion:";
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionarPrestamo});
            this.dgvPrestamo.Location = new System.Drawing.Point(18, 80);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.Size = new System.Drawing.Size(456, 198);
            this.dgvPrestamo.TabIndex = 13;
            // 
            // SeleccionarPrestamo
            // 
            this.SeleccionarPrestamo.HeaderText = "SeleccionarPrestamo";
            this.SeleccionarPrestamo.Name = "SeleccionarPrestamo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvLibro);
            this.groupBox1.Controls.Add(this.txtBuscarLibro);
            this.groupBox1.Controls.Add(this.btnBuscarLibro);
            this.groupBox1.Controls.Add(this.cbbBuscarLibro);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 234);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de libro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarPersona);
            this.groupBox2.Controls.Add(this.dgvPersona);
            this.groupBox2.Controls.Add(this.txtBuscarPersona);
            this.groupBox2.Location = new System.Drawing.Point(-1, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 284);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de profesor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpFechaDevolucion);
            this.groupBox3.Controls.Add(this.dgvPrestamo);
            this.groupBox3.Controls.Add(this.btnIngresarPrestamo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(496, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 284);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registrar Prestamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Criterio";
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 557);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrestamo";
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibro;
        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.TextBox txtBuscarLibro;
        private System.Windows.Forms.TextBox txtBuscarPersona;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.Button btnBuscarPersona;
        private System.Windows.Forms.Button btnIngresarPrestamo;
        private System.Windows.Forms.ComboBox cbbBuscarLibro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionarPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}