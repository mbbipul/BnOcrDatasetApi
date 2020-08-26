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
                    FontSize = table.Column<int>(nullable: false),
                    ImageData = table.Column<string>(nullable: true),
                    GraphemeRootId = table.Column<string>(nullable: true),
                    VowelDiacreticId = table.Column<string>(nullable: true),
                    ConsonantDiacreticId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcrClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OcrTrashes",
                columns: table => new
                {
                    OcrTrashId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OcrClassId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcrTrashes", x => x.OcrTrashId);
                    table.ForeignKey(
                        name: "FK_OcrTrashes_OcrClasses_OcrClassId",
                        column: x => x.OcrClassId,
                        principalTable: "OcrClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OcrTrashes_OcrClassId",
                table: "OcrTrashes",
                column: "OcrClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OcrTrashes");

            migrationBuilder.DropTable(
                name: "OcrClasses");
        }
    }
}
