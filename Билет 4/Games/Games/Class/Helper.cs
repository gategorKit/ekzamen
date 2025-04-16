using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Class
{
    public class Helper
    {
        public static Model.gamesEntities DB { get; set; }
        static Helper()

        {

            // Инициализация контекста базы данных

            DB = new Model.gamesEntities();

        }
    }
}
