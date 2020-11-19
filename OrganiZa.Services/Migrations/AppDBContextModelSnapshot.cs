﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrganiZa.Services;

namespace OrganiZa.Services.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrganiZa.Models.AdministradorModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CalendarioModelsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EscuelaModelsId")
                        .HasColumnType("int");

                    b.Property<string>("NombreAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rolusuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CalendarioModelsId");

                    b.HasIndex("EscuelaModelsId");

                    b.HasIndex("UsersId");

                    b.ToTable("Administrador");
                });

            modelBuilder.Entity("OrganiZa.Models.CalendarioModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alumno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Colegiatura")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdA")
                        .HasColumnType("int");

                    b.Property<int>("IdE")
                        .HasColumnType("int");

                    b.Property<int>("IdP")
                        .HasColumnType("int");

                    b.Property<int>("IdT")
                        .HasColumnType("int");

                    b.Property<string>("MesPago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModoP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("statusdepago")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Calendario");
                });

            modelBuilder.Entity("OrganiZa.Models.EscuelaModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CalendarioModelsId")
                        .HasColumnType("int");

                    b.Property<double>("Colegiatura")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdA")
                        .HasColumnType("int");

                    b.Property<string>("ModoP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NReferencia")
                        .HasColumnType("int");

                    b.Property<string>("NombreAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PagosModelsId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CalendarioModelsId");

                    b.HasIndex("PagosModelsId");

                    b.ToTable("Escuela");
                });

            modelBuilder.Entity("OrganiZa.Models.PagosModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alumno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CalendarioModelsId")
                        .HasColumnType("int");

                    b.Property<double>("Colegiatura")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fichapago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdE")
                        .HasColumnType("int");

                    b.Property<string>("Mespagado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TutorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("statusdepago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("voucher")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("CalendarioModelsId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("OrganiZa.Models.TutorModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alumno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CalendarioModelsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EscuelaModelsId")
                        .HasColumnType("int");

                    b.Property<string>("FichaPago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdE")
                        .HasColumnType("int");

                    b.Property<string>("NombreE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PagosModelsId")
                        .HasColumnType("int");

                    b.Property<string>("Rolusuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<double>("Telefono")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CalendarioModelsId");

                    b.HasIndex("EscuelaModelsId");

                    b.HasIndex("PagosModelsId");

                    b.HasIndex("UsersId");

                    b.ToTable("Tutor");
                });

            modelBuilder.Entity("OrganiZa.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdA")
                        .HasColumnType("int");

                    b.Property<int>("IdT")
                        .HasColumnType("int");

                    b.Property<string>("Rolusuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OrganiZa.Models.AdministradorModels", b =>
                {
                    b.HasOne("OrganiZa.Models.CalendarioModels", "CalendarioModels")
                        .WithMany("AdministradorModels")
                        .HasForeignKey("CalendarioModelsId");

                    b.HasOne("OrganiZa.Models.EscuelaModels", "EscuelaModels")
                        .WithMany("AdministradorModels")
                        .HasForeignKey("EscuelaModelsId");

                    b.HasOne("OrganiZa.Models.Users", "Users")
                        .WithMany("AdministradorModels")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("OrganiZa.Models.EscuelaModels", b =>
                {
                    b.HasOne("OrganiZa.Models.CalendarioModels", "CalendarioModels")
                        .WithMany("EscuelaModels")
                        .HasForeignKey("CalendarioModelsId");

                    b.HasOne("OrganiZa.Models.PagosModels", "PagosModels")
                        .WithMany("EscuelaModels")
                        .HasForeignKey("PagosModelsId");
                });

            modelBuilder.Entity("OrganiZa.Models.PagosModels", b =>
                {
                    b.HasOne("OrganiZa.Models.CalendarioModels", "CalendarioModels")
                        .WithMany("PagosModels")
                        .HasForeignKey("CalendarioModelsId");
                });

            modelBuilder.Entity("OrganiZa.Models.TutorModels", b =>
                {
                    b.HasOne("OrganiZa.Models.CalendarioModels", "CalendarioModels")
                        .WithMany("TutorModels")
                        .HasForeignKey("CalendarioModelsId");

                    b.HasOne("OrganiZa.Models.EscuelaModels", "EscuelaModels")
                        .WithMany()
                        .HasForeignKey("EscuelaModelsId");

                    b.HasOne("OrganiZa.Models.PagosModels", null)
                        .WithMany("TutorModels")
                        .HasForeignKey("PagosModelsId");

                    b.HasOne("OrganiZa.Models.Users", "Users")
                        .WithMany("TutorModels")
                        .HasForeignKey("UsersId");
                });
#pragma warning restore 612, 618
        }
    }
}
