using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeignKeyAttribute = SQLiteNetExtensions.Attributes.ForeignKeyAttribute;

namespace ISKlinike
{
    [Table("KartonLicniPodaci")]
    public class KartonLicniPodaci
    {

        public virtual Pacijenti Pacijenti { get; set; }
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public string Spol { get; set; }
        public string DatumRodjenja { get; set; }
        public string Prebivalište { get; set; }
        public string JMBG { get; set; }
        public string KrvnaGrupa { get; set; }
        public string RhFaktor { get; set; }
        public string Koagulopatije { get; set; }
        public string Alergičan { get; set; }
        public string HroničneBolesti { get; set; }
        public string RadnaOrganizacijaNaziv { get; set; }
        public string RegBrSifraDjelatnosti { get; set; }
        public string MisljenjeKomisije { get; set; }
       

    }
}
