﻿
using CentreDeVaccination.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentreDeVaccination.DB.EntitiesConfig
{
    public class VaccinConfig : IEntityTypeConfiguration<VaccinEntity>
    {
        public void Configure(EntityTypeBuilder<VaccinEntity> builder)
        {
            builder.Property(x => x.IsVisible)
                .HasDefaultValue(true);

            builder.HasIndex(v => v.Nom)
                .IsUnique();

            //FK
            //RDVs voir RendezVous
            builder.HasMany(x => x.RDVs)
                .WithOne(x => x.Vaccin)
                .OnDelete(DeleteBehavior.NoAction);
            //Lots voir Lot
            builder.HasMany(x => x.Lots)
               .WithOne(y => y.Vaccin)
               .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
