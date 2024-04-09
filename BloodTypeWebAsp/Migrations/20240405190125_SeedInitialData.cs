using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BloodTypeWeb.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BloodTypes",
                columns: new[] { "BloodTypeID", "BloodTypeName" },
                values: new object[,]
                {
                    { "A", "A" },
                    { "AB", "AB" },
                    { "B", "B" },
                    { "O", "O" }
                });

            migrationBuilder.InsertData(
                table: "RhFactors",
                columns: new[] { "RhFactorID", "RhFactorType" },
                values: new object[,]
                {
                    { 1, "+" },
                    { 2, "-" }
                });

            migrationBuilder.InsertData(
                table: "ParentCombinationsRh",
                columns: new[] { "CombinationID", "FatherBloodTypeID", "FatherRhFactorID", "MotherBloodTypeID", "MotherRhFactorID" },
                values: new object[,]
                {
                    { 1, "O", 2, "O", 1 },
                    { 2, "O", 1, "O", 2 },
                    { 3, "O", 1, "O", 1 },
                    { 4, "O", 2, "O", 2 },
                    { 5, "A", 2, "O", 1 },
                    { 6, "A", 1, "O", 2 },
                    { 7, "A", 1, "O", 1 },
                    { 8, "A", 2, "O", 2 },
                    { 9, "B", 2, "O", 1 },
                    { 10, "B", 1, "O", 2 },
                    { 11, "B", 1, "O", 1 },
                    { 12, "B", 2, "O", 2 },
                    { 13, "AB", 2, "O", 1 },
                    { 14, "AB", 1, "O", 2 },
                    { 15, "AB", 1, "O", 1 },
                    { 16, "AB", 2, "O", 2 },
                    { 17, "A", 2, "A", 1 },
                    { 18, "A", 1, "A", 2 },
                    { 19, "A", 1, "A", 1 },
                    { 20, "A", 2, "A", 2 },
                    { 21, "O", 2, "A", 1 },
                    { 22, "O", 1, "A", 2 },
                    { 23, "O", 1, "A", 1 },
                    { 24, "O", 2, "A", 2 },
                    { 25, "B", 2, "A", 1 },
                    { 26, "B", 1, "A", 2 },
                    { 27, "B", 1, "A", 1 },
                    { 28, "B", 2, "A", 2 },
                    { 29, "AB", 2, "A", 1 },
                    { 30, "AB", 1, "A", 2 },
                    { 31, "AB", 1, "A", 1 },
                    { 32, "AB", 2, "A", 2 },
                    { 33, "B", 2, "B", 1 },
                    { 34, "B", 1, "B", 2 },
                    { 35, "B", 1, "B", 1 },
                    { 36, "B", 2, "B", 2 },
                    { 37, "O", 2, "B", 1 },
                    { 38, "O", 1, "B", 2 },
                    { 39, "O", 1, "B", 1 },
                    { 40, "O", 2, "B", 2 },
                    { 41, "A", 2, "B", 1 },
                    { 42, "A", 1, "B", 2 },
                    { 43, "A", 1, "B", 1 },
                    { 44, "A", 2, "B", 2 },
                    { 45, "AB", 2, "B", 1 },
                    { 46, "AB", 1, "B", 2 },
                    { 47, "AB", 1, "B", 1 },
                    { 48, "AB", 2, "B", 2 },
                    { 49, "AB", 2, "AB", 1 },
                    { 50, "AB", 1, "AB", 2 },
                    { 51, "AB", 1, "AB", 1 },
                    { 52, "AB", 2, "AB", 2 },
                    { 53, "O", 2, "AB", 1 },
                    { 54, "O", 1, "AB", 2 },
                    { 55, "O", 1, "AB", 1 },
                    { 56, "O", 2, "AB", 2 },
                    { 57, "A", 2, "AB", 1 },
                    { 58, "A", 1, "AB", 2 },
                    { 59, "A", 1, "AB", 1 },
                    { 60, "A", 2, "AB", 2 },
                    { 61, "B", 2, "AB", 1 },
                    { 62, "B", 1, "AB", 2 },
                    { 63, "B", 1, "AB", 1 },
                    { 64, "B", 2, "AB", 2 }
                });

            migrationBuilder.InsertData(
                table: "ChildOutcomesRh",
                columns: new[] { "OutcomeID", "ChildBloodTypeID", "ChildRhFactorID", "CombinationID", "Probability" },
                values: new object[,]
                {
                    { 1, "O", 1, 1, "50%" },
                    { 2, "O", 2, 1, "50%" },
                    { 3, "O", 1, 2, "50%" },
                    { 4, "O", 2, 2, "50%" },
                    { 5, "O", 1, 3, "94%" },
                    { 6, "O", 2, 3, "6%" },
                    { 7, "O", 2, 4, "100%" },
                    { 8, "O", 1, 5, "50%" },
                    { 9, "O", 2, 5, "50%" },
                    { 10, "A", 1, 5, "50%" },
                    { 11, "A", 2, 5, "50%" },
                    { 12, "O", 1, 6, "50%" },
                    { 13, "O", 2, 6, "50%" },
                    { 14, "A", 1, 6, "50%" },
                    { 15, "A", 2, 6, "50%" },
                    { 16, "O", 1, 7, "94%" },
                    { 17, "O", 2, 7, "6%" },
                    { 18, "A", 1, 7, "94%" },
                    { 19, "A", 2, 7, "6%" },
                    { 20, "O", 2, 8, "100%" },
                    { 21, "A", 2, 8, "100%" },
                    { 22, "O", 1, 9, "50%" },
                    { 23, "O", 2, 9, "50%" },
                    { 24, "B", 1, 9, "50%" },
                    { 25, "B", 2, 9, "50%" },
                    { 26, "O", 1, 10, "50%" },
                    { 27, "O", 2, 10, "50%" },
                    { 28, "B", 1, 10, "50%" },
                    { 29, "B", 2, 10, "50%" },
                    { 30, "O", 1, 11, "94%" },
                    { 31, "O", 2, 11, "6%" },
                    { 32, "B", 1, 11, "94%" },
                    { 33, "B", 2, 11, "6%" },
                    { 34, "O", 2, 12, "100%" },
                    { 35, "B", 2, 12, "100%" },
                    { 36, "O", 1, 9, "50%" },
                    { 37, "O", 2, 9, "50%" },
                    { 38, "AB", 1, 9, "50%" },
                    { 39, "AB", 2, 9, "50%" },
                    { 40, "O", 1, 10, "50%" },
                    { 41, "O", 2, 10, "50%" },
                    { 42, "AB", 1, 10, "50%" },
                    { 43, "AB", 2, 10, "50%" },
                    { 44, "O", 1, 11, "94%" },
                    { 45, "O", 2, 11, "6%" },
                    { 46, "AB", 1, 11, "94%" },
                    { 47, "AB", 2, 11, "6%" },
                    { 48, "O", 2, 12, "100%" },
                    { 49, "AB", 2, 12, "100%" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ChildOutcomesRh",
                keyColumn: "OutcomeID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "BloodTypes",
                keyColumn: "BloodTypeID",
                keyValue: "AB");

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ParentCombinationsRh",
                keyColumn: "CombinationID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BloodTypes",
                keyColumn: "BloodTypeID",
                keyValue: "A");

            migrationBuilder.DeleteData(
                table: "BloodTypes",
                keyColumn: "BloodTypeID",
                keyValue: "B");

            migrationBuilder.DeleteData(
                table: "BloodTypes",
                keyColumn: "BloodTypeID",
                keyValue: "O");

            migrationBuilder.DeleteData(
                table: "RhFactors",
                keyColumn: "RhFactorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RhFactors",
                keyColumn: "RhFactorID",
                keyValue: 2);
        }
    }
}
