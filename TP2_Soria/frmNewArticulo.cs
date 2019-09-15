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
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        public frmNewArticulo()
        {
            InitializeComponent();
        }

        private void FrmNewArticulo_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
            List<Marca> marcas = marcaNegocio.ListarMarca();
            foreach (var item in marcas)
            {
                cboMarca.Items.Add(item);
            }
            List<CategoriaArticulo> categorias = categoriaNegocio.ListarCategoria();
            foreach (var item in categorias)
            {
                cboCategoria.Items.Add(item);
            }
        }
        private void habilitarCarga()
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
    }
}
