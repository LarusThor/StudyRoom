using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyRoom.Api.Migrations
{
    /// <inheritdoc />
    public partial class FixedDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b92f0a3e-573b-4b12-8db1-2ccf6d58a34a"),
                column: "ConcurrencyStamp",
                value: "050df694-1570-4ba0-8fbc-d1c72c26d15b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c8d89a25-4b96-4f20-9d79-7f8a54c5213d"),
                column: "ConcurrencyStamp",
                value: "9e56004e-2fde-4ba6-a185-c3a235405358");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d7f4a42e-1c1b-4c9f-8a50-55f6b234e8e2"),
                column: "ConcurrencyStamp",
                value: "1b2d0edc-60d0-47fe-b8f2-431325fc4a8d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f2e6b8a1-9d43-4a7c-9f32-71d7c5dbe9f0"),
                column: "ConcurrencyStamp",
                value: "169e5f1e-385b-481e-a447-9dfbdde58ea4");
        }
    }
}
