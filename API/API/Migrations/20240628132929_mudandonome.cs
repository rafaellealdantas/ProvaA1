using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class mudandonome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 1, 10, 29, 28, 741, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "6d091456-5a2f-4b5a-98fc-f1a3b50a627d",
                column: "CriadoEm",
                value: new DateTime(2024, 6, 30, 10, 29, 28, 741, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd",
                column: "CriadoEm",
                value: new DateTime(2024, 6, 29, 10, 29, 28, 741, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 1, 10, 29, 28, 741, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 5, 10, 29, 28, 741, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 12, 10, 29, 28, 741, DateTimeKind.Local).AddTicks(1794));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 1, 9, 47, 37, 844, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "6d091456-5a2f-4b5a-98fc-f1a3b50a627d",
                column: "CriadoEm",
                value: new DateTime(2024, 6, 30, 9, 47, 37, 844, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd",
                column: "CriadoEm",
                value: new DateTime(2024, 6, 29, 9, 47, 37, 844, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 1, 9, 47, 37, 844, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 5, 9, 47, 37, 844, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 12, 9, 47, 37, 844, DateTimeKind.Local).AddTicks(5748));
        }
    }
}
