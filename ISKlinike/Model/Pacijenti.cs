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
    [Table("Pacijenti")]
    public class Pacijenti
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime => $"{Ime } {Prezime}";
        public string ImeRoditelja { get; set; }
        public string AdresaPrebivalista { get; set; }
        public string DatumRodjenja { get; set; }
        public virtual DateTime DatumPrvogPrijema { get; set; }
        public int BrojKartona { get; set; }
        public string Napomena { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime} ";
            //({KorisničkoIme})
        }
    }
}
