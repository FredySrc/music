using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace music.Models
{
    public class Band
    {
        [Key]
        public int BandId { get; set; }

        [Display(Name ="Nombre")]
        public String BandName { get; set; }

        [Display(Name ="Numero de Integrantes")]
        public int BandNumberMembers { get; set; }

        [Display(Name ="Genero")]
        public String BandGenre { get; set; }
    }
}
