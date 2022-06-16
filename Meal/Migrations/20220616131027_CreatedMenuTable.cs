using Microsoft.EntityFrameworkCore.Migrations;

namespace Meal.Migrations
{
    public partial class CreatedMenuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Menu1 = table.Column<string>(nullable: true),
                    Menu2 = table.Column<string>(nullable: true),
                    Menu3 = table.Column<string>(nullable: true),
                    ImageHeader = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImagePricing = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
