﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonContactManager
{
    class Contact
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public DateTime? DateNaissance { get; set; }

        public override string ToString()
        {
            return $"-{Nom} {Prenom}";
        }


    }
}
