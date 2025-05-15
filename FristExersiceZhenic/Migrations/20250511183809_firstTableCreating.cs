using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FristExersiceZhenic.Migrations
{
    /// <inheritdoc />
    public partial class firstTableCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "اپل", "13 عالیه ولی گرونه ", "آیفون 13", 80 },
                    { 2, "اپل", "عالیه ولی گرونه 14 ", "آیفون 14", 90 },
                    { 3, "اپل", "عالیه ولی گرونه 15 ", "آیفون 15", 100 },
                    { 4, "سامسونگ", "ارزونه ولی عالی نیست ", "گلکسی a56", 38 },
                    { 5, "سامسونگ", "عالیه گرونم نیست ", "گلکسی s24 fe", 48 },
                    { 6, "سامسونگه", "عالیه ولی گرونه خیلیم گرونه ", "گلکسی s25 اولترا", 150 },
                    { 7, "شیائومی", "ادای عالی هارو در میاره... نه ارزونه  نه گرون  ", "شیائومی 15 الترا", 70 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
