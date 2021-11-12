using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISKlinike
{
    public class KartonOboljenja
    {
        public int Id { get; set; }
        public string Dijagnoza { get; set; }
        public string ŠifraPoMKB { get; set; }
        public DateTime DatumTerapije { get; set; }
        public string VrstaTerapije { get; set; }
        public string VrijemeTerapije { get; set; }
        public string Uputnica { get; set; }
        public DateTime NesposobnostZaRadOd { get; set; }
        public DateTime NesposobnostZaRadDo { get; set; }
        public DateTime DatumPosjetePrve { get; set; }
        public DateTime DatumPosjetePonovne { get; set; }
        
        public virtual Pacijenti Pacijenti { get; set; }

    }
}
