using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlTypes;
using System.Text;

namespace Studomat.MODEL
{
    public class Ocjene
    {
        [Key]
        public int ID { get; set; }
        public int Ocjena { get; set; }

        //[Key]
        //public string AppUserId { get; set; }
        //[ForeignKey(nameof(AppUserId))]
        //public AppUser AppUser { get; set; }

        [ForeignKey(nameof(AppUser))]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        [ForeignKey(nameof(Kolegij))]
        public int? KolegijId { get; set; }
        public Kolegij Kolegij { get; set; }
    }
}
