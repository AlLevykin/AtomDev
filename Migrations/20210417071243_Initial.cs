using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AtomDev.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    BirthPlace = table.Column<string>(nullable: true),
                    Citizenship = table.Column<string>(nullable: true),
                    Document = table.Column<string>(nullable: true),
                    Seria = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    IssuedBy = table.Column<string>(nullable: true),
                    IssuedWhen = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    MobPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ManSex = table.Column<bool>(nullable: false),
                    Privileged = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authorities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EduBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduBase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EduForm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduForm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EduLvl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduLvl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EduProgramType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduProgramType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MunicipalUnit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MunicipalUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfAdmission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfAdmission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeAuthorities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    AuthoritiesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeAuthorities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeAuthorities_Authorities_AuthoritiesId",
                        column: x => x.AuthoritiesId,
                        principalTable: "Authorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Speciality",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProgramTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Speciality_EduProgramType_ProgramTypeId",
                        column: x => x.ProgramTypeId,
                        principalTable: "EduProgramType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EduOrg",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longiitude = table.Column<double>(nullable: false),
                    License = table.Column<bool>(nullable: false),
                    StateAccreditation = table.Column<bool>(nullable: false),
                    MunitipalUnitId = table.Column<int>(nullable: true),
                    AuthoritiiesId = table.Column<int>(nullable: true),
                    TypeAuthoritiesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduOrg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EduOrg_Authorities_AuthoritiiesId",
                        column: x => x.AuthoritiiesId,
                        principalTable: "Authorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EduOrg_MunicipalUnit_MunitipalUnitId",
                        column: x => x.MunitipalUnitId,
                        principalTable: "MunicipalUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EduOrg_TypeAuthorities_TypeAuthoritiesId",
                        column: x => x.TypeAuthoritiesId,
                        principalTable: "TypeAuthorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    SpecialityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Qualification_Speciality_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Speciality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationForm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrganizationId = table.Column<int>(nullable: true),
                    ApplicantId = table.Column<int>(nullable: true),
                    AppDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationForm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationForm_Applicant_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicationForm_EduOrg_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "EduOrg",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EduProgram",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProgramTypeId = table.Column<int>(nullable: true),
                    SpecialityId = table.Column<int>(nullable: true),
                    QualificationId = table.Column<int>(nullable: true),
                    FormId = table.Column<int>(nullable: true),
                    LevelId = table.Column<int>(nullable: true),
                    BaseId = table.Column<int>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EduProgram_EduBase_BaseId",
                        column: x => x.BaseId,
                        principalTable: "EduBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EduProgram_EduForm_FormId",
                        column: x => x.FormId,
                        principalTable: "EduForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EduProgram_EduLvl_LevelId",
                        column: x => x.LevelId,
                        principalTable: "EduLvl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EduProgram_EduOrg_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "EduOrg",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EduProgram_EduProgramType_ProgramTypeId",
                        column: x => x.ProgramTypeId,
                        principalTable: "EduProgramType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EduProgram_Qualification_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "Qualification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EduProgram_Speciality_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Speciality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdmissionPlan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Year = table.Column<DateTime>(nullable: false),
                    AdmissionNumber = table.Column<int>(nullable: false),
                    TargetedAdmission = table.Column<bool>(nullable: false),
                    EduProgramId = table.Column<int>(nullable: true),
                    TypeOfAdmissionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdmissionPlan_EduProgram_EduProgramId",
                        column: x => x.EduProgramId,
                        principalTable: "EduProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdmissionPlan_TypeOfAdmission_TypeOfAdmissionId",
                        column: x => x.TypeOfAdmissionId,
                        principalTable: "TypeOfAdmission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppEduPosition",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationFormId = table.Column<int>(nullable: true),
                    AdmissionPlanId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEduPosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppEduPosition_AdmissionPlan_AdmissionPlanId",
                        column: x => x.AdmissionPlanId,
                        principalTable: "AdmissionPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppEduPosition_ApplicationForm_ApplicationFormId",
                        column: x => x.ApplicationFormId,
                        principalTable: "ApplicationForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppEduPositionsId = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AppEduPosition_AppEduPositionsId",
                        column: x => x.AppEduPositionsId,
                        principalTable: "AppEduPosition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionPlan_EduProgramId",
                table: "AdmissionPlan",
                column: "EduProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionPlan_TypeOfAdmissionId",
                table: "AdmissionPlan",
                column: "TypeOfAdmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEduPosition_AdmissionPlanId",
                table: "AppEduPosition",
                column: "AdmissionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEduPosition_ApplicationFormId",
                table: "AppEduPosition",
                column: "ApplicationFormId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForm_ApplicantId",
                table: "ApplicationForm",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForm_OrganizationId",
                table: "ApplicationForm",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_EduOrg_AuthoritiiesId",
                table: "EduOrg",
                column: "AuthoritiiesId");

            migrationBuilder.CreateIndex(
                name: "IX_EduOrg_MunitipalUnitId",
                table: "EduOrg",
                column: "MunitipalUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_EduOrg_TypeAuthoritiesId",
                table: "EduOrg",
                column: "TypeAuthoritiesId");

            migrationBuilder.CreateIndex(
                name: "IX_EduProgram_BaseId",
                table: "EduProgram",
                column: "BaseId");

            migrationBuilder.CreateIndex(
                name: "IX_EduProgram_FormId",
                table: "EduProgram",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_EduProgram_LevelId",
                table: "EduProgram",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_EduProgram_OrganizationId",
                table: "EduProgram",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_EduProgram_ProgramTypeId",
                table: "EduProgram",
                column: "ProgramTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EduProgram_QualificationId",
                table: "EduProgram",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_EduProgram_SpecialityId",
                table: "EduProgram",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_SpecialityId",
                table: "Qualification",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_ProgramTypeId",
                table: "Speciality",
                column: "ProgramTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_AppEduPositionsId",
                table: "Students",
                column: "AppEduPositionsId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeAuthorities_AuthoritiesId",
                table: "TypeAuthorities",
                column: "AuthoritiesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "AppEduPosition");

            migrationBuilder.DropTable(
                name: "AdmissionPlan");

            migrationBuilder.DropTable(
                name: "ApplicationForm");

            migrationBuilder.DropTable(
                name: "EduProgram");

            migrationBuilder.DropTable(
                name: "TypeOfAdmission");

            migrationBuilder.DropTable(
                name: "Applicant");

            migrationBuilder.DropTable(
                name: "EduBase");

            migrationBuilder.DropTable(
                name: "EduForm");

            migrationBuilder.DropTable(
                name: "EduLvl");

            migrationBuilder.DropTable(
                name: "EduOrg");

            migrationBuilder.DropTable(
                name: "Qualification");

            migrationBuilder.DropTable(
                name: "MunicipalUnit");

            migrationBuilder.DropTable(
                name: "TypeAuthorities");

            migrationBuilder.DropTable(
                name: "Speciality");

            migrationBuilder.DropTable(
                name: "Authorities");

            migrationBuilder.DropTable(
                name: "EduProgramType");
        }
    }
}
