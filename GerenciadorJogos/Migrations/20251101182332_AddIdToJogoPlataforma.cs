using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorJogos.Migrations
{
    /// <inheritdoc />
    public partial class AddIdToJogoPlataforma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "JogoPlataformas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "JogoGeneros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "JogoGeneros",
                keyColumns: new[] { "GeneroId", "JogoId" },
                keyValues: new object[] { 12, 1 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoGeneros",
                keyColumns: new[] { "GeneroId", "JogoId" },
                keyValues: new object[] { 14, 1 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoGeneros",
                keyColumns: new[] { "GeneroId", "JogoId" },
                keyValues: new object[] { 1, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoGeneros",
                keyColumns: new[] { "GeneroId", "JogoId" },
                keyValues: new object[] { 3, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoGeneros",
                keyColumns: new[] { "GeneroId", "JogoId" },
                keyValues: new object[] { 9, 3 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoGeneros",
                keyColumns: new[] { "GeneroId", "JogoId" },
                keyValues: new object[] { 10, 3 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoGeneros",
                keyColumns: new[] { "GeneroId", "JogoId" },
                keyValues: new object[] { 2, 4 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoGeneros",
                keyColumns: new[] { "GeneroId", "JogoId" },
                keyValues: new object[] { 12, 4 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoGeneros",
                keyColumns: new[] { "GeneroId", "JogoId" },
                keyValues: new object[] { 10, 5 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoGeneros",
                keyColumns: new[] { "GeneroId", "JogoId" },
                keyValues: new object[] { 11, 5 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoPlataformas",
                keyColumns: new[] { "JogoId", "PlataformaId" },
                keyValues: new object[] { 1, 4 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoPlataformas",
                keyColumns: new[] { "JogoId", "PlataformaId" },
                keyValues: new object[] { 1, 6 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoPlataformas",
                keyColumns: new[] { "JogoId", "PlataformaId" },
                keyValues: new object[] { 2, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoPlataformas",
                keyColumns: new[] { "JogoId", "PlataformaId" },
                keyValues: new object[] { 3, 4 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoPlataformas",
                keyColumns: new[] { "JogoId", "PlataformaId" },
                keyValues: new object[] { 4, 5 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoPlataformas",
                keyColumns: new[] { "JogoId", "PlataformaId" },
                keyValues: new object[] { 5, 4 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoPlataformas",
                keyColumns: new[] { "JogoId", "PlataformaId" },
                keyValues: new object[] { 6, 5 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoPlataformas",
                keyColumns: new[] { "JogoId", "PlataformaId" },
                keyValues: new object[] { 7, 5 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoPlataformas",
                keyColumns: new[] { "JogoId", "PlataformaId" },
                keyValues: new object[] { 8, 7 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoPlataformas",
                keyColumns: new[] { "JogoId", "PlataformaId" },
                keyValues: new object[] { 9, 4 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "JogoPlataformas",
                keyColumns: new[] { "JogoId", "PlataformaId" },
                keyValues: new object[] { 10, 5 },
                column: "Id",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "JogoPlataformas");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "JogoGeneros");
        }
    }
}
