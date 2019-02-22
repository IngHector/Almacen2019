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
    }
}
