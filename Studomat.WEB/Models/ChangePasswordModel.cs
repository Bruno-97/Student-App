using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Studomat.WEB.Models
{
    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Trenutna lozinka")]
        public string TrenutnaLozinka { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Nova lozinka")]
        public string NovaLozinka { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potvrdi novu lozinku")]
        [Compare("NovaLozinka", ErrorMessage = "Nova lozinka i potvrdna lozinka ne odgovaraju!")]
        public string PotvrdnaLozinka { get; set; }
    }
}
