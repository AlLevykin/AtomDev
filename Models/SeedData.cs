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
                TypeOfAdmission admissionType = new TypeOfAdmission()
                {
                    Name = "TestAdmissionType"
                };
                Authorities localAuth = new Authorities()
                {
                    Name = "local Auth",
                };
                MunicipalUnit municipal = new MunicipalUnit()
                {
                    Name = "Tomskaya Oblast",
                    Address = "Tomsk",
                };
                TypeAuthorities typeAuthorities = new TypeAuthorities()
                {
                    Name = "MosProsvet",
                    Authorities = localAuth
                };
                EduOrg technikum = new EduOrg()
                {
                    Name = "Technikum",
                    Address = "Tomsk",
                    Phone = "899999999",
                    Latitude = 2.34225,
                    Longiitude = 4.34564,
                    License = false,
                    MunitipalUnit = municipal,
                    Authoritiies = localAuth,
                    TypeAuthorities = typeAuthorities
                };
                EduOrg college = new EduOrg()
                {
                    Name = "College",
                    Address = "Tomsk",
                    Phone = "899999999",
                    Latitude = 2.3677,
                    Longiitude = 8.34,
                    License = false,
                    MunitipalUnit = municipal,
                    Authoritiies = localAuth,
                    TypeAuthorities = typeAuthorities
                };
                EduProgramType eduProgramType = new EduProgramType()
                {
                    Name = "Usual"
                };
                Speciality slesar = new Speciality()
                {
                    ProgramType = eduProgramType,
                    Code = "8989"
                };
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
                                Organization = technikum
                            },
                            AdmissionPlan = new AdmissionPlan()
                            {
                                Year = new DateTime(2015, 1, 1),
                                AdmissionNumber = 1,
                                TargetedAdmission = true,
                                TypeOfAdmission = admissionType,
                                EduProgram = new EduProgram()
                                {
                                    ProgramType = eduProgramType,
                                    Speciality = slesar,
                                    Qualification = new Qualification()
                                    {
                                        Name = "Po derevu",
                                        Speciality = slesar
                                    },
                                    Form = new EduForm()
                                    {
                                        Name = "Full-time"
                                    },
                                    Level = new EduLvl()
                                    {
                                        Name = "99"
                                    },
                                    Base = new EduBase()
                                    {
                                        Name = "Granted"
                                    },
                                    Organization = technikum
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
                                Organization = college
                            },
                            AdmissionPlan = new AdmissionPlan()
                            {
                                Year = new DateTime(2015, 1, 1),
                                AdmissionNumber = 1,
                                TargetedAdmission = true,
                                TypeOfAdmission = admissionType,
                                EduProgram = new EduProgram()
                                {
                                    ProgramType = eduProgramType,
                                    Speciality = slesar,
                                    Qualification = new Qualification()
                                    {
                                        Name = "Po metallu",
                                        Speciality = slesar
                                    },
                                    Form = new EduForm()
                                    {
                                        Name = "Part-time"
                                    },
                                    Level = new EduLvl()
                                    {
                                        Name = "1"
                                    },
                                    Base = new EduBase()
                                    {
                                        Name = "Payed"
                                    },
                                    Organization = college
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
