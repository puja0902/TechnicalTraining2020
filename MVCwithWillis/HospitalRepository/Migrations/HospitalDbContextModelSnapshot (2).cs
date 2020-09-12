﻿// <auto-generated />
using System;
using HospitalRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalRepository.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    partial class HospitalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PatientLibrary.Patient", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tblPatient");
                });

            modelBuilder.Entity("PatientLibrary.PatientProblem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Patientid")
                        .HasColumnType("int");

                    b.Property<string>("problem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Patientid");

                    b.ToTable("tblProblems");
                });

            modelBuilder.Entity("PatientLibrary.Treatment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PatientProblemid")
                        .HasColumnType("int");

                    b.Property<string>("medicineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numberOfTimesInDay")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("PatientProblemid");

                    b.ToTable("tblTreatMents");
                });

            modelBuilder.Entity("PatientLibrary.PatientProblem", b =>
                {
                    b.HasOne("PatientLibrary.Patient", null)
                        .WithMany("problems")
                        .HasForeignKey("Patientid");
                });

            modelBuilder.Entity("PatientLibrary.Treatment", b =>
                {
                    b.HasOne("PatientLibrary.PatientProblem", null)
                        .WithMany("treatments")
                        .HasForeignKey("PatientProblemid");
                });
#pragma warning restore 612, 618
        }
    }
}
