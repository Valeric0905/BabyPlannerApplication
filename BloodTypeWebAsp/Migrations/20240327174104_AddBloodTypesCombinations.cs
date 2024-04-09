using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodTypeWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddBloodTypesCombinations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodTypes",
                columns: table => new
                {
                    BloodTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BloodTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodTypes", x => x.BloodTypeID);
                });

            migrationBuilder.CreateTable(
                name: "RhFactors",
                columns: table => new
                {
                    RhFactorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RhFactorType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RhFactors", x => x.RhFactorID);
                });

            migrationBuilder.CreateTable(
                name: "ParentCombinationsRh",
                columns: table => new
                {
                    CombinationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotherBloodTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FatherBloodTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MotherRhFactorID = table.Column<int>(type: "int", nullable: false),
                    FatherRhFactorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentCombinationsRh", x => x.CombinationID);
                    table.ForeignKey(
                        name: "FK_ParentCombinationsRh_BloodTypes_FatherBloodTypeID",
                        column: x => x.FatherBloodTypeID,
                        principalTable: "BloodTypes",
                        principalColumn: "BloodTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentCombinationsRh_BloodTypes_MotherBloodTypeID",
                        column: x => x.MotherBloodTypeID,
                        principalTable: "BloodTypes",
                        principalColumn: "BloodTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentCombinationsRh_RhFactors_FatherRhFactorID",
                        column: x => x.FatherRhFactorID,
                        principalTable: "RhFactors",
                        principalColumn: "RhFactorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentCombinationsRh_RhFactors_MotherRhFactorID",
                        column: x => x.MotherRhFactorID,
                        principalTable: "RhFactors",
                        principalColumn: "RhFactorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChildOutcomesRh",
                columns: table => new
                {
                    OutcomeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CombinationID = table.Column<int>(type: "int", nullable: false),
                    ChildBloodTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChildRhFactorID = table.Column<int>(type: "int", nullable: false),
                    Probability = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildOutcomesRh", x => x.OutcomeID);
                    table.ForeignKey(
                        name: "FK_ChildOutcomesRh_BloodTypes_ChildBloodTypeID",
                        column: x => x.ChildBloodTypeID,
                        principalTable: "BloodTypes",
                        principalColumn: "BloodTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChildOutcomesRh_ParentCombinationsRh_CombinationID",
                        column: x => x.CombinationID,
                        principalTable: "ParentCombinationsRh",
                        principalColumn: "CombinationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChildOutcomesRh_RhFactors_ChildRhFactorID",
                        column: x => x.ChildRhFactorID,
                        principalTable: "RhFactors",
                        principalColumn: "RhFactorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChildOutcomesRh_ChildBloodTypeID",
                table: "ChildOutcomesRh",
                column: "ChildBloodTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ChildOutcomesRh_ChildRhFactorID",
                table: "ChildOutcomesRh",
                column: "ChildRhFactorID");

            migrationBuilder.CreateIndex(
                name: "IX_ChildOutcomesRh_CombinationID",
                table: "ChildOutcomesRh",
                column: "CombinationID");

            migrationBuilder.CreateIndex(
                name: "IX_ParentCombinationsRh_FatherBloodTypeID",
                table: "ParentCombinationsRh",
                column: "FatherBloodTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ParentCombinationsRh_FatherRhFactorID",
                table: "ParentCombinationsRh",
                column: "FatherRhFactorID");

            migrationBuilder.CreateIndex(
                name: "IX_ParentCombinationsRh_MotherBloodTypeID",
                table: "ParentCombinationsRh",
                column: "MotherBloodTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ParentCombinationsRh_MotherRhFactorID",
                table: "ParentCombinationsRh",
                column: "MotherRhFactorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildOutcomesRh");

            migrationBuilder.DropTable(
                name: "ParentCombinationsRh");

            migrationBuilder.DropTable(
                name: "BloodTypes");

            migrationBuilder.DropTable(
                name: "RhFactors");
        }
    }
}
