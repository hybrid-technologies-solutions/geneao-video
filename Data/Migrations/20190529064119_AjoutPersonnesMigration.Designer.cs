﻿// <auto-generated />
using System;
using Geneao.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Geneao.Data.Migrations
{
    [DbContext(typeof(GeneaoDbContext))]
    [Migration("20190529064119_AjoutPersonnesMigration")]
    partial class AjoutPersonnesMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Geneao.Data.Models.Famille", b =>
                {
                    b.Property<string>("Nom")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Famille_Id");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Deleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DeleteDate")
                        .HasDefaultValue(null);

                    b.Property<DateTime>("EditDate")
                        .HasColumnName("EditDate");

                    b.HasKey("Nom");

                    b.ToTable("Famille");
                });

            modelBuilder.Entity("Geneao.Data.Models.Personne", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Personne_Id");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnName("DateNaissance");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Deleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DeleteDate")
                        .HasDefaultValue(null);

                    b.Property<DateTime>("EditDate")
                        .HasColumnName("EditDate");

                    b.Property<string>("LieuNaissance")
                        .HasColumnName("LieuNaissance");

                    b.Property<string>("NomFamille")
                        .IsRequired()
                        .HasColumnName("Famille_Id");

                    b.Property<string>("Prenom")
                        .HasColumnName("Prenom");

                    b.HasKey("Id");

                    b.HasIndex("NomFamille");

                    b.ToTable("Personne");
                });

            modelBuilder.Entity("Geneao.Data.Models.Personne", b =>
                {
                    b.HasOne("Geneao.Data.Models.Famille", "Famille")
                        .WithMany("Personnes")
                        .HasForeignKey("NomFamille")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
