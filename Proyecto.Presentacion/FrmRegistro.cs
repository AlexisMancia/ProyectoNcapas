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
    public partial class FrmRegistro : Form
    {
        int cbbIndex;
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void cbbRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbIndex = cbbRegistro.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cbbIndex)
            {
                case 0:
                    FrmReporteLibro frm = new FrmReporteLibro();
                    
                    frm.Show();
                    break;
                case 1:
                    FrmReportePrestamos frm1 = new FrmReportePrestamos();

                    frm1.Show();
                    break;
                default:
                    MessageBox.Show("Seleccione una opcion");
                    break;
            }
        }
    }
}
