using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class carRental1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "CarRental_Images");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "CarRental_Images",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "CarRental_Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "CarRental_Images");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "CarRental_Customers");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "CarRental_Images",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2534), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2537), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2542), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2543), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2545), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2546), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2547), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1984), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1987), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1991), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1908), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1922), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1925), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1927), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2571), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2575), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2302), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2304), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2305), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2306), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2309), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2403), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2405), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2009), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2011), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2077), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2079), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2080), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2082), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2084), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2086), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2087), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2089), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2090), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2092), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 13,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2094), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 14,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2095), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 15,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2097), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 16,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2099), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 17,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2101), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 18,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2102), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 19,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2104), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 20,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2105), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 21,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2107), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 22,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2108), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 23,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2110), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 24,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2111), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 25,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 26,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2114), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 27,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2117), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 28,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2118), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 29,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2120), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 30,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2121), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 31,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2123), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 32,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2124), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 33,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2125), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 34,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2127), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 35,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2128), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 36,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2130), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 37,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2131), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 38,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2133), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 39,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2135), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 40,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2136), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 41,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2139), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 42,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2140), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 43,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2141), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 44,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2143), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 45,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2144), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 46,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 47,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2147), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 48,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2149), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 49,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2150), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 50,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2152), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 51,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2154), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 52,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2155), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 53,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2157), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 54,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2158), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 55,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2159), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 56,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2161), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 57,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2162), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 58,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2164), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 59,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2165), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 60,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2167), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 61,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2169), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 62,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2170), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 63,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2172), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 64,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2173), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 65,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 66,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 67,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2177), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 68,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2179), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 69,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2181), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 70,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2183), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 71,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 72,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2187), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 73,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2188), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 74,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2190), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 75,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2191), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 76,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2192), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 77,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 78,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2195), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 79,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2197), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 80,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2198), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 81,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2200), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 82,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2201), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 83,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2207), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 84,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2208), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 85,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2210), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 86,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2211), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 87,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2213), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 88,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2214), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 89,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2216), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 90,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2217), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 91,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2218), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 92,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2220), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 93,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2221), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 94,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2224), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 95,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2225), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 96,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2259), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 97,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2260), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 98,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2262), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 99,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2263), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 100,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2265), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 101,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2266), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 102,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2268), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 103,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2269), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 104,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 105,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2273), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 106,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2275), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 107,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2276), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 108,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2278), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 109,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 110,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2280), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 111,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2282), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 112,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2283), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 113,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2285), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 114,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2286), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 115,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2288), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 116,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 117,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2291), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 118,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2293), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 119,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2294), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 120,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2295), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 121,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2297), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 122,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2298), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 123,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2300), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 124,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2301), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 125,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 126,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2304), new DateTime(2023, 12, 29, 17, 34, 22, 17, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2265), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2277), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 12, 29, 17, 34, 22, 15, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "Spurtree@1234");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "Abhay@1234");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "Bhoomika@1234");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "Pavan@1234");
        }
    }
}
