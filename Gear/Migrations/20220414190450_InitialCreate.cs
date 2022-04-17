using Microsoft.EntityFrameworkCore.Migrations;

namespace Gear.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bevel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Z1 = table.Column<int>(nullable: false),
                    Z2 = table.Column<int>(nullable: false),
                    Mt = table.Column<double>(nullable: false),
                    Zc = table.Column<double>(nullable: false),
                    Re = table.Column<double>(nullable: false),
                    B = table.Column<double>(nullable: false),
                    Mm = table.Column<double>(nullable: false),
                    Rm = table.Column<double>(nullable: false),
                    Dm1 = table.Column<double>(nullable: false),
                    Dm2 = table.Column<double>(nullable: false),
                    Delta1 = table.Column<double>(nullable: false),
                    Delta2 = table.Column<double>(nullable: false),
                    De1 = table.Column<double>(nullable: false),
                    De2 = table.Column<double>(nullable: false),
                    Dae1 = table.Column<double>(nullable: false),
                    Dae2 = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bevel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bevel");
        }
    }
}
