using System;
using System.Collections.Generic;
using System.Text;

namespace Twitter2.Models
{
    public class Tweet
    {

        public string Identifiant { get; set; }

        public DateTime DateCreation { get; set; }

        public string Texte { get; set; }

        public string nomUtilisateur { get; set; }

        public string IdUtilisateur { get; set; }

        public string PseudoUtilisateur { get; set; }

        public User User { get; set; }
    }
}
