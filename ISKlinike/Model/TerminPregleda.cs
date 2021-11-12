using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeignKeyAttribute = SQLiteNetExtensions.Attributes.ForeignKeyAttribute;


namespace ISKlinike.Model
{
    [Table ("TerminPregleda")]
    public class TerminPregleda
    {
        public int Id { get; set; }
        public DateTime DatumVrijemePregleda { get; set; }
        public Korisnik Doktor { get; set; } 
        public string RazlogPosjete { get; set; }
        public Pacijenti Pacijent { get; set; }

    }
}
