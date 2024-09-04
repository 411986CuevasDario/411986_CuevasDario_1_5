using Problema1_5.Entities;
using Problema1_5.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1_5.Data
{
    public interface IArticuloRepository 
    {
        List<Articulo> GetAll();
        bool Save(Articulo cliente);
        bool Delete(int cliente);
    }
    public class ArticuloRepository : IArticuloRepository
    {
        public List<Articulo> GetAll()
        {
            var dh = DataHelper.GetInstance().ExecuteSPQuery("obtener_articulos");
            var list = new List<Articulo>();
            foreach (DataRow c in dh.Rows)
            {
                var art = new Articulo();
                art.Id = (int)c["id"];
                art.Nombre = c["nombre"].ToString();
                art.PrecioUnitar = Decimal.Parse(c["precioUnitar"].ToString());
                
                list.Add(art);
            }
            return list;
            
        }
        public bool Save(Articulo art)
        {
            SqlCommand command = new SqlCommand("crear_articulo");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@nombre", art.Nombre));
            command.Parameters.Add(new SqlParameter("@precio", art.PrecioUnitar));


            return  DataHelper.GetInstance().ExecuteSPQuery(command);

        }
        public bool Delete(int id) { 
            return false;
        }
    }
}
