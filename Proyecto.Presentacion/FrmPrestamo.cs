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
    public partial class FrmPrestamo : Form
    {
        int cbbCriterio;
        string  IdLibro, IdPersona;
        DateTime fechaPrestamo,fechaDevolucion;
        public FrmPrestamo()
        {
            InitializeComponent();
        }

        private void Formato()
        {
            dgvLibro.Columns[0].Visible = false;
            dgvLibro.Columns[1].Visible = false;
            //dgvLibro.Columns[14].Visible = false;
            dgvPersona.Columns[0].Visible = false;
            dgvPersona.Columns[1].Visible = false;
            dgvPrestamo.Columns[0].Visible = false;
            dgvPrestamo.Columns[1].Visible = false;
            dgvPrestamo.Columns[2].Visible = false;

            dgvPrestamo.Columns[3].Width = 175;

        }

        private void Listar()
        {
            try
            {
                dgvLibro.DataSource = NLibro.ListarDisponible();
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
            IdLibro = "";
            IdPersona = "";
            dgvLibro.Columns[0].Visible = false;
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void BuscarLibro()
        {
            switch (cbbCriterio)
            {
                case 0:
                    try
                    {
                        dgvLibro.DataSource = NLibro.BuscarTitulo(txtBuscarLibro.Text);
                        this.Formato();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    break;
                case 1:
                    try
                    {
                        dgvLibro.DataSource = NLibro.BuscarAutor(txtBuscarLibro.Text);
                        this.Formato();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    break;
                default:
                    try
                    {
                        dgvLibro.DataSource = NLibro.Buscar(txtBuscarLibro.Text);
                        this.Formato();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    break;

            }
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

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            this.BuscarLibro();
        }

        private void dgvPersona_MouseClick(object sender, MouseEventArgs e)
        {
            IdPersona = Convert.ToString(dgvPersona.CurrentRow.Cells["Codigo"].Value);
            Console.WriteLine("Codigo persona" + IdPersona);
        }

        private void btnBuscarPersona_Click(object sender, EventArgs e)
        {
            this.BuscarPersona();
        }

        private void dtpFechaDevolucion_ValueChanged(object sender, EventArgs e)
        {
            fechaDevolucion = dtpFechaDevolucion.Value;
    
        }

        private void cbbBuscarLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbCriterio = cbbBuscarLibro.SelectedIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            fechaPrestamo = DateTime.Now;
      

           try
            {
                string rpta = "";
                if (IdPersona == string.Empty && IdLibro == string.Empty && fechaPrestamo==null && fechaDevolucion==null && fechaPrestamo>fechaDevolucion)
                {
            // erroes
                }
                else
                {
                    MessageBox.Show(Convert.ToString(fechaPrestamo));
                    MessageBox.Show(Convert.ToString(fechaDevolucion));


                    rpta = NPrestamo.Insertar(Convert.ToInt32(IdPersona), Convert.ToInt32(IdLibro), fechaPrestamo, fechaDevolucion);
                    if (rpta.Equals("OK"))
                    {
                        rpta = NLibro.Desactivar(Convert.ToInt32(IdLibro));
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

        private void dgvLibro_MouseClick(object sender, MouseEventArgs e)
        {
            IdLibro = Convert.ToString(dgvLibro.CurrentRow.Cells["Codigo"].Value);
            Console.WriteLine("Codigo libro" + IdLibro);
        }
    }
}
