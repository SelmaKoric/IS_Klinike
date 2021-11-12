using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISKlinike
{
    public class Validator
    {
        public const string povratnaPoruka = "Obavezno polje!";
        public const string poruka = "Unos mora biti u metrima!";
        public static bool ValidirajUnos(TextBox txt,ErrorProvider err, string poruka)
        {
            if(string.IsNullOrEmpty(txt.Text))
            {
                err.SetError(txt, poruka);
                return false;
            }
            err.Clear();
            return true;
        }

       
    }
}
