using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Studomat.MODEL
{
    public class Zupanija
    {
        [Key]
        public int ID { get; set; }
        public string NazivZupanija { get; set; }
        public IList<Mjesto> Mjesta { get; set; }
    }
}
