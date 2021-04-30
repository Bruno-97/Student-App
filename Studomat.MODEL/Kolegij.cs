using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Studomat.MODEL
{
    public class Kolegij
    {
        [Key]
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        [ForeignKey(nameof(Fakultet))]
        public int? FakultetId { get; set; }
        public Fakultet Fakultet { get; set; }

        [ForeignKey(nameof(Nastavnik))]
        public int? NastavnikId { get; set; }
        public Nastavnik Nastavnik { get; set; }

        public IList<Ocjene> Ocjenes { get; set; }
    }
}
