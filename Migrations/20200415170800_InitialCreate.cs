using Microsoft.EntityFrameworkCore.Migrations;

namespace restApiDataset.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OcrClasses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(nullable: true),
                    ImageData = table.Column<string>(nullable: true),
                    GraphemeRootId = table.Column<string>(nullable: true),
                    VowelDiacreticId = table.Column<string>(nullable: true),
                    ConsonantDiacreticId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcrClasses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OcrClasses");
        }
    }
}
