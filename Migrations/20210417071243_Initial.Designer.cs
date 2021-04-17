﻿// <auto-generated />
using System;
using AtomDev.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AtomDev.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20210417071243_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("AtomDev.Models.Admission.AdmissionPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AdmissionNumber")
                        .HasColumnType("integer");

                    b.Property<int?>("EduProgramId")
                        .HasColumnType("integer");

                    b.Property<bool>("TargetedAdmission")
                        .HasColumnType("boolean");

                    b.Property<int?>("TypeOfAdmissionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Year")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("EduProgramId");

                    b.HasIndex("TypeOfAdmissionId");

                    b.ToTable("AdmissionPlan");
                });

            modelBuilder.Entity("AtomDev.Models.Admission.TypeOfAdmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TypeOfAdmission");
                });

            modelBuilder.Entity("AtomDev.Models.AppEduPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AdmissionPlanId")
                        .HasColumnType("integer");

                    b.Property<int?>("ApplicationFormId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AdmissionPlanId");

                    b.HasIndex("ApplicationFormId");

                    b.ToTable("AppEduPosition");
                });

            modelBuilder.Entity("AtomDev.Models.Applications.Applicant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("text");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Citizenship")
                        .HasColumnType("text");

                    b.Property<string>("Document")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("HomePhone")
                        .HasColumnType("text");

                    b.Property<string>("IssuedBy")
                        .HasColumnType("text");

                    b.Property<string>("IssuedWhen")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("ManSex")
                        .HasColumnType("boolean");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<string>("MobPhone")
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<bool>("Privileged")
                        .HasColumnType("boolean");

                    b.Property<string>("Seria")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Applicant");
                });

            modelBuilder.Entity("AtomDev.Models.Applications.ApplicationForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("AppDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("ApplicantId")
                        .HasColumnType("integer");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("ApplicationForm");
                });

            modelBuilder.Entity("AtomDev.Models.Education.EduBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EduBase");
                });

            modelBuilder.Entity("AtomDev.Models.Education.EduForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EduForm");
                });

            modelBuilder.Entity("AtomDev.Models.Education.EduLvl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EduLvl");
                });

            modelBuilder.Entity("AtomDev.Models.Education.EduProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("BaseId")
                        .HasColumnType("integer");

                    b.Property<int?>("FormId")
                        .HasColumnType("integer");

                    b.Property<int?>("LevelId")
                        .HasColumnType("integer");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<int?>("ProgramTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("QualificationId")
                        .HasColumnType("integer");

                    b.Property<int?>("SpecialityId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BaseId");

                    b.HasIndex("FormId");

                    b.HasIndex("LevelId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("ProgramTypeId");

                    b.HasIndex("QualificationId");

                    b.HasIndex("SpecialityId");

                    b.ToTable("EduProgram");
                });

            modelBuilder.Entity("AtomDev.Models.Education.EduProgramType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EduProgramType");
                });

            modelBuilder.Entity("AtomDev.Models.Education.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("SpecialityId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Qualification");
                });

            modelBuilder.Entity("AtomDev.Models.Education.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("ProgramTypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProgramTypeId");

                    b.ToTable("Speciality");
                });

            modelBuilder.Entity("AtomDev.Models.Organizations.Authorities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Authorities");
                });

            modelBuilder.Entity("AtomDev.Models.Organizations.EduOrg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int?>("AuthoritiiesId")
                        .HasColumnType("integer");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<bool>("License")
                        .HasColumnType("boolean");

                    b.Property<double>("Longiitude")
                        .HasColumnType("double precision");

                    b.Property<int?>("MunitipalUnitId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<bool>("StateAccreditation")
                        .HasColumnType("boolean");

                    b.Property<int?>("TypeAuthoritiesId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AuthoritiiesId");

                    b.HasIndex("MunitipalUnitId");

                    b.HasIndex("TypeAuthoritiesId");

                    b.ToTable("EduOrg");
                });

            modelBuilder.Entity("AtomDev.Models.Organizations.MunicipalUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MunicipalUnit");
                });

            modelBuilder.Entity("AtomDev.Models.Organizations.TypeAuthorities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AuthoritiesId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AuthoritiesId");

                    b.ToTable("TypeAuthorities");
                });

            modelBuilder.Entity("AtomDev.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AppEduPositionsId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AppEduPositionsId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AtomDev.Models.Admission.AdmissionPlan", b =>
                {
                    b.HasOne("AtomDev.Models.Education.EduProgram", "EduProgram")
                        .WithMany()
                        .HasForeignKey("EduProgramId");

                    b.HasOne("AtomDev.Models.Admission.TypeOfAdmission", "TypeOfAdmission")
                        .WithMany()
                        .HasForeignKey("TypeOfAdmissionId");
                });

            modelBuilder.Entity("AtomDev.Models.AppEduPosition", b =>
                {
                    b.HasOne("AtomDev.Models.Admission.AdmissionPlan", "AdmissionPlan")
                        .WithMany()
                        .HasForeignKey("AdmissionPlanId");

                    b.HasOne("AtomDev.Models.Applications.ApplicationForm", "ApplicationForm")
                        .WithMany()
                        .HasForeignKey("ApplicationFormId");
                });

            modelBuilder.Entity("AtomDev.Models.Applications.ApplicationForm", b =>
                {
                    b.HasOne("AtomDev.Models.Applications.Applicant", "Applicant")
                        .WithMany()
                        .HasForeignKey("ApplicantId");

                    b.HasOne("AtomDev.Models.Organizations.EduOrg", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("AtomDev.Models.Education.EduProgram", b =>
                {
                    b.HasOne("AtomDev.Models.Education.EduBase", "Base")
                        .WithMany()
                        .HasForeignKey("BaseId");

                    b.HasOne("AtomDev.Models.Education.EduForm", "Form")
                        .WithMany()
                        .HasForeignKey("FormId");

                    b.HasOne("AtomDev.Models.Education.EduLvl", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId");

                    b.HasOne("AtomDev.Models.Organizations.EduOrg", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId");

                    b.HasOne("AtomDev.Models.Education.EduProgramType", "ProgramType")
                        .WithMany()
                        .HasForeignKey("ProgramTypeId");

                    b.HasOne("AtomDev.Models.Education.Qualification", "Qualification")
                        .WithMany()
                        .HasForeignKey("QualificationId");

                    b.HasOne("AtomDev.Models.Education.Speciality", "Speciality")
                        .WithMany()
                        .HasForeignKey("SpecialityId");
                });

            modelBuilder.Entity("AtomDev.Models.Education.Qualification", b =>
                {
                    b.HasOne("AtomDev.Models.Education.Speciality", "Speciality")
                        .WithMany()
                        .HasForeignKey("SpecialityId");
                });

            modelBuilder.Entity("AtomDev.Models.Education.Speciality", b =>
                {
                    b.HasOne("AtomDev.Models.Education.EduProgramType", "ProgramType")
                        .WithMany()
                        .HasForeignKey("ProgramTypeId");
                });

            modelBuilder.Entity("AtomDev.Models.Organizations.EduOrg", b =>
                {
                    b.HasOne("AtomDev.Models.Organizations.Authorities", "Authoritiies")
                        .WithMany()
                        .HasForeignKey("AuthoritiiesId");

                    b.HasOne("AtomDev.Models.Organizations.MunicipalUnit", "MunitipalUnit")
                        .WithMany()
                        .HasForeignKey("MunitipalUnitId");

                    b.HasOne("AtomDev.Models.Organizations.TypeAuthorities", "TypeAuthorities")
                        .WithMany()
                        .HasForeignKey("TypeAuthoritiesId");
                });

            modelBuilder.Entity("AtomDev.Models.Organizations.TypeAuthorities", b =>
                {
                    b.HasOne("AtomDev.Models.Organizations.Authorities", "Authorities")
                        .WithMany()
                        .HasForeignKey("AuthoritiesId");
                });

            modelBuilder.Entity("AtomDev.Models.Student", b =>
                {
                    b.HasOne("AtomDev.Models.AppEduPosition", "AppEduPositions")
                        .WithMany()
                        .HasForeignKey("AppEduPositionsId");
                });
#pragma warning restore 612, 618
        }
    }
}
