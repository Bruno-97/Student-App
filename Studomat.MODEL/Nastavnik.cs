using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Studomat.MODEL
{
    public class Nastavnik
    {
        [Key]
        public int ID { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string TitulaIspred { get; set; }
        public string TitulaIza { get; set; }
        public string Lozinka { get; set; }

        [ForeignKey(nameof(Mjesto))]
        public int? MjestoId { get; set; }
        public Mjesto Mjesto { get; set; }

        public IList<Kolegij> Kolegiji { get; set; }
    }
}
