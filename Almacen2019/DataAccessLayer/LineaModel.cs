using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class LineaModel
    {
        public List<lineas> getAll()
        {
            using (DataClassesDataContext context= new DataClassesDataContext())
            {
                List<lineas> listlineas = context.lineas.ToList();
                return listlineas;
            }
        }
        public void add(lineas linea) {
            using (DataClassesDataContext context = new DataClassesDataContext())
            {
                context.lineas.InsertOnSubmit(linea);
                try{
                    context.SubmitChanges();
                }catch (Exception e) { Console.WriteLine(e.ToString()); }
            }
        }

        public lineas getById(lineas linea)
        {

            DataClassesDataContext context = new DataClassesDataContext();
            lineas line = (from p in context.lineas
                                  where p.id == linea.id
                                  select p).First();
            return line;
        }


        public void delete(lineas linea) {
            DataClassesDataContext context = new DataClassesDataContext();
            lineas lineaToDelet = (from l in context.lineas
                                   where l.id.Equals(linea.id)
                                   select l).First();
            context.lineas.DeleteOnSubmit(lineaToDelet);
            try {
                context.SubmitChanges();
            }
            catch (Exception ex){ Console.WriteLine(ex.ToString()); }
        }

        public void update(lineas linea)
        {
            DataClassesDataContext context = new DataClassesDataContext();
            lineas lineaUpdate = (from p in context.lineas
                                        where p.id == linea.id
                                        select p).First();

            lineaUpdate.clave = linea.clave;
            lineaUpdate.nombre = linea.nombre;
            
            try
            {
                context.SubmitChanges();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

    }
}
