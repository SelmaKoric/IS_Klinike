using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISKlinike
{
    [Table("Korisnici")]
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime => $"{Ime }{Prezime}";
        public string KorisničkoIme { get; set; }
        public string Lozinka { get; set; }
        public string BrojKartona { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime} ";
            //({KorisničkoIme})
        }
    }

}
