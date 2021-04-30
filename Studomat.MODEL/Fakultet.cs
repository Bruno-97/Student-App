using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Studomat.MODEL
{
    public class Fakultet
    {
        [Key]
        public int ID { get; set; }

        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string GodinaOsnutka { get; set; }
        public string Email { get; set; }

        [ForeignKey(nameof(Mjesto))]
        public int? MjestoId { get; set; }
        public Mjesto Mjesto { get; set; }

        public IList<Kolegij> Kolegiji { get; set; }
        public IList<AppUser> AppUsers { get; set; }
    }
}
