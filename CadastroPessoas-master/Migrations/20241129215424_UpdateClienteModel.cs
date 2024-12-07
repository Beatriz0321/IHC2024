using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroPessoas.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClienteModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Cliente",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cliente",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EstadoCivil",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeMae",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePai",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RG",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "NomeMae",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "NomePai",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "RG",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cliente",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cliente",
                newName: "id");
        }
    }
}
