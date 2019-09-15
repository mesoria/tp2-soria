using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace TP2_Soria
{
    public partial class frmMain : Form
    {
        private MarcaNegocio marcaNegocio         = new MarcaNegocio();
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        private List<Articulo> listaArticuloLocal;
        public frmMain()
        {
            InitializeComponent();
        }
 
        private void FrmMain_Load(object sender, EventArgs e)
        {
            CargarDatos();
            btnFind.Enabled = false;
        }
        private void habilitarBuscar()
        {
            if (cboxTxt.Checked)
            {
                if (cboColumna.SelectedItem == null || txtFind.Text.Trim() == "")
                {
                    btnFind.Enabled = false;
                }
                else
                {
                    btnFind.Enabled = true;
                }
            }
            else
            {
                if (cboxObj.Checked)
                {
                    if (cboObj.SelectedItem == null || cboObj2.SelectedItem == null)
                    {
                        btnFind.Enabled = false;
                    }
                    else
                    {
                        btnFind.Enabled = true;
                    }
                }
            }
        }
        private void CargarDatos()
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticuloLocal = negocio.ListarArticulos();
                dgvArticulos.DataSource = listaArticuloLocal;
                dgvArticulos.Columns[0].Visible = false;
                dgvArticulos.Columns[4].Visible = false;
                // MessageBox.Show(lista[0].Tipo.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*
        private void CboxTxt_CheckedChanged(object sender, EventArgs e)
        {
            btnFind.BackColor = Color.Green;
        }

        private void CboxObj_CheckedChanged(object sender, EventArgs e)
        {
            btnFind.BackColor = Color.Green;
        }
        */
        private void CboObj2_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBuscar();
            cboObj2.BackColor = Color.White;
            //btnFind.BackColor = Color.Green;
        }
        private void CheckCheckBoxTxt()
        {
            cboxTxt.Checked = true;
            //btnFind.BackColor = Color.Green;
        }
        private void CheckCheckBoxObj()
        {
            cboxObj.Checked = true;
            //btnFind.BackColor = Color.Green;
        }

        private void CboColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCheckBoxTxt();
            habilitarBuscar();
            //cboColumna.BackColor = Color.White;
        }

        private void TxtFind_TextChanged(object sender, EventArgs e)
        {
            CheckCheckBoxTxt();
            habilitarBuscar();
            //txtFind.BackColor = Color.White;
        }

        private void CboObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCheckBoxObj();
            habilitarBuscar();
            cboObj.BackColor = Color.White;
            List<string> aux;
            if (cboObj.SelectedItem.ToString() == "Marca")
            {
                aux = marcaNegocio.ListarMarca(1);
            }
            else
            {
                aux = categoriaNegocio.ListarCategoria(1);
            }
            cboObj2.Items.Clear();
            foreach (var item in aux)
            {
                cboObj2.Items.Add(item);
            }
            cboObj2.SelectedIndex = 0;
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            if (cboxTxt.Checked)
            {
                if (txtFind.Text == "")
                {
                    txtFind.BackColor = Color.Red;
                }
                else if (cboColumna.Text == "")
                {
                    cboColumna.BackColor = Color.Red;
                }
                else
                {
                    if (cboColumna.Text == "Código")
                    {
                        lista = listaArticuloLocal.FindAll(X => X.Codigo.Contains(txtFind.Text));
                    }
                    else if (cboColumna.Text == "Nombre")
                    {
                        lista = listaArticuloLocal.FindAll(X => X.Nombre.Contains(txtFind.Text));
                    }
                    else if (cboColumna.Text == "Descripción")
                    {
                        lista = listaArticuloLocal.FindAll(X => X.Descripcion.Contains(txtFind.Text));
                    }
                    dgvArticulos.DataSource = lista;
                }
            }
            else
            {
                if (cboObj.SelectedItem.ToString() == "Marca")
                {
                    lista = listaArticuloLocal.FindAll(X => X.Marca.ToString().Contains(cboObj2.SelectedItem.ToString()));
                }
                else
                {
                    lista = listaArticuloLocal.FindAll(X => X.Categoria.ToString().Contains(cboObj2.SelectedItem.ToString()));
                }
                dgvArticulos.DataSource = lista;
            }
        }

        private void BtnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnArticulo_Click(object sender, EventArgs e)
        {
                frmNewArticulo alta = new frmNewArticulo();
                alta.ShowDialog();
                CargarDatos();
        }
    }
}
