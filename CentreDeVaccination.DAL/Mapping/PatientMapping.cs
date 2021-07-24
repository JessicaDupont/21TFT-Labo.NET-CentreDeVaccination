﻿using CentreDeVaccination.DAL.Mapping.Bases;
using CentreDeVaccination.DB.Entities;
using CentreDeVaccination.Models;
using CentreDeVaccination.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentreDeVaccination.DAL.Mapping
{
    public class PatientMapping : IMapping<PatientEntity, IPatient>
    {
        private readonly AdresseMapping adresseMap;
        private readonly PersonneMapping personneMap;

        public PatientMapping()
        {
            adresseMap = new AdresseMapping();
            personneMap = new PersonneMapping();
        }
        public PatientEntity Mapping(IPatient model)
        {
            throw new NotImplementedException();
        }

        public IPatient Mapping(PatientEntity entity)
        {
            IPatient result = new Patient();
            result.Id = entity.Id;
            result.InfosMed = entity.InformationMedicales;
            result.NumRegNat = entity.NumRegNat;
            result.NumTel = entity.NumTelephone;
            //adresse
            if (entity.Adresse is null)
            {
                result.Adresse = new Adresse();
                result.Adresse.Id = entity.AdresseId;
            }
            else
            {
                result.Adresse = adresseMap.Mapping(entity.Adresse);
            }
            //personne
            if (entity.Utilisateur is null)
            {
                result.Personne = new Personne();
                result.Personne.Id = entity.UtilisateurId;
            }
            else
            {
                result.Personne = personneMap.Mapping(entity.Utilisateur);
            }

            return result;
        }
    }
}