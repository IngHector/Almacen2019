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
                            id = p.id,
                            Clave =p.clave,
                            Nombre = p.nombre,
                            Linea = l.nombre

                        };
            return query;
        }
        public void delete(productos producto)
        {
            DataClassesDataContext context = new DataClassesDataContext();
            productos productoDelete = (from p in context.productos
                                  where p.id == producto.id
                                  select p
                                ).First();

            context.productos.DeleteOnSubmit(productoDelete);
            try
            {
                context.SubmitChanges();

            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            
        }

        public void update(productos producto) {
            DataClassesDataContext context = new DataClassesDataContext();
            productos productoUpdate = (from p in context.productos
                                        where p.id == producto.id
                                        select p).First();
            productoUpdate = producto;
            try
            {
                context.SubmitChanges();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public void add(productos producto) {
            DataClassesDataContext context = new DataClassesDataContext();
            context.productos.InsertOnSubmit(producto);
            try
            {
                context.SubmitChanges();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
}
