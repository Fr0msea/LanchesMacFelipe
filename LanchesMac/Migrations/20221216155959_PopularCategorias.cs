using Microsoft.EntityFrameworkCore.Migrations;

namespace LanchesMac.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Descricao)" +
                "VALUES('Normal','Lanche Normal')");

            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Descricao)" +
                "VALUES('Natural','Lanche Natural')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
