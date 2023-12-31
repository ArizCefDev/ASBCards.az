﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class webnuytedsksdh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                column: "Create",
                value: new DateTime(2023, 11, 6, 18, 35, 31, 244, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2,
                column: "Create",
                value: new DateTime(2023, 11, 6, 18, 35, 31, 244, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Create", "PasswordHash", "Salt" },
                values: new object[] { new DateTime(2023, 11, 6, 18, 35, 31, 245, DateTimeKind.Local).AddTicks(730), "�v��2>�#3Q\r|���d�דun��Mw��i��", "CpAaVx1i5sBCtw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                column: "Create",
                value: new DateTime(2023, 11, 4, 21, 45, 13, 48, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2,
                column: "Create",
                value: new DateTime(2023, 11, 4, 21, 45, 13, 48, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Create", "PasswordHash", "Salt" },
                values: new object[] { new DateTime(2023, 11, 4, 21, 45, 13, 48, DateTimeKind.Local).AddTicks(7390), "Z$����O^��3fnׅ�_�q-�k( +_����", "LmqGkVETaCgdww==" });
        }
    }
}
