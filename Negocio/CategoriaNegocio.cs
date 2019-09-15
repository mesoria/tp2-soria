using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<CategoriaArticulo> ListarCategoria()
        {
            List<CategoriaArticulo> lista = new List<CategoriaArticulo>();
            CategoriaArticulo aux;
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.SetearConsulta("Select Id, Nombre from CATEGORIAS");
                accesoDatos.AbrirConexion();
                accesoDatos.EjecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    aux             = new CategoriaArticulo();
                    aux.Id          = (int)accesoDatos.Lector[0];
                    aux.Nombre      = (string)accesoDatos.Lector[1];
                    //aux.Descripcion = (string)accesoDatos.Lector[2];
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
        public List<string> ListarCategoria(int col)
        {
            List<string> lista = new List<string>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.SetearConsulta("Select Id, Nombre from CATEGORIAS");
                accesoDatos.AbrirConexion();
                accesoDatos.EjecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    lista.Add((string)accesoDatos.Lector[col]);
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

        public CategoriaArticulo GetCategoria(int Id)
        {
            CategoriaArticulo aux = new CategoriaArticulo();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.SetearConsulta("Select Id, Nombre from CATEGORIAS where Id = @Id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Id", Id.ToString());
                accesoDatos.AbrirConexion();
                accesoDatos.EjecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    aux.Id = (Int32)accesoDatos.Lector[0];
                    aux.Nombre = (string)accesoDatos.Lector[1];
                }
                return aux;
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
        public void AgregarCategoria(CategoriaArticulo categoria)
        {
            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.SetearConsulta("insert into CATEGORIAS ( Nombre, Descripcion) values (@Nombre, @Descripcion)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", categoria.Nombre.ToString());
                accesoDatos.Comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion.ToString());
                accesoDatos.AbrirConexion();
                accesoDatos.EjecutarAccion();
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

        public void ModificarCAtegoria(CategoriaArticulo categoria)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.SetearConsulta("update CATEGORIAS Set NOMBRE=@Nombre Where ID=" + categoria.Id);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@NOMBRE", categoria.Nombre.ToString());
                accesoDatos.AbrirConexion();
                accesoDatos.EjecutarAccion();

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