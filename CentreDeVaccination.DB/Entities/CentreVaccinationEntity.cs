﻿using CentreDeVaccination.DB.Entities.Bases;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CentreDeVaccination.DB.Entities
{
    [Table("CentreDeVaccination")]
    public class CentreVaccinationEntity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int EntrepotId { get; set; }
        public virtual EntrepotEntity Entrepot { get; set; }

        public bool IsVisible { get; set; }

        public virtual IEnumerable<HoraireEntity> Horaires { get; set; }

        public virtual IEnumerable<PersonnelEntity> Personnel { get; set; }

        public virtual IEnumerable<RendezVousEntity> RDVs { get; set; }
    }
}
