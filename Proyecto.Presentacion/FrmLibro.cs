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
    public partial class FrmLibro : Form
    {
        private string TituloAnt;
        public FrmLibro()
        {
            InitializeComponent();
        }
        private void Formato()
        {
            dgvLibro1.Columns[0].Visible = false;
            dgvLibro1.Columns[1].Visible = false;
            dgvLibro.Columns[0].Visible = false;
            dgvLibro.Columns[1].Visible = false;


        }

        private void Listar()
        {
            try
            {
                dgvLibro.DataSource = NLibro.Listar();
                dgvLibro1.DataSource = NLibro.Listar();
                this.Formato();
                lblTotalLibro.Text = "Total Libros : " + Convert.ToString(dgvLibro1.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                dgvLibro1.DataSource = NLibro.Buscar(txtBuscarLibro.Text);
                this.Formato();
                lblTotalLibro.Text = "Total Libros: " + Convert.ToString(dgvLibro1.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtEstado.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtISBM.Clear();
            txtEditorial.Clear();
            txtAnioEdi.Clear();
            txtPais.Clear();
            txtIdioma.Clear();
            txtMateria.Clear();
            txtNumPagina.Clear();
            txtNumEdicion.Clear();
            txtDescipcion.Clear();
            txtUbicacion.Clear();
            btnInsertar.Visible = true;
            btnActualizar.Visible = false;
            errorIcono.Clear();
            
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Libros ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Libros ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void FrmLibro_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtAutor.Text == string.Empty && txtTitulo.Text == string.Empty && txtISBM.Text == string.Empty && txtEditorial.Text == string.Empty && txtAnioEdi.Text == string.Empty && txtNumEdicion.Text == string.Empty && txtPais.Text == string.Empty && txtNumPagina.Text == string.Empty && txtIdioma.Text == string.Empty && txtMateria.Text == string.Empty && txtUbicacion.Text == string.Empty && txtDescipcion.Text == string.Empty)
                {
                    this.MensajeError("Faltan Datos");
                    errorIcono.SetError(txtAutor, "Ingresar Autor");
                    errorIcono.SetError(txtTitulo, "Ingresar Titulo");
                    errorIcono.SetError(txtEditorial, "Ingresar Editorial");
                    errorIcono.SetError(txtISBM, "Ingresar ISBM");
                    errorIcono.SetError(txtAnioEdi, "Ingresar Anio de Edicion");
                    errorIcono.SetError(txtNumPagina, "Ingresar Numero de pagina");
                    errorIcono.SetError(txtNumEdicion, "Ingresar Numero de edicion");
                    errorIcono.SetError(txtPais, "Ingresar Pais");
                    errorIcono.SetError(txtIdioma, "Ingresar Idioma");
                    errorIcono.SetError(txtMateria, "Ingresar Materia");
                    errorIcono.SetError(txtUbicacion, "Ingresar Ubicacion");
                    errorIcono.SetError(txtDescipcion, "Ingresar Descripcion");

                }
                else
                {
                    rpta = NLibro.Insertar(0,txtTitulo.Text.Trim(), txtAutor.Text.Trim(), txtISBM.Text.Trim(), txtEditorial.Text.Trim(), txtAnioEdi.Text.Trim(), txtNumEdicion.Text.Trim(), txtPais.Text.Trim(), txtIdioma.Text.Trim(), txtMateria.Text.Trim(), txtNumPagina.Text.Trim(), txtUbicacion.Text.Trim(), txtDescipcion.Text.Trim());
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            tabGeneral.SelectedIndex = 0;
        }

        private void dgvLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLibro_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgvLibro2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Limpiar();
                btnActualizar.Visible = true;
                btnInsertar.Enabled = false;
                txtId.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["Codigo"].Value);
                txtTitulo.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["Titulo"].Value);
                txtAutor.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["Autor"].Value);
                txtEditorial.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["Editorial"].Value);
                txtISBM.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["ISBM"].Value);
                txtAnioEdi.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["Anio_de_Edicion"].Value);
                txtNumEdicion.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["Numero_de_Edicion"].Value);
                txtNumPagina.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["Numero_Paginas"].Value);
                txtIdioma.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["Idioma"].Value);
                txtPais.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["Pais"].Value);
                txtMateria.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["Materia"].Value);
                txtUbicacion.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["Ubicacion"].Value);
                txtDescipcion.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["Descripcion"].Value);
                txtEstado.Text = Convert.ToString(dgvLibro1.CurrentRow.Cells["Estado"].Value);

                tabGeneral.SelectedIndex = 1;
            }
            catch(Exception)
            {
                MessageBox.Show("Seleccione desde la celda nombre.");
            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtTitulo.Text == string.Empty || txtISBM.Text == string.Empty || txtEditorial.Text == string.Empty || txtAnioEdi.Text == string.Empty || txtNumEdicion.Text == string.Empty || txtPais.Text == string.Empty || txtNumPagina.Text == string.Empty || txtIdioma.Text == string.Empty || txtMateria.Text == string.Empty || txtUbicacion.Text == string.Empty || txtDescipcion.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(txtAutor, "Ingresar Autor");
                    errorIcono.SetError(txtTitulo, "Ingresar Titulo");
                    errorIcono.SetError(txtEditorial, "Ingresar Editorial");
                    errorIcono.SetError(txtISBM, "Ingresar ISBM");
                    errorIcono.SetError(txtAnioEdi, "Ingresar Anio de Edicion");
                    errorIcono.SetError(txtNumPagina, "Ingresar Numero de pagina");
                    errorIcono.SetError(txtNumEdicion, "Ingresar Numero de edicion");
                    errorIcono.SetError(txtPais, "Ingresar Pais");
                    errorIcono.SetError(txtIdioma, "Ingresar Idioma");
                    errorIcono.SetError(txtMateria, "Ingresar Materia");
                    errorIcono.SetError(txtUbicacion, "Ingresar Ubicacion");
                    errorIcono.SetError(txtDescipcion, "Ingresar Descripcion");
                }
                else
                {
                    Console.WriteLine(txtId.Text);
                    Rpta = NLibro.Actualizar(Convert.ToInt32(txtId.Text), txtTitulo.Text.Trim(), txtAutor.Text.Trim(), txtISBM.Text.Trim(), txtEditorial.Text.Trim(), txtAnioEdi.Text.Trim(), txtNumEdicion.Text.Trim(), txtPais.Text.Trim(), txtIdioma.Text.Trim(), txtMateria.Text.Trim(), txtNumPagina.Text.Trim(), txtUbicacion.Text.Trim(), txtDescipcion.Text.Trim(),Convert.ToBoolean(txtEstado.Text));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se logro actualizar el registro");
                        this.Limpiar();
                        Console.WriteLine("AAAAAAAAAAAAAAA");
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvLibro2.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NCategoria.Eliminar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
