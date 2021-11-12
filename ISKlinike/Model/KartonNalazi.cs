using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISKlinike
{
    public class KartonNalazi
    {
        public int Id { get; set; }
        public string LicnaAnamneza { get; set; }
        public string PorodicnaAnamneza { get; set; }
        public string RadnaAnamneza { get; set; }
        public DateTime DatumIzmjene { get; set; }
        public virtual Pacijenti Pacijenti { get; set; }

    }
}
