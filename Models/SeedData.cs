using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using AtomDev.Models.Applications;
using AtomDev.Models.Education;
using AtomDev.Models.Admission;
using AtomDev.Models.Organizations;
using System.Threading.Tasks;

namespace AtomDev.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StudentDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StudentDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Students.Any())
            {
                context.Students.AddRange(
                    new Student
                    {
                        AppEduPositions = new AppEduPosition()
                        {
                            ApplicationForm = new ApplicationForm()
                            {
                                AppDate = DateTime.Now,
                                Applicant = new Applicant()
                                {
                                    FirstName = "Igor",
                                    LastName = "Petrov",
                                    Birthday = DateTime.Today,
                                    Address = "WwwLeningrad",
                                    Privileged = true
                                },
                                Organization = new EduOrg()
                                {
                                    Name = "Technikum",
                                    Address = "STP.RU",
                                    Phone = "899999999",
                                    Latitude = 2.34225,
                                    Longiitude = 4.34564,
                                    License = false,
                                    MunitipalUnits = new MunicipalUnit()
                                    {
                                        Name = "I'm dying",
                                        Address = "It's 3 AM",
                                    },
                                    Authoritiies = new Authorities()
                                    {
                                        Name = "Department",
                                    },
                                    TypeAuthorities = new TypeAuthorities()
                                    {
                                        Name = "MosProsvet",
                                        Authorities = new Authorities()
                                    }
                                }
                            },
                            AdmissionPlan = new AdmissionPlan()
                            {
                                Year = new DateTime(2015, 0, 0),
                                AdmissionNumber = 1,
                                TargetedAdmission = true,
                                TypeOfAdmission = new TypeOfAdmission()
                                {
                                    Name = "Submission"
                                },
                                EduProgram = new EduProgram()
                                {
                                    ProgramType = new EduProgramType()
                                    {
                                        Name = "Kak obichno, o4en' plochaya"
                                    },
                                    Speciality = new Speciality()
                                    {
                                        ProgramType = new EduProgramType()
                                        {
                                            Name = "It's supposed to be empty"
                                        },
                                        Name = "Slesar"
                                    },
                                    Qualification = new Qualification()
                                    {
                                        Name = "Po derevu",
                                        Speciality = new Speciality()
                                        {
                                            ProgramType = new EduProgramType(),
                                            Code = "8989"
                                        }
                                    },
                                    Form = new EduForm()
                                    {
                                        Name = "Ochnoe"
                                    },
                                    Level = new EduLvl()
                                    {
                                        Name = "99"
                                    },
                                    Base = new EduBase()
                                    {
                                        Name = "Budzhet"
                                    },
                                    Organization = new EduOrg()
                                    {
                                        Name = "Technikum",
                                        Address = "STP.RU",
                                        Phone = "899999999",
                                        Latitude = 2.34225,
                                        Longiitude = 4.34564,
                                        License = false,
                                        MunitipalUnits = new MunicipalUnit()
                                        {
                                            Name = "I'm dying",
                                            Address = "It's 3 AM",
                                        },
                                        Authoritiies = new Authorities()
                                        {
                                            Name = "Department",
                                        },
                                        TypeAuthorities = new TypeAuthorities()
                                        {
                                            Name = "MosProsvet",
                                            Authorities = new Authorities()
                                        }
                                    }
                                }
                            }
                        },
                        Date = DateTime.Now
                    },
                    new Student
                    {
                        AppEduPositions = new AppEduPosition()
                        {
                            ApplicationForm = new ApplicationForm()
                            {
                                AppDate = DateTime.Now,
                                Applicant = new Applicant()
                                {
                                    FirstName = "Vasya",
                                    LastName = "Chilov",
                                    Birthday = DateTime.Today,
                                    Address = "SovietUnion",
                                    Privileged = true
                                },
                                Organization = new EduOrg()
                                {
                                    Name = "Kolledzh",
                                    Address = "STP.RU",
                                    Phone = "899999999",
                                    Latitude = 2.34225,
                                    Longiitude = 4.34564,
                                    License = false,
                                    MunitipalUnits = new MunicipalUnit()
                                    {
                                        Name = "I'm dying",
                                        Address = "It's 3 AM",
                                    },
                                    Authoritiies = new Authorities()
                                    {
                                        Name = "Department",
                                    },
                                    TypeAuthorities = new TypeAuthorities()
                                    {
                                        Name = "MosProsvet",
                                        Authorities = new Authorities()
                                    }
                                }
                            },
                            AdmissionPlan = new AdmissionPlan()
                            {
                                Year = new DateTime(2015, 0, 0),
                                AdmissionNumber = 1,
                                TargetedAdmission = true,
                                TypeOfAdmission = new TypeOfAdmission()
                                {
                                    Name = "Submission"
                                },
                                EduProgram = new EduProgram()
                                {
                                    ProgramType = new EduProgramType()
                                    {
                                        Name = "Doroga v zhizn"
                                    },
                                    Speciality = new Speciality()
                                    {
                                        ProgramType = new EduProgramType()
                                        {
                                            Name = "It's supposed to be empty"
                                        },
                                        Name = "Slesar"
                                    },
                                    Qualification = new Qualification()
                                    {
                                        Name = "Po metallu",
                                        Speciality = new Speciality()
                                        {
                                            ProgramType = new EduProgramType(),
                                            Code = "898"
                                        }
                                    },
                                    Form = new EduForm()
                                    {
                                        Name = "Ochnoe"
                                    },
                                    Level = new EduLvl()
                                    {
                                        Name = "1"
                                    },
                                    Base = new EduBase()
                                    {
                                        Name = "Platka"
                                    },
                                    Organization = new EduOrg()
                                    {
                                        Name = "Kolledg",
                                        Address = "ST.R",
                                        Phone = "98888888888888888",
                                        Latitude = 2.34225,
                                        Longiitude = 4.34564,
                                        License = false,
                                        MunitipalUnits = new MunicipalUnit()
                                        {
                                            Name = "I'm dying [2]",
                                            Address = "It's 3:30 AM",
                                        },
                                        Authoritiies = new Authorities()
                                        {
                                            Name = "Depar",
                                        },
                                        TypeAuthorities = new TypeAuthorities()
                                        {
                                            Name = "Mos",
                                            Authorities = new Authorities()
                                        }
                                    }
                                }
                            }
                        },
                        Date = DateTime.Now
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
