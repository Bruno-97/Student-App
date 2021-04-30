using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studomat.MODEL
{
    public class AppUser : IdentityUser
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string PunoIme => $"{Prezime} {Ime}";
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumUpisa { get; set; }
        public string JMBAG { get; set; }
        public string OIB { get; set; }
        public string Status { get; set; }
        [ForeignKey(nameof(Mjesto))]
        public int? MjestoId { get; set; }
        public Mjesto Mjesto { get; set; }
        [ForeignKey(nameof(Fakultet))]
        public int? FakultetId { get; set; }
        public Fakultet Fakultet { get; set; }
        public IList<Ocjene> Ocjenes { get; set; }
    }

}
