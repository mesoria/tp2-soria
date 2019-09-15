using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class MarcaNegocio
    {
        public Marca GetMarca(int Id)
        {
            Marca aux = new Marca();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.SetearConsulta("Select Id, Nombre, Slogan from MARCAS where Id = @Id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Id", Id.ToString());
                accesoDatos.AbrirConexion();
                accesoDatos.EjecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    
                    aux.Id = (Int32)accesoDatos.Lector[0];
                    aux.Nombre = (string)accesoDatos.Lector[1];
                    aux.Descripcion = (string)accesoDatos.Lector[2];
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
        public List<Marca> ListarMarca()
        {
            List<Marca> lista = new List<Marca>();
            Marca aux;
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.SetearConsulta("Select Id, Nombre, Slogan from MARCAS");
                accesoDatos.AbrirConexion();
                accesoDatos.EjecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    aux = new Marca
                    {
                        Id          = (Int32)accesoDatos.Lector[0],
                        Nombre      = (string)accesoDatos.Lector[1],
                        Descripcion = (string)accesoDatos.Lector[2],

                    };
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
        public List<string> ListarMarca(int col)
        {
            List<string> lista = new List<string>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.SetearConsulta("Select Id, Nombre, Slogan from MARCAS");
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
        public void AgregarMarca(Marca marca)
        {
            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.SetearConsulta("insert into MARCAS ( NOMBRE, LOGO) values (@NOMBRE,@LOGO)");
                //(" + marca.Nombre.ToString() +"," + marca.Logo.ToString() + "')");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@NOMBRE", marca.Nombre.ToString());
                accesoDatos.Comando.Parameters.AddWithValue("@LOGO", marca.Logo.ToString());
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

        public void ModificarMarca(Marca marca)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.SetearConsulta("update MARCAS Set NOMBRE=@NOMBRE, LOGO=@LOGO, Where ID=" + marca.Id);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@NOMBRE", marca.Nombre.ToString());
                accesoDatos.Comando.Parameters.AddWithValue("@LOGO", marca.Logo.ToString());
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