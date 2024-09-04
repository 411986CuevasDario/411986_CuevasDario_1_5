using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1_5.Entities
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Decimal PrecioUnitar { get; set; }
        public override string ToString()
        {
            return $"Articulo: Id={Id}, Nombre={Nombre}, PrecioUnitar={PrecioUnitar}";
        }
    }
}
