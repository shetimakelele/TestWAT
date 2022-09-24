using System;
using System.Collections.Generic;
using System.Text;

namespace TestWAT.Core.Data.Models
{
    public class Personne
    {
        public int PersonnrId { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateDeNaissance { get; set; }

        
    }
}
