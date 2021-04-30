using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Studomat.MODEL
{
    public class Mjesto
    {
        [Key]
        public int ID { get; set; }

        public string NazivMjesta { get; set; }

        [ForeignKey(nameof(Zupanija))]
        public int? ZupanijaId { get; set; }
        public Zupanija Zupanija { get; set; }

        public IList<AppUser> AppUsers { get; set; }
        public IList<Nastavnik> Nastavnici { get; set; }
        public IList<Fakultet> Fakulteti { get; set; }
    }
}