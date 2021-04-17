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
                    Name = "Администрация Томской области",
                };
                MunicipalUnit municipal = new MunicipalUnit()
                {
                    Name = "Г. Томск",
                };
                TypeAuthorities typeAuthorities = new TypeAuthorities()
                {
                    Name = "Исполнительный орган",
                    Authorities = localAuth
                };
                EduOrg technikum = new EduOrg()
                {
                    Name = "Техникум",
                    Address = new Address 
                    {
                        MunicipalUnit = "Томск",
                        Okrug = "Сибирский Федеральный округ",
                        Region = "Томская область"
                    },
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
                    Address = new Address() 
                    {
                        MunicipalUnit = "Томск",
                        Okrug = "Сибирский Федеральный округ",
                        Region = "Томская область"
                    },
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
                    Name = "СПО"
                };
                Speciality programmer = new Speciality()
                {
                    Name = "Программист",
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
                                    FirstName = "Игорь",
                                    LastName = "Петров",
                                    Birthday = DateTime.Today,
                                    Address = new Address() 
                                    {
                                        Region = "Московская область",
                                        Okrug = "Центральный Федеральный округ"
                                    },
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
                                    Speciality = programmer,
                                    Qualification = new Qualification()
                                    {
                                        Name = ".NET",
                                        Speciality = programmer
                                    },
                                    Form = new EduForm()
                                    {
                                        Name = "Очная"
                                    },
                                    Level = new EduLvl()
                                    {
                                        Name = "1"
                                    },
                                    Base = new EduBase()
                                    {
                                        Name = "Бюджетная основа"
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
                                    FirstName = "Аркадий",
                                    LastName = "Победоносцев",
                                    Birthday = DateTime.Today,
                                    Address = new Address 
                                    {
                                        MunicipalUnit = "Томск",
                                        Okrug = "Сибирский Федеральный округ",
                                        Region = "Томская область"
                                    },
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
                                    Speciality = programmer,
                                    Qualification = new Qualification()
                                    {
                                        Name = "JS",
                                        Speciality = programmer
                                    },
                                    Form = new EduForm()
                                    {
                                        Name = "Очно-заочная"
                                    },
                                    Level = new EduLvl()
                                    {
                                        Name = "1"
                                    },
                                    Base = new EduBase()
                                    {
                                        Name = "Платная основа"
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
