﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RCA_Asigurari.Data;

#nullable disable

namespace RCA_Asigurari.Migrations
{
    [DbContext(typeof(RCA_AsigurariContext))]
    partial class RCA_AsigurariContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RCA_Asigurari.Models.AtributOptional", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("AtributulOptional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("AtributOptional");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.AtributOptionalOferta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AtributOptionalID")
                        .HasColumnType("int");

                    b.Property<int>("OfertaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AtributOptionalID");

                    b.HasIndex("OfertaID");

                    b.ToTable("AtributOptionalOferta");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.CategorieVehicul", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoriaVehicul")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CategorieVehicul");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CodPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JudetID")
                        .HasColumnType("int");

                    b.Property<int>("LocalitateID")
                        .HasColumnType("int");

                    b.Property<string>("Numar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeProprietar")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("RadioButtonClient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Strada")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipClientID")
                        .HasColumnType("int");

                    b.Property<int?>("TipSocietateID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("JudetID");

                    b.HasIndex("LocalitateID");

                    b.HasIndex("TipClientID");

                    b.HasIndex("TipSocietateID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.Judet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Judetul")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Judet");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.Localitate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("JudetID")
                        .HasColumnType("int");

                    b.Property<string>("Localitatea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("JudetID");

                    b.ToTable("Localitate");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.Oferta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AnFabricatie")
                        .HasColumnType("int");

                    b.Property<int>("CapacitateCilindrica")
                        .HasColumnType("int");

                    b.Property<int?>("CategorieVehiculID")
                        .HasColumnType("int");

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MasaMaxima")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NrInmatriculare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrLocuri")
                        .HasColumnType("int");

                    b.Property<string>("NumarIdentificare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Pret")
                        .HasColumnType("int");

                    b.Property<int>("Putere")
                        .HasColumnType("int");

                    b.Property<string>("SerieCIV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipCombustibilID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategorieVehiculID");

                    b.HasIndex("ClientID");

                    b.HasIndex("TipCombustibilID");

                    b.ToTable("Oferta");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.OfertaPF", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AnFabricatie")
                        .HasColumnType("int");

                    b.Property<string>("CNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CapacitateCilindrica")
                        .HasColumnType("int");

                    b.Property<int?>("CategorieVehiculID")
                        .HasColumnType("int");

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MasaMaxima")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NrInmatriculare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrLocuri")
                        .HasColumnType("int");

                    b.Property<string>("NumarCI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumarIdentificare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Pret")
                        .HasColumnType("int");

                    b.Property<int>("Putere")
                        .HasColumnType("int");

                    b.Property<string>("SerieCI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerieCIV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipCombustibilID")
                        .HasColumnType("int");

                    b.Property<int>("Varsta")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategorieVehiculID");

                    b.HasIndex("ClientID");

                    b.HasIndex("TipCombustibilID");

                    b.ToTable("OfertaPF");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.OfertaPJ", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ActivitateSocietate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AnFabricatie")
                        .HasColumnType("int");

                    b.Property<string>("CUI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CapacitateCilindrica")
                        .HasColumnType("int");

                    b.Property<int?>("CategorieVehiculID")
                        .HasColumnType("int");

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MasaMaxima")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NrInmatriculare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrLocuri")
                        .HasColumnType("int");

                    b.Property<string>("NumarIdentificare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeFirma")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NumeReprezentantFirma")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PrenumeReprezentantFirma")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("Pret")
                        .HasColumnType("int");

                    b.Property<int>("Putere")
                        .HasColumnType("int");

                    b.Property<string>("SerieCIV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipCombustibilID")
                        .HasColumnType("int");

                    b.Property<int?>("TipSocietateID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategorieVehiculID");

                    b.HasIndex("ClientID");

                    b.HasIndex("TipCombustibilID");

                    b.HasIndex("TipSocietateID");

                    b.ToTable("OfertaPJ");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.PF", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumarCI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeProprietar")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PrenumeProprietar")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SerieCI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Varsta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PF");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.PJ", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ActivitateSocietate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CUI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeFirma")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NumeReprezentantFirma")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PrenumeReprezentantFirma")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("TipSocietateID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TipSocietateID");

                    b.ToTable("PJ");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.TipClient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("TipulClientului")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipClient");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.TipCombustibil", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("TipulCombustibil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipCombustibil");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.TipSocietate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("TipulSocietate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipSocietate");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.AtributOptionalOferta", b =>
                {
                    b.HasOne("RCA_Asigurari.Models.AtributOptional", "AtributOptional")
                        .WithMany("AtributeOptionaleOferta")
                        .HasForeignKey("AtributOptionalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RCA_Asigurari.Models.Oferta", "Oferta")
                        .WithMany("AtributeOptionaleOferta")
                        .HasForeignKey("OfertaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AtributOptional");

                    b.Navigation("Oferta");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.Client", b =>
                {
                    b.HasOne("RCA_Asigurari.Models.Judet", "Judet")
                        .WithMany("Clienti")
                        .HasForeignKey("JudetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RCA_Asigurari.Models.Localitate", "Localitate")
                        .WithMany("Clienti")
                        .HasForeignKey("LocalitateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RCA_Asigurari.Models.TipClient", "TipClient")
                        .WithMany("Clienti")
                        .HasForeignKey("TipClientID");

                    b.HasOne("RCA_Asigurari.Models.TipSocietate", null)
                        .WithMany("Clienti")
                        .HasForeignKey("TipSocietateID");

                    b.Navigation("Judet");

                    b.Navigation("Localitate");

                    b.Navigation("TipClient");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.Localitate", b =>
                {
                    b.HasOne("RCA_Asigurari.Models.Judet", "Judet")
                        .WithMany("Localitati")
                        .HasForeignKey("JudetID");

                    b.Navigation("Judet");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.Oferta", b =>
                {
                    b.HasOne("RCA_Asigurari.Models.CategorieVehicul", "CategorieVehicul")
                        .WithMany("Oferte")
                        .HasForeignKey("CategorieVehiculID");

                    b.HasOne("RCA_Asigurari.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID");

                    b.HasOne("RCA_Asigurari.Models.TipCombustibil", "TipCombustibil")
                        .WithMany("Oferte")
                        .HasForeignKey("TipCombustibilID");

                    b.Navigation("CategorieVehicul");

                    b.Navigation("Client");

                    b.Navigation("TipCombustibil");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.OfertaPF", b =>
                {
                    b.HasOne("RCA_Asigurari.Models.CategorieVehicul", "CategorieVehicul")
                        .WithMany()
                        .HasForeignKey("CategorieVehiculID");

                    b.HasOne("RCA_Asigurari.Models.Client", "Client")
                        .WithMany("OfertePF")
                        .HasForeignKey("ClientID");

                    b.HasOne("RCA_Asigurari.Models.TipCombustibil", "TipCombustibil")
                        .WithMany()
                        .HasForeignKey("TipCombustibilID");

                    b.Navigation("CategorieVehicul");

                    b.Navigation("Client");

                    b.Navigation("TipCombustibil");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.OfertaPJ", b =>
                {
                    b.HasOne("RCA_Asigurari.Models.CategorieVehicul", "CategorieVehicul")
                        .WithMany()
                        .HasForeignKey("CategorieVehiculID");

                    b.HasOne("RCA_Asigurari.Models.Client", "Client")
                        .WithMany("OfertePJ")
                        .HasForeignKey("ClientID");

                    b.HasOne("RCA_Asigurari.Models.TipCombustibil", "TipCombustibil")
                        .WithMany()
                        .HasForeignKey("TipCombustibilID");

                    b.HasOne("RCA_Asigurari.Models.TipSocietate", "TipSocietate")
                        .WithMany()
                        .HasForeignKey("TipSocietateID");

                    b.Navigation("CategorieVehicul");

                    b.Navigation("Client");

                    b.Navigation("TipCombustibil");

                    b.Navigation("TipSocietate");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.PJ", b =>
                {
                    b.HasOne("RCA_Asigurari.Models.TipSocietate", "TipSocietate")
                        .WithMany("PJs")
                        .HasForeignKey("TipSocietateID");

                    b.Navigation("TipSocietate");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.AtributOptional", b =>
                {
                    b.Navigation("AtributeOptionaleOferta");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.CategorieVehicul", b =>
                {
                    b.Navigation("Oferte");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.Client", b =>
                {
                    b.Navigation("OfertePF");

                    b.Navigation("OfertePJ");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.Judet", b =>
                {
                    b.Navigation("Clienti");

                    b.Navigation("Localitati");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.Localitate", b =>
                {
                    b.Navigation("Clienti");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.Oferta", b =>
                {
                    b.Navigation("AtributeOptionaleOferta");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.TipClient", b =>
                {
                    b.Navigation("Clienti");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.TipCombustibil", b =>
                {
                    b.Navigation("Oferte");
                });

            modelBuilder.Entity("RCA_Asigurari.Models.TipSocietate", b =>
                {
                    b.Navigation("Clienti");

                    b.Navigation("PJs");
                });
#pragma warning restore 612, 618
        }
    }
}
