using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Presentacion
{
    public partial class FrmReporteLibro : Form
    {
        public FrmReporteLibro()
        {
            InitializeComponent();
        }

        private void FrmReporteLibro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetLibro.libro_listar' table. You can move, or remove it, as needed.
            this.libro_listarTableAdapter.Fill(this.DataSetLibro.libro_listar);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
