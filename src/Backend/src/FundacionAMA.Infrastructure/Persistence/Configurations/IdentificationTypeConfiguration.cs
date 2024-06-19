﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using FundacionAMA.Domain.Entities;
using FundacionAMA.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace FundacionAMA.Infrastructure.Persistence.Configurations
{
    public partial class IdentificationTypeConfiguration : IEntityTypeConfiguration<IdentificationType>
    {
        public void Configure(EntityTypeBuilder<IdentificationType> entity)
        {
            entity.HasKey(e => e.Id).HasName("PK_TipoIdentificacion");

            entity.ToTable("IdentificationType");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Code)
            .IsRequired()
            .HasMaxLength(10)
            .IsUnicode(false);
            entity.Property(e => e.Description)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);
            entity.Property(e => e.Status)
            .IsRequired()
            .HasDefaultValueSql("(N'')");
            entity.HasData(new IdentificationType
            {
                Code = "CC",
                Description = "Cédula de ciudadanía",
                Id = 1,
                Status = "A",
                Active=true,
                CreatedAt=DateTime.Now,

            });
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<IdentificationType> entity);
    }
}