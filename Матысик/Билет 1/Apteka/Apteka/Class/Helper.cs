using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka.Class
{
    public class Helper

    {

        public static Model.MedicEntities DB { get; set; }


        static Helper()

        {

            // Инициализация контекста базы данных

            DB = new Model.MedicEntities();

        }

    }
}
