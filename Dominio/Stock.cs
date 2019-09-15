using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Stock
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public int Minimo { get; set; }
        public int Maximo { get; set; }
        public int Actual { get; set; }
    }
}
