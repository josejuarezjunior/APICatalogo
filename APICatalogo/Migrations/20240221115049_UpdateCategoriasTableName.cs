using APICatalogo.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoriasTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categoria");
        }
    }
}
