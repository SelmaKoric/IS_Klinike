using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISKlinike
{
    public class KartonDatumiPosjeta
    {
        public int Id { get; set; }
        public DateTime DatumPosjete { get; set; }
        public DateTime VrijemePosjete { get; set; }
        public string EvidentiraoZaposleni { get; set; }
        public Pacijenti Pacijenti { get; set; }
    }
}
