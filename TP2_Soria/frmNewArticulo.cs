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
    public partial class frmNewArticulo : Form
    {
        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        private Articulo Articulo = null;
        public frmNewArticulo()
        {
            InitializeComponent();
        }
        public frmNewArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.Articulo = articulo;
        }

        private void FrmNewArticulo_Load(object sender, EventArgs e)
        {
            //ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            //MarcaNegocio marcaNegocio = new MarcaNegocio();
            //CategoriaNegocio categoria = new CategoriaNegocio();

            btnAceptar.Enabled = false;
            try
            {
                List<Marca> marcas = marcaNegocio.ListarMarca();
                List<CategoriaArticulo> categorias = categoriaNegocio.ListarCategoria();
                foreach (var item in marcas)
                {
                    cboMarca.Items.Add(item);
                }
                foreach (var item in categorias)
                {
                    cboCategoria.Items.Add(item);
                }
                if (Articulo != null)
                {
                    Text = "Modificar";
                    txtCodigo.Text = Articulo.Codigo;
                    txtNombre.Text = Articulo.Nombre;
                    txtDescripcion.Text = Articulo.Descripcion;
                    cboMarca.SelectedValue = Articulo.Marca.Id;
                    cboCategoria.SelectedValue = Articulo.Categoria.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void HabilitarCarga()
        {
            if (txtNombre.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || txtCodigo.Text.Trim() == "" || cboMarca.SelectedItem == null || cboCategoria.SelectedItem == null)
            {
                btnAceptar.Enabled = false;
            }
            else
            {
                btnAceptar.Enabled = true;
            }
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            HabilitarCarga();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            HabilitarCarga();
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            HabilitarCarga();
        }

        private void CboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarCarga();
        }

        private void CboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarCarga();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Articulo == null)
                {
                    Articulo = new Articulo();
                }
                Articulo.Codigo = txtCodigo.Text;
                Articulo.Nombre = txtNombre.Text;
                Articulo.Descripcion = txtDescripcion.Text;
                Articulo.Marca = (Marca)cboMarca.SelectedItem;
                Articulo.Categoria = (CategoriaArticulo)cboCategoria.SelectedItem;

                if (Articulo.Id != 0)
                {
                    articuloNegocio.Modificar(Articulo);
                }
                else
                {
                    articuloNegocio.Agregar(Articulo);
                }
                Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
