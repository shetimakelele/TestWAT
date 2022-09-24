using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWAT.Models
{
    public class Personne
    {
        [Key]
        public int PersonneId { get; set; }

        [Required]
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateDeNaissance { get; set; }


    }
}
