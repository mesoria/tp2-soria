using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class StockNegocio
    {
        public List<Stock> Lista()
        {
            List<Stock> lista = new List<Stock>();
            Stock aux;
            try
            {
                aux = new Stock();
                lista.Add(aux);
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }
    }
}
