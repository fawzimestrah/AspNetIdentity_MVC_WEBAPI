using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalAdoption.DAL.Migrations
{
    public partial class updateanimalmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EnergyLevelId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FriendlyLevelId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVaccinated",
                table: "Animals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TrainingDescription",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrainingLevelId",
                table: "Animals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VaccinationDescription",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VaccinationLevelId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeightId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EnergyLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FriendlyLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendlyLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VaccinationLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeightDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weights", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_EnergyLevelId",
                table: "Animals",
                column: "EnergyLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_FriendlyLevelId",
                table: "Animals",
                column: "FriendlyLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_TrainingLevelId",
                table: "Animals",
                column: "TrainingLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_VaccinationLevelId",
                table: "Animals",
                column: "VaccinationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_WeightId",
                table: "Animals",
                column: "WeightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_EnergyLevels_EnergyLevelId",
                table: "Animals",
                column: "EnergyLevelId",
                principalTable: "EnergyLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_FriendlyLevels_FriendlyLevelId",
                table: "Animals",
                column: "FriendlyLevelId",
                principalTable: "FriendlyLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_TrainingLevels_TrainingLevelId",
                table: "Animals",
                column: "TrainingLevelId",
                principalTable: "TrainingLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_VaccinationLevels_VaccinationLevelId",
                table: "Animals",
                column: "VaccinationLevelId",
                principalTable: "VaccinationLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Weights_WeightId",
                table: "Animals",
                column: "WeightId",
                principalTable: "Weights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_EnergyLevels_EnergyLevelId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_FriendlyLevels_FriendlyLevelId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_TrainingLevels_TrainingLevelId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_VaccinationLevels_VaccinationLevelId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Weights_WeightId",
                table: "Animals");

            migrationBuilder.DropTable(
                name: "EnergyLevels");

            migrationBuilder.DropTable(
                name: "FriendlyLevels");

            migrationBuilder.DropTable(
                name: "TrainingLevels");

            migrationBuilder.DropTable(
                name: "VaccinationLevels");

            migrationBuilder.DropTable(
                name: "Weights");

            migrationBuilder.DropIndex(
                name: "IX_Animals_EnergyLevelId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_FriendlyLevelId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_TrainingLevelId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_VaccinationLevelId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_WeightId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "EnergyLevelId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "FriendlyLevelId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "IsVaccinated",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "TrainingDescription",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "TrainingLevelId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "VaccinationDescription",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "VaccinationLevelId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "WeightId",
                table: "Animals");
        }
    }
}
