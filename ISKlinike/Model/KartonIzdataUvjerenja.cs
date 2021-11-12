using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISKlinike
{
    public class KartonIzdataUvjerenja
    {
        public int Id { get; set; }
        public DateTime DatumIzmjene { get; set; }
        public string RadnaSposobnost { get; set; }
        public string Invaliditet { get; set; }
        public Pacijenti Pacijent { get; set; }
    }
}
