using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MonsterHunterDB.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "Id", "Description", "FirstName", "LastName", "MonsterName", "Type" },
                values: new object[,]
                {
                    { 1, "Suspendisse potenti. Cras in purus eu magna vulputate luctus.", "Ortensia", "Daniellot", "methodology", "Marketing" },
                    { 2, "Curabitur gravida nisi at nibh. In hac habitasse platea dictumst.", "Barbi", "Leinster", "service-desk", "Sales" },
                    { 3, "Vivamus tortor. Duis mattis egestas metus.", "Chloe", "Ucceli", "mobile", "Accounting" },
                    { 4, "Aenean lectus.", "Reggie", "Catterell", "Open-source", "Accounting" },
                    { 5, "Vivamus in felis eu sapien cursus vestibulum. Proin eu mi.", "Ramsay", "Beamand", "exuding", "Product Management" },
                    { 6, "Vestibulum ante ipsum primis  faucibus orci luctus et ultrices posuere cubilia Curae; Donec.", "Jorie", "Haulkham", "mobile", "Human Resources" },
                    { 7, "Quisque erat eros", "Alejoa", "Ord", "Quality-focused", "Research and Development" },
                    { 8, "Phasellus sit amet erat.", "Vasily", "Celes", "Multi-lateral", "Support" },
                    { 9, "Aliquam augue quam", "Marcille", "Messingham", "task-force", "Human Resources" },
                    { 10, "Aliquam non mauris. Morbi non lectus.", "Kellia", "Crimes", "array", "Human Resources" },
                    { 11, "Cras pellentesque volutpat dui.", "Dyane", "Close", "Grass-roots", "Engineering" },
                    { 12, "Proin risus. Praesent lectus.", "Clarinda", "Cowwell", "solution", "Research and Development" },
                    { 13, "Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est.", "Ginger", "Isacoff", "time-frame", "Human Resources" },
                    { 14, "Vestibulum ante ipsum primis  faucibus orci luctus et ultrices posuere cubilia Curae; Donec ", "Lita", "Kinahan", "toolset", "Human Resources" },
                    { 15, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", "Fulton", "Hartland", "Implemented", "Support" },
                    { 16, "Cras pellentesque volutpat dui.Maecenas tristique", "Dev", "Dietzler", "multi-tasking", "Services" },
                    { 17, "Nam dui.", "Aubrie", "Brandoni", "executive", "Services" },
                    { 18, "Aliquam erat volutpat.", "Carlynne", "Ruslen", "bifurcated", "Support" },
                    { 19, "Nam dui.", "Zitella", "Mudle", "Robust", "Training" },
                    { 20, "Etiam faucibus cursus urna.", "Beatrisa", "La Vigne", "database", "Engineering" },
                    { 21, "Aliquam augue quam", "Phaedra", "Huntingdon", "policy", "Accounting" },
                    { 22, "Donec dapibus. Duis at velit eu est congue elementum.", "Vinni", "Petrusch", "motivating", "Training" },
                    { 23, "In sagittis dui vel nisl. Duis ac nibh.", "Boy", "Nolder", "benchmark", "Human Resources" },
                    { 24, "Pellentesque eget nunc.", "Emlynn", "Feathersby", "Total", "Services" },
                    { 25, "Maecenas rhoncus aliquam lacus.", "Franz", "Louys", "website", "Marketing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 25);
        }
    }
}
