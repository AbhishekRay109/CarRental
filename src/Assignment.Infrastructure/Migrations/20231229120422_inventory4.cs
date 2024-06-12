using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class inventory4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Amount",
                table: "InOrderDetails",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

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

            migrationBuilder.InsertData(
                table: "InProviders",
                columns: new[] { "ProviderId", "ProviderAddress", "ProviderName" },
                values: new object[,]
                {
                    { 1, "Address A", "Provider A" },
                    { 2, "Address B", "Provider B" },
                    { 3, "Address C", "Provider C" },
                    { 4, "Address D", "Provider D" },
                    { 5, "Address E", "Provider E" },
                    { 6, "Address F", "Provider F" },
                    { 7, "Address G", "Provider G" },
                    { 8, "Address H", "Provider H" },
                    { 9, "Address I", "Provider I" },
                    { 10, "Address J", "Provider J" }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InProviders",
                keyColumn: "ProviderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InProviders",
                keyColumn: "ProviderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InProviders",
                keyColumn: "ProviderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InProviders",
                keyColumn: "ProviderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InProviders",
                keyColumn: "ProviderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InProviders",
                keyColumn: "ProviderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InProviders",
                keyColumn: "ProviderId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "InProviders",
                keyColumn: "ProviderId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "InProviders",
                keyColumn: "ProviderId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "InProviders",
                keyColumn: "ProviderId",
                keyValue: 10);

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "InOrderDetails",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2686), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2689), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2692), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2702), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2704), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2706), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2710), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2712), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7052), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7057), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7061), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(6951), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(6963), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(6966), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(6970), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2748), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2752), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2755), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2757), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2422), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2426), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2428), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2430), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2432), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2434), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7714), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7717), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7092), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7097), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7099), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7103), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7106), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7109), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7112), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7116), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7119), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7189), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7193), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7196), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 13,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7198), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 14,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7201), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 15,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7204), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 16,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7206), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 17,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7209), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 18,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7212), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 19,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7214), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 20,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7217), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 21,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7223), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 22,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7226), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 23,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7229), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 24,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7231), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 25,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7234), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 26,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7237), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 27,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7239), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 28,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7242), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 29,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7245), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 30,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7247), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 31,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7250), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 32,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7254), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 33,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7256), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 34,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7259), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 35,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7262), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 36,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7264), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 37,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7267), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 38,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7269), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 39,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7272), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 40,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7275), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 41,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7277), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 42,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7280), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 43,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7283), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 44,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7286), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 45,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7289), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 46,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7292), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 47,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7294), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 48,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 49,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7300), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 50,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7302), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 51,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7305), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 52,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7308), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 53,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7310), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 54,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7313), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 55,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7317), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 56,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7319), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 57,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7322), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 58,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7325), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 59,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7327), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 60,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7330), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 61,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7333), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 62,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7335), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 63,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7338), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 64,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7340), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 65,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7343), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 66,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7347), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 67,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7350), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 68,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7352), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 69,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7355), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 70,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 71,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7360), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 72,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7364), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 73,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7366), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 74,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7369), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 75,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7372), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 76,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7374), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 77,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7378), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 78,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7381), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 79,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7384), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 80,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7386), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 81,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7390), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 82,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7392), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 83,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7395), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 84,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7398), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 85,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7400), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 86,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7403), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 87,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7405), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 88,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7409), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 89,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7412), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 90,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7415), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 91,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7417), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 92,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 93,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7422), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 94,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7425), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 95,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7427), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 96,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7430), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 97,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7433), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 98,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7436), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 99,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7439), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 100,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7442), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 101,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7444), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 102,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7447), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 103,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7507), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 104,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7511), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 105,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7513), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 106,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7516), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 107,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7518), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 108,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7521), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 109,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7524), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 110,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7528), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 111,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7530), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 112,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7533), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 113,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7536), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 114,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7539), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 115,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7541), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 116,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7544), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 117,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7546), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 118,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7549), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 119,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7552), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 120,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7554), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 121,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7558), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 122,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7561), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 123,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7564), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 124,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7567), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 125,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7569), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 126,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7572), new DateTime(2023, 12, 29, 15, 49, 23, 693, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2382), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2385), new DateTime(2023, 12, 29, 15, 49, 23, 690, DateTimeKind.Local).AddTicks(2386) });
        }
    }
}
