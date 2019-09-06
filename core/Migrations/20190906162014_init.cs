using Microsoft.EntityFrameworkCore.Migrations;

namespace core.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Atributos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(nullable: true),
                    ProdutoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atributos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atributos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Atributos",
                columns: new[] { "Id", "Descricao", "ProdutoId" },
                values: new object[] { 1, "chave", null });

            migrationBuilder.InsertData(
                table: "Atributos",
                columns: new[] { "Id", "Descricao", "ProdutoId" },
                values: new object[] { 2, "motor", null });

            migrationBuilder.InsertData(
                table: "Atributos",
                columns: new[] { "Id", "Descricao", "ProdutoId" },
                values: new object[] { 3, "abraçadeira", null });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao" },
                values: new object[] { 1, "chave" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao" },
                values: new object[] { 2, "motor" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao" },
                values: new object[] { 3, "abraçadeira" });

            migrationBuilder.CreateIndex(
                name: "IX_Atributos_ProdutoId",
                table: "Atributos",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atributos");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
