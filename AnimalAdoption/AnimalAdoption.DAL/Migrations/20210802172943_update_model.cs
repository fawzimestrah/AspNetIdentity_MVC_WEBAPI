using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalAdoption.DAL.Migrations
{
    public partial class update_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ResidencyType_ResidencyTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ResidencyType");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "ResidencyTypeId",
                table: "AspNetUsers",
                newName: "HumanResidencyTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_ResidencyTypeId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_HumanResidencyTypeId");

            migrationBuilder.RenameColumn(
                name: "TrainingDescription",
                table: "Animals",
                newName: "MonthYear");

            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "VerificationRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PassportUrl",
                table: "VerificationRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestDate",
                table: "VerificationRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "VerificationDate",
                table: "VerificationRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnimalResidencyTypeId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WeightId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TrainingLevelId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AnimalTypeId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AnimalTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnimalTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HumanResidencyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidencyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidencyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HumanResidencyType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AnimalResidencyTypeId",
                table: "AspNetUsers",
                column: "AnimalResidencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AnimalTypeId",
                table: "Animals",
                column: "AnimalTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AnimalTypes_AnimalTypeId",
                table: "Animals",
                column: "AnimalTypeId",
                principalTable: "AnimalTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_HumanResidencyType_HumanResidencyTypeId",
                table: "AspNetUsers",
                column: "HumanResidencyTypeId",
                principalTable: "HumanResidencyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_LivingStates_AnimalResidencyTypeId",
                table: "AspNetUsers",
                column: "AnimalResidencyTypeId",
                principalTable: "LivingStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AnimalTypes_AnimalTypeId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_HumanResidencyType_HumanResidencyTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_LivingStates_AnimalResidencyTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AnimalTypes");

            migrationBuilder.DropTable(
                name: "HumanResidencyType");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AnimalResidencyTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Animals_AnimalTypeId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "VerificationRequests");

            migrationBuilder.DropColumn(
                name: "PassportUrl",
                table: "VerificationRequests");

            migrationBuilder.DropColumn(
                name: "RequestDate",
                table: "VerificationRequests");

            migrationBuilder.DropColumn(
                name: "VerificationDate",
                table: "VerificationRequests");

            migrationBuilder.DropColumn(
                name: "AnimalResidencyTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "AnimalTypeId",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "HumanResidencyTypeId",
                table: "AspNetUsers",
                newName: "ResidencyTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_HumanResidencyTypeId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_ResidencyTypeId");

            migrationBuilder.RenameColumn(
                name: "MonthYear",
                table: "Animals",
                newName: "TrainingDescription");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WeightId",
                table: "Animals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TrainingLevelId",
                table: "Animals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ResidencyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidencyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidencyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidencyType", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ResidencyType_ResidencyTypeId",
                table: "AspNetUsers",
                column: "ResidencyTypeId",
                principalTable: "ResidencyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
