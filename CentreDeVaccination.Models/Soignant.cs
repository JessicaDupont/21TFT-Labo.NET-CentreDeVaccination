﻿using CentreDeVaccination.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentreDeVaccination.Models
{
    public class Soignant : ISoignant
    {
        public bool ResponsableCentre { get; set; }
        public string Inami { get; set; }
        public Grades Grade { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool VerifInami()
        {
            throw new NotImplementedException();
        }
    }
}
