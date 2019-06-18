using InsuranceCoLtdService.Context.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace InsuranceCoLtdService.Context
{
   public class InsurancePolicyContext:DbContext
    {
        public InsurancePolicyContext(DbContextOptions option) : base(option)
        {

        }
        public DbSet<RiskFactor> RiskFactors { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<RiskType> RiskTypes { get; set; }
        public DbSet<Models.Validation> Validations { get; set; }
        public DbSet<PolicyRiskTypes> PolicyRiskTypes { get; set; }
        public DbSet<RiskTypeRiskFactor> RiskTypeRiskFactor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<RiskType>()
               .HasKey(x => x.RiskTypeId);
            modelBuilder.Entity<RiskFactor>()
                .HasKey(x => x.RiskFactorId);
            modelBuilder.Entity<RiskTypeRiskFactor>()
                .HasKey(x => new { x.RiskFactorId, x.RiskTypeId });
            modelBuilder.Entity<RiskTypeRiskFactor>()
                .HasOne(x => x.RiskType)
                .WithMany(x => x.RiskTypeRiskFactors)
                .HasForeignKey(x => x.RiskTypeId);
            modelBuilder.Entity<RiskTypeRiskFactor>()
                .HasOne(x => x.RiskFactor)
                .WithMany(x => x.RiskTypeRiskFactors)
                .HasForeignKey(x => x.RiskFactorId);


            modelBuilder.Entity<Policy>()
                .HasKey(x => x.PolicyId);
            modelBuilder.Entity<RiskType>()
                .HasKey(x => x.RiskTypeId);
            modelBuilder.Entity<PolicyRiskTypes>()
                .HasKey(x => new { x.PId, x.RId });
            modelBuilder.Entity<PolicyRiskTypes>()
                .HasOne(x => x.Policy)
                .WithMany(x => x.PolicyRiskTypes)
                .HasForeignKey(x => x.PId);
            modelBuilder.Entity<PolicyRiskTypes>()
                .HasOne(x => x.RiskType)
                .WithMany(x => x.PolicyRiskTypes)
                .HasForeignKey(x => x.RId);


            Models.Validation textBox = new Models.Validation { Id = 1, Name = "TextBox" };
            Models.Validation checkBox = new Models.Validation { Id = 2, Name = "Check Box" };
            Models.Validation radioButton = new Models.Validation { Id = 3, Name = "Radio Button" };

            modelBuilder.Entity<Models.Validation>().HasData(
               new Models.Validation { Id = 1, Name = "TextBox" },
               new Models.Validation { Id = 2, Name = "Check Box" }
                );

            modelBuilder.Entity<RiskFactor>().HasData(
               new RiskFactor { RiskFactorId = 1, RiskFactorName = "Age", ValidationId = 1 },
               new RiskFactor { RiskFactorId = 2, RiskFactorName = "Location", ValidationId = 2 },
               new RiskFactor { RiskFactorId = 3, RiskFactorName = "Height", ValidationId = 2 },
               new RiskFactor { RiskFactorId = 4, RiskFactorName = "Waight", ValidationId = 2 },
               new RiskFactor { RiskFactorId = 5, RiskFactorName = "Gender", ValidationId = 1 },
               new RiskFactor { RiskFactorId = 6, RiskFactorName = "Deppendance", ValidationId = 1 }
                );

            modelBuilder.Entity<RiskType>().HasData(
               new RiskType { RiskTypeId = 1, RiskTypeDescription = "Health" },
               new RiskType { RiskTypeId = 2, RiskTypeDescription = "Vehicle" }
                );


            IList<RiskType> defaultRiskTypes = new List<RiskType>();
            defaultRiskTypes.Add(new RiskType() { RiskTypeId = 1, RiskTypeDescription = "Health" });
            defaultRiskTypes.Add(new RiskType() { RiskTypeId = 2, RiskTypeDescription = "Vehicle" });
            defaultRiskTypes.Add(new RiskType() { RiskTypeId = 3, RiskTypeDescription = "Profesional" });


            modelBuilder.Entity<RiskTypeRiskFactor>().HasData(
              new RiskTypeRiskFactor { RiskTypeId = 1, RiskFactorId = 1 }      
               );

            modelBuilder.Entity<Models.Policy>().HasData(
              new Models.Policy { PolicyId = 1, PolicyName = "Life" },
              new Models.Policy { PolicyId = 2, PolicyName = "Moter Car" }
               );

            IList<Policy> defaultPolicies = new List<Policy>();
            defaultPolicies.Add(new Policy() { PolicyId = 1, PolicyDescription = "Life" });
            defaultPolicies.Add(new Policy() { PolicyId = 2, PolicyDescription = "Moter Car" });
            defaultPolicies.Add(new Policy() { PolicyId = 3, PolicyDescription = "Property" });

            modelBuilder.Entity<PolicyRiskTypes>().HasData(
              new PolicyRiskTypes { PId = 1, RId = 1 }
               );

            base.OnModelCreating(modelBuilder);

        }
    }
}
