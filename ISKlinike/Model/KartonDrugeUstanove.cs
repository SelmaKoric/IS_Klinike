using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISKlinike
{
    public class KartonDrugeUstanove
    {
        public int Id { get; set; }
        public string NazivUstanove { get; set; }
        public DateTime LijecenOd { get; set; }
        public DateTime LijecenDo { get; set; }
        public string OtpusnaDijagnoza { get; set; }
        public string Uputstvo { get; set; }
        public virtual Pacijenti Pacijenti { get; set; }
    }
}
