using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISKlinike
{
    public class Baza
    {
        public static DBContext baza { get; set; } = new DBContext();
    }
}
