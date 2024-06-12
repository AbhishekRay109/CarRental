using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ExpenseTracker2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__category__ledger__6477ECF3",
                table: "category");

            migrationBuilder.AlterColumn<int>(
                name: "ledgerId",
                table: "category",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "BudgetLedger",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK__category__ledger__6477ECF3",
                table: "category",
                column: "ledgerId",
                principalTable: "BudgetLedger",
                principalColumn: "ledgerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__category__ledger__6477ECF3",
                table: "category");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "BudgetLedger");

            migrationBuilder.AlterColumn<int>(
                name: "ledgerId",
                table: "category",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2430), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2432), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2434), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2435), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2437), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2439), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2440), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2441), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2443), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2444), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2445), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2447), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1871), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1874), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1877), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1803), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1808), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1811), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1813), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2472), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2475), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2477), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2478), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2288), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2292), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2294), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2295), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2297), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2255), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2256), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1894), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1897), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1898), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1900), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1902), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1903), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1905), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1907), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1908), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1910), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1911), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1913), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 13,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1914), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 14,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1916), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 15,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1919), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 16,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1921), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 17,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1923), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 18,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1924), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 19,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1926), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 20,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1927), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 21,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1930), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 22,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1932), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 23,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1934), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 24,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1935), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 25,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1937), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 26,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1939), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 27,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1940), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 28,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1943), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 29,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1944), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 30,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1946), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 31,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1947), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 32,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1949), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 33,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1951), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 34,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1953), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 35,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1954), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 36,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1956), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 37,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1957), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 38,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1959), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 39,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1960), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 40,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1962), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 41,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1963), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 42,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1965), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 43,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1966), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 44,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1968), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 45,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1969), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 46,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1971), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 47,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1972), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 48,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2009), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 49,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2011), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 50,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2012), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 51,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2014), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 52,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2015), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 53,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2017), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 54,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2019), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 55,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2021), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 56,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2022), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 57,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2024), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 58,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2025), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 59,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2027), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 60,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2029), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 61,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2030), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 62,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2032), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 63,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2033), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 64,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2035), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 65,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2037), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 66,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2038), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 67,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2040), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 68,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2041), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 69,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2043), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 70,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2045), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 71,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2046), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 72,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2047), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 73,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2049), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 74,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2051), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 75,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2052), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 76,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2054), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 77,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2056), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 78,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2057), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 79,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2059), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 80,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2060), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 81,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2062), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 82,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2063), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 83,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2065), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 84,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2066), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 85,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2068), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 86,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2069), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 87,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2075), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 88,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2076), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 89,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2078), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 90,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2079), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 91,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2081), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 92,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2083), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 93,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2084), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 94,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2086), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 95,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2087), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 96,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2089), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 97,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2090), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 98,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2092), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 99,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2094), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 100,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2096), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 101,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2097), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 102,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2099), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 103,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2100), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 104,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2102), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 105,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2103), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 106,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2104), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 107,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2106), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 108,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2108), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 109,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2109), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 110,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2111), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 111,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 112,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2114), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 113,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2116), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 114,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2117), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 115,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2119), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 116,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2120), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 117,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2122), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 118,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2123), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 119,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2125), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 120,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2126), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 121,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2129), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 122,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2130), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 123,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2132), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 124,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2133), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 125,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2135), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 126,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2136), new DateTime(2023, 12, 29, 12, 10, 52, 831, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2248), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2260), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2262), new DateTime(2023, 12, 29, 12, 10, 52, 829, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "Pass@123");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "Pass@123");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "Pass@123");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "Pass@123");

            migrationBuilder.AddForeignKey(
                name: "FK__category__ledger__6477ECF3",
                table: "category",
                column: "ledgerId",
                principalTable: "BudgetLedger",
                principalColumn: "ledgerId");
        }
    }
}
