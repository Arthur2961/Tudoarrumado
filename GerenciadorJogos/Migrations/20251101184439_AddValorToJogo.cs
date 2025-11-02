using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorJogos.Migrations
{
    /// <inheritdoc />
    public partial class AddValorToJogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Jogos",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 9,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 11,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 12,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 13,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 14,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 15,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 16,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 17,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "Id",
                keyValue: 18,
                column: "Valor",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Jogos");
        }
    }
}
