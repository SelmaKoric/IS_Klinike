using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISKlinike
{
    public class KartonPreventivneMjere
    {
        public int Id { get; set; }
        public string PreventivniPregled { get; set; }
        public Pacijenti Pacijent { get; set; }
        public DateTime DatumPregleda { get; set; }
    }
}
