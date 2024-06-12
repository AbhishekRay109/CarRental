using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class car1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarRental_Admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", maxLength: 5, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Admin_Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarRental_Admin", x => x.AdminID);
                    table.ForeignKey(
                        name: "FK_CarRental_Admin_CarRental_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "CarRental_Cars",
                        principalColumn: "CarID");
                });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7070), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7072), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7074), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7076), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7088), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7092), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7094), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9549), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9553), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9556), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9463), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9475), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9478), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7119), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7122), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7126), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6681), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6683), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6733), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6735), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6737), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6739), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 258, DateTimeKind.Local).AddTicks(60), new DateTime(2024, 1, 17, 13, 18, 19, 258, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 258, DateTimeKind.Local).AddTicks(62), new DateTime(2024, 1, 17, 13, 18, 19, 258, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9624), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9627), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9630), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9633), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9635), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9638), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9640), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9642), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9644), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9647), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9649), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9651), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 13,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9653), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 14,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9655), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 15,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9658), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 16,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9661), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 17,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9663), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 18,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9665), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 19,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9667), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 20,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9669), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 21,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9671), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 22,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9674), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 23,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9676), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 24,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9678), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 25,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9680), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 26,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9683), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 27,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9686), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 28,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9688), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 29,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9690), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 30,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9692), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 31,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9694), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 32,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9697), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 33,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9699), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 34,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9701), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 35,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9703), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 36,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9705), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 37,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9709), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 38,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9711), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 39,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9713), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 40,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9715), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 41,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9718), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 42,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9720), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 43,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9722), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 44,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9724), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 45,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9726), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 46,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9728), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 47,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9730), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 48,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9733), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 49,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9735), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 50,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9737), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 51,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9740), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 52,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9742), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 53,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9744), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 54,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9746), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 55,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9748), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 56,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9750), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 57,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9752), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 58,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9754), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 59,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9757), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 60,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9759), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 61,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9761), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 62,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9764), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 63,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9766), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 64,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9768), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 65,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9770), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 66,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9772), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 67,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 68,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9776), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 69,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9778), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 70,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9784), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 71,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9786), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 72,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9788), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 73,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9790), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 74,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9792), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 75,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9794), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 76,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9796), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 77,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9798), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 78,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9801), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 79,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9803), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 80,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9805), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 81,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9808), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 82,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 83,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9812), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 84,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9814), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 85,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9816), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 86,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9818), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 87,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9820), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 88,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9822), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 89,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9824), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 90,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9826), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 91,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9829), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 92,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9833), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 93,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9874), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 94,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9876), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 95,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9878), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 96,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9880), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 97,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9882), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 98,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9885), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 99,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9887), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 100,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9889), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 101,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9891), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 102,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9893), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 103,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9895), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 104,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9898), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 105,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9900), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 106,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9903), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 107,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9905), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 108,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 109,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9910), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 110,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9912), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 111,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9914), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 112,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9916), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 113,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9918), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 114,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 115,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9926), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 116,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9928), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 117,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 118,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9932), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 119,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9934), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 120,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 121,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9939), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 122,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9941), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 123,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9943), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 124,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9945), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 125,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9947), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 126,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9950), new DateTime(2024, 1, 17, 13, 18, 19, 257, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6632), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6652), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 1, 17, 13, 18, 19, 254, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.CreateIndex(
                name: "IX_CarRental_Admin_CarId",
                table: "CarRental_Admin",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarRental_Admin");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4421), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4425), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4429), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4431), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4436), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4438), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4441), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4443), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4445), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4447), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4449), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6137), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6153), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(5928), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(5963), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(5968), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(5975), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4484), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4488), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4490), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4493), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3191), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3194), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3197), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3199), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3202), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3204), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(7149), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(7155), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6206), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6210), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6213), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6216), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6219), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6222), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6226), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6228), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6231), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6234), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6244), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 13,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6248), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 14,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 15,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 16,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6264), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 17,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6266), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 18,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6269), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 19,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6274), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 20,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6277), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 21,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6280), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 22,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6282), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 23,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6291), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 24,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6293), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 25,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6296), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 26,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6299), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 27,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6302), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 28,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6305), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 29,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6310), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 30,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 31,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6322), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 32,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 33,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6328), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 34,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6333), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 35,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6336), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 36,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6338), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 37,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6343), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 38,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6349), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 39,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6353), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 40,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 41,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6359), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 42,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6361), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 43,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6364), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 44,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6370), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 45,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6372), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 46,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6375), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 47,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6378), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 48,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6381), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 49,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6384), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 50,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6386), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 51,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6389), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 52,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6392), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 53,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6413), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 54,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6416), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 55,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6418), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 56,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6421), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 57,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6424), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 58,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6426), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 59,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6429), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 60,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6432), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 61,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6435), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 62,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6439), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 63,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6444), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 64,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6446), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 65,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6449), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 66,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6452), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 67,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6454), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 68,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 69,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6465), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 70,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6467), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 71,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6473), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 72,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6478), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 73,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6481), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 74,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6484), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 75,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6490), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 76,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6493), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 77,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6495), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 78,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6498), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 79,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6501), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 80,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6504), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 81,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6507), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 82,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 83,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6513), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 84,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6519), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 85,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6522), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 86,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6525), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 87,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6527), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 88,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6531), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 89,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6538), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 90,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6541), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 91,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6547), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 92,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 93,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6554), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 94,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6557), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 95,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 96,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6562), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 97,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6567), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 98,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6569), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 99,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6573), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 100,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6576), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 101,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6579), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 102,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6582), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 103,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6584), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 104,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 105,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6591), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 106,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6593), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 107,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6596), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 108,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6599), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 109,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6601), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 110,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6606), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 111,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6608), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 112,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6611), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 113,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6614), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 114,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 115,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 116,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6625), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 117,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6628), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 118,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6632), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 119,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6637), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 120,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6642), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 121,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6645), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 122,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6648), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 123,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6652), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 124,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6655), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 125,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6658), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 126,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6664), new DateTime(2023, 12, 29, 20, 33, 30, 258, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3126), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3147), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3151), new DateTime(2023, 12, 29, 20, 33, 30, 254, DateTimeKind.Local).AddTicks(3152) });
        }
    }
}
