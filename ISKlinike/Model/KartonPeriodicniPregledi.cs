using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISKlinike
{
    public class KartonPeriodicniPregledi
    {
        public int Id { get; set; }
        public DateTime DatumPregleda { get; set; }
        public float Visina { get; set; }
        public float Težina { get; set; }
        public string ObimGrudi { get; set; }
        public string ObimStruka { get; set; }
        public float BMI { get; set; }
        public string KrvniPritisak { get; set; }
        public int Puls { get; set; }
        public string PromjeneNaKozi { get; set; }
        public string Ekstremiteti { get; set; }
        public string Cula { get; set; }
        public string Tonzile { get; set; }
        public string Vrat { get; set; }
        public string GrudniKos { get; set; }
        public string Pluca { get; set; }
        public string Abdomen { get; set; }
        public string UroGenOrgani { get; set; }
        public string KicmeniStub { get; set; }
        public virtual Pacijenti Pacijenti { get; set; }

    }
}
