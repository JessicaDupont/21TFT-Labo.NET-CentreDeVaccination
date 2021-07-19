﻿using CentreDeVaccination.DAL.Bases;
using CentreDeVaccination.Models.IModels;
using CentreDeVaccination.DB;
using CentreDeVaccination.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentreDeVaccination.DAL.Mapping;
using CentreDeVaccination.DAL.Repositories.Bases;

namespace CentreDeVaccination.DAL.Repositories
{
    public class CentreDeVaccinationRepository : RepositoryBase, ICentreDeVaccinationRepository
    {
        private CentreDeVaccinationMapping map;

        public CentreDeVaccinationRepository(DataContext db) : base(db)
        {
            map = new CentreDeVaccinationMapping();
        }

        public ICentreDeVaccination Read(int id)
        {
            return db.Centres
                .Where(x => x.Id == id)
                .Select(map.Mapping)
                .FirstOrDefault();
        }

        public IEnumerable<ICentreDeVaccination> Read()
        {
            return db.Centres
                .Where(x => x.IsVisible == true)
                .Select(map.Mapping);
        }

    }
}
