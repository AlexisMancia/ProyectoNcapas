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
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
        public int IdUsuario, IdRol;
        public string Nombre, Rol;
        public bool Estado;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            menuStrip.Enabled = false;
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibro frm = new FrmLibro();
            frm.rol = this.Rol;
            frm.MdiParent = this;
            frm.Show();
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamo frm = new FrmPrestamo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDevolucion frm = new FrmDevolucion();
            frm.Show();
        }

        private void regisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistro frm = new FrmRegistro();
            frm.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtClave.Clear();
            txtEmail.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IdUsuario = 0;
            this.IdRol = 0;
            this.Rol = "";
            this.Nombre = "";
            this.Estado = false;
            grpboxLogin.Visible = true;
            menuStrip.Enabled = false;
            txtClave.Clear();
            txtEmail.Clear();
            lblLogged.Visible = false;

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text != string.Empty && txtClave.Text != string.Empty)
            {

                try
                {
                    NPersona persona = new NPersona();
                    DataTable Tabla = new DataTable();
                    Tabla = persona.Login(txtEmail.Text.Trim(), txtClave.Text.Trim());
                    if (Tabla.Rows.Count<=0)
                    {
                        MessageBox.Show("Credenciales incorrectas","Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.IdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);
                        this.IdRol = Convert.ToInt32(Tabla.Rows[0][1]);
                        this.Rol = Convert.ToString(Tabla.Rows[0][2]);
                        this.Nombre = Convert.ToString(Tabla.Rows[0][3]);
                        this.Estado = Convert.ToBoolean(Tabla.Rows[0][4]);
                        grpboxLogin.Visible = false;
                        lblLogged.Visible = true;
                        lblLogged.Text = "Logueado como " + Nombre;
                        if (this.Rol.Equals("Administrador"))
                        {
                            menuStrip.Enabled = true;
                        }
                        else
                        {
                            if (this.Rol.Equals("Profesor"))
                            {
                                menuStrip.Enabled = true;
                                mnuItemPrestamo.Enabled = false;
                                mnuItemDevolucion.Enabled = false;
                                mnuItemReporte.Enabled = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Faltan datos", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
