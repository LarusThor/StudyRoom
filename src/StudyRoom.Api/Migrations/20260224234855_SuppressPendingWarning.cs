using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyRoom.Api.Migrations
{
    /// <inheritdoc />
    public partial class SuppressPendingWarning : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b92f0a3e-573b-4b12-8db1-2ccf6d58a34a"),
                column: "ConcurrencyStamp",
                value: "d6243449-c3e9-4464-b540-b46152dacae8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c8d89a25-4b96-4f20-9d79-7f8a54c5213d"),
                column: "ConcurrencyStamp",
                value: "7b143bf7-0190-49c7-9d5d-cdacee7b4a3b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d7f4a42e-1c1b-4c9f-8a50-55f6b234e8e2"),
                column: "ConcurrencyStamp",
                value: "807bd87f-b322-456d-97a2-ab687f84e916");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f2e6b8a1-9d43-4a7c-9f32-71d7c5dbe9f0"),
                column: "ConcurrencyStamp",
                value: "74da0912-665f-4c2a-b14a-2aa501268f1e");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b92f0a3e-573b-4b12-8db1-2ccf6d58a34a"),
                column: "ConcurrencyStamp",
                value: "205bfa93-9a28-49a0-9521-f19972f74c74");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c8d89a25-4b96-4f20-9d79-7f8a54c5213d"),
                column: "ConcurrencyStamp",
                value: "ca41607f-ac9a-4227-bf85-c05577e56811");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d7f4a42e-1c1b-4c9f-8a50-55f6b234e8e2"),
                column: "ConcurrencyStamp",
                value: "4f1f4684-ab41-488b-98f7-5bba07affd4c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f2e6b8a1-9d43-4a7c-9f32-71d7c5dbe9f0"),
                column: "ConcurrencyStamp",
                value: "215fa119-6c28-4706-9d32-e16aee7abe29");
        }
    }
}
