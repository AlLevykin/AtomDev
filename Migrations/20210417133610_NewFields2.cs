using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AtomDev.Migrations
{
    public partial class NewFields2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "MunicipalUnit");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "EduOrg");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Applicant");

            migrationBuilder.AddColumn<bool>(
                name: "DrivingLicenseB",
                table: "Students",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Employed",
                table: "Students",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "EduOrg",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentOrgId",
                table: "EduOrg",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Applicant",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Parent1Id",
                table: "Applicant",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Parent2Id",
                table: "Applicant",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Region = table.Column<string>(nullable: true),
                    Okrug = table.Column<string>(nullable: true),
                    MunicipalUnit = table.Column<string>(nullable: true),
                    MunicipalSettlement = table.Column<string>(nullable: true),
                    Settlement = table.Column<string>(nullable: true),
                    PlanningPatternElemnt = table.Column<string>(nullable: true),
                    RoadNetworkElement = table.Column<string>(nullable: true),
                    LandLotNumber = table.Column<string>(nullable: true),
                    MyProperty = table.Column<string>(nullable: true),
                    UnfinishedObjectNumber = table.Column<string>(nullable: true),
                    RoomNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(nullable: true),
                    SecondName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EduOrg_AddressId",
                table: "EduOrg",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_EduOrg_ParentOrgId",
                table: "EduOrg",
                column: "ParentOrgId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicant_AddressId",
                table: "Applicant",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicant_Parent1Id",
                table: "Applicant",
                column: "Parent1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Applicant_Parent2Id",
                table: "Applicant",
                column: "Parent2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicant_Address_AddressId",
                table: "Applicant",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applicant_Parent_Parent1Id",
                table: "Applicant",
                column: "Parent1Id",
                principalTable: "Parent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applicant_Parent_Parent2Id",
                table: "Applicant",
                column: "Parent2Id",
                principalTable: "Parent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EduOrg_Address_AddressId",
                table: "EduOrg",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EduOrg_EduOrg_ParentOrgId",
                table: "EduOrg",
                column: "ParentOrgId",
                principalTable: "EduOrg",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicant_Address_AddressId",
                table: "Applicant");

            migrationBuilder.DropForeignKey(
                name: "FK_Applicant_Parent_Parent1Id",
                table: "Applicant");

            migrationBuilder.DropForeignKey(
                name: "FK_Applicant_Parent_Parent2Id",
                table: "Applicant");

            migrationBuilder.DropForeignKey(
                name: "FK_EduOrg_Address_AddressId",
                table: "EduOrg");

            migrationBuilder.DropForeignKey(
                name: "FK_EduOrg_EduOrg_ParentOrgId",
                table: "EduOrg");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.DropIndex(
                name: "IX_EduOrg_AddressId",
                table: "EduOrg");

            migrationBuilder.DropIndex(
                name: "IX_EduOrg_ParentOrgId",
                table: "EduOrg");

            migrationBuilder.DropIndex(
                name: "IX_Applicant_AddressId",
                table: "Applicant");

            migrationBuilder.DropIndex(
                name: "IX_Applicant_Parent1Id",
                table: "Applicant");

            migrationBuilder.DropIndex(
                name: "IX_Applicant_Parent2Id",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "DrivingLicenseB",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Employed",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "EduOrg");

            migrationBuilder.DropColumn(
                name: "ParentOrgId",
                table: "EduOrg");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Parent1Id",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Parent2Id",
                table: "Applicant");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "MunicipalUnit",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "EduOrg",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Applicant",
                type: "text",
                nullable: true);
        }
    }
}
