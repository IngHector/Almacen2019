using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class ProductoModel
    {
        //Return all products
        public List<productos> getAll()
        {
            using (DataClassesDataContext context = new DataClassesDataContext())
            {
                return context.productos.ToList();
            }
        }
        public IQueryable getAllProductos()
        {
            DataClassesDataContext context = new DataClassesDataContext();
            var query = from p in context.productos
                        join l in context.lineas
                        on p.id_lineas equals l.id
                        //where p.clave.Equals("1")
                        select new
                        {
                            Clave =p.clave,
                            Nombre = p.nombre,
                            Linea = l.nombre

                        };
            return query;
        }
    }
}
