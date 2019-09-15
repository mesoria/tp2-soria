using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;
using Negocio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> ListarArticulos()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio         marcaNegocio = new MarcaNegocio();
            AccesoDatosManager    accesoDatos = new AccesoDatosManager();
            List<Articulo>              lista = new List<Articulo>();
            Articulo aux;
            try
            {
                accesoDatos.SetearConsulta("Select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Imagen, Precio from ARTICULOS");
                accesoDatos.AbrirConexion();
                accesoDatos.EjecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    aux             = new Articulo();
                    aux.Id          = (Int32)accesoDatos.Lector[0];
                    aux.Codigo      = (string)accesoDatos.Lector[1];
                    aux.Nombre      = (string)accesoDatos.Lector[2];
                    aux.Descripcion = (string)accesoDatos.Lector[3];
                    aux.Marca       = new Marca();
                    aux.Marca       = marcaNegocio.GetMarca((Int32)accesoDatos.Lector[4]);
                    aux.Categoria   = new CategoriaArticulo();
                    aux.Categoria   = categoriaNegocio.GetCategoria((Int32)accesoDatos.Lector[5]);
                    aux.Imagen      = (string)accesoDatos.Lector[6];
                    aux.Id          = (Int32)accesoDatos.Lector[5];
           
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }
           
        }
    }
}
