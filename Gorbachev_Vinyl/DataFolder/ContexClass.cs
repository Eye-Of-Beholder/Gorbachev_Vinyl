using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorbachev_Vinyl.DataFolder
{
    public partial class DBEntities : DbContext
    {
      private static DBEntities  contex;         //Обращение к БД//
        public static DBEntities getContex()
        {
            if (contex == null)
            {
                contex = new DBEntities();
            } 
            return contex;
        }
    }
}
