
namespace Proyecto.Presentacion
{
    partial class FrmDevolucion
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPersona = new System.Windows.Forms.Button();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscarPersona = new System.Windows.Forms.TextBox();
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.SeleccionarPrestamo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarPersona);
            this.groupBox2.Controls.Add(this.dgvPersona);
            this.groupBox2.Controls.Add(this.txtBuscarPersona);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 284);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de profesor";
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
            this.dgvPersona.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPersona_MouseDoubleClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleccionar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // txtBuscarPersona
            // 
            this.txtBuscarPersona.Location = new System.Drawing.Point(29, 35);
            this.txtBuscarPersona.Name = "txtBuscarPersona";
            this.txtBuscarPersona.Size = new System.Drawing.Size(238, 20);
            this.txtBuscarPersona.TabIndex = 3;
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionarPrestamo});
            this.dgvPrestamo.Location = new System.Drawing.Point(29, 37);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamo.Size = new System.Drawing.Size(434, 171);
            this.dgvPrestamo.TabIndex = 18;
            this.dgvPrestamo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPrestamo_MouseClick);
            // 
            // SeleccionarPrestamo
            // 
            this.SeleccionarPrestamo.HeaderText = "SeleccionarPrestamo";
            this.SeleccionarPrestamo.Name = "SeleccionarPrestamo";
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(509, 12);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(497, 533);
            this.btnDevolver.TabIndex = 19;
            this.btnDevolver.Text = "DEVOLVER";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPrestamo);
            this.groupBox1.Location = new System.Drawing.Point(12, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 214);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prestamos activos del profesor";
            // 
            // FrmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmDevolucion";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.FrmDevolucion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarPersona;
        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox txtBuscarPersona;
        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionarPrestamo;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}