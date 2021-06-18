using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Negocio;

namespace Proyecto.Presentacion
{
    public partial class FrmDevolucion : Form
    {
        string IdPersona,IdLibro;
        public FrmDevolucion()
        {
            InitializeComponent();
        }

        private void Formato()
        {
            //dgvLibro.Columns[14].Visible = false;
            dgvPersona.Columns[0].Visible = false;

            dgvPrestamo.Columns[0].Visible = false;
            dgvPrestamo.Columns[2].Visible = false;
            dgvPrestamo.Columns[4].Visible = false;

            dgvPrestamo.Columns[2].Width = 175;

        }

        private void Listar()
        {
            try
            {
                dgvPersona.DataSource = NPersona.Listar();
                dgvPrestamo.DataSource = NPrestamo.Listar();
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Limpiar()
        {
           
        }

        private void BuscarPersona()
        {
            try
            {
                dgvPersona.DataSource = NPersona.Buscar(txtBuscarPersona.Text);
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Prestamo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Prestamo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void FrmDevolucion_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnBuscarPersona_Click(object sender, EventArgs e)
        {
            this.BuscarPersona();
        }

        private void dgvPersona_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IdPersona = Convert.ToString(dgvPersona.CurrentRow.Cells["Codigo"].Value);
            dgvPrestamo.DataSource = NPrestamo.ListarPrestamoProfesor(Convert.ToInt32(IdPersona));
            Console.WriteLine("Codigo persona" + IdPersona);
        }

        private void dgvPrestamo_MouseClick(object sender, MouseEventArgs e)
        {
            IdLibro = Convert.ToString(dgvPrestamo.CurrentRow.Cells["CodigoLibro"].Value);
           
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {

            MessageBox.Show(IdPersona);
            MessageBox.Show(IdLibro);

            try
            {
                string rpta = "";
                if (IdPersona == string.Empty && IdLibro == string.Empty)
                {
                    // erroes
                }
                else
                {
                  
                    rpta = NPrestamo.Desactivar(Convert.ToInt32(IdLibro), Convert.ToInt32(IdPersona));
                    if (rpta.Equals("OK"))
                    {
                        rpta = NLibro.Activar(Convert.ToInt32(IdLibro));
                        if (rpta.Equals("OK"))
                        {
                            this.MensajeOK(rpta);
                            this.Limpiar();
                            this.Listar();
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
