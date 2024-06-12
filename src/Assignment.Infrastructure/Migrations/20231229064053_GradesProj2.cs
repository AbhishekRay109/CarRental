using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class GradesProj2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GradeGrade_GradeStudent_Student_ID",
                table: "GradeGrade");

            migrationBuilder.DropForeignKey(
                name: "FK_GradeGrade_GradeSubject_Subject_ID",
                table: "GradeGrade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GradeSubject",
                table: "GradeSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GradeStudent",
                table: "GradeStudent");

            migrationBuilder.DropIndex(
                name: "IX_GradeGrade_Student_ID",
                table: "GradeGrade");

            migrationBuilder.DropIndex(
                name: "IX_GradeGrade_Subject_ID",
                table: "GradeGrade");

            migrationBuilder.DropColumn(
                name: "Subject_ID",
                table: "GradeSubject");

            migrationBuilder.DropColumn(
                name: "Student_ID",
                table: "GradeStudent");

            migrationBuilder.DropColumn(
                name: "Student_ID",
                table: "GradeGrade");

            migrationBuilder.DropColumn(
                name: "Subject_ID",
                table: "GradeGrade");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectCode",
                table: "GradeSubject",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StudentCode",
                table: "GradeStudent",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "GradeGrade",
                type: "int",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "GradeGrade",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubjectCode",
                table: "GradeGrade",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GradeSubject",
                table: "GradeSubject",
                column: "SubjectCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GradeStudent",
                table: "GradeStudent",
                column: "StudentCode");

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

            migrationBuilder.CreateIndex(
                name: "IX_GradeGrade_StudentCode",
                table: "GradeGrade",
                column: "StudentCode");

            migrationBuilder.CreateIndex(
                name: "IX_GradeGrade_SubjectCode",
                table: "GradeGrade",
                column: "SubjectCode");

            migrationBuilder.AddForeignKey(
                name: "FK_GradeGrade_GradeStudent_StudentCode",
                table: "GradeGrade",
                column: "StudentCode",
                principalTable: "GradeStudent",
                principalColumn: "StudentCode");

            migrationBuilder.AddForeignKey(
                name: "FK_GradeGrade_GradeSubject_SubjectCode",
                table: "GradeGrade",
                column: "SubjectCode",
                principalTable: "GradeSubject",
                principalColumn: "SubjectCode",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GradeGrade_GradeStudent_StudentCode",
                table: "GradeGrade");

            migrationBuilder.DropForeignKey(
                name: "FK_GradeGrade_GradeSubject_SubjectCode",
                table: "GradeGrade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GradeSubject",
                table: "GradeSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GradeStudent",
                table: "GradeStudent");

            migrationBuilder.DropIndex(
                name: "IX_GradeGrade_StudentCode",
                table: "GradeGrade");

            migrationBuilder.DropIndex(
                name: "IX_GradeGrade_SubjectCode",
                table: "GradeGrade");

            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "GradeGrade");

            migrationBuilder.DropColumn(
                name: "SubjectCode",
                table: "GradeGrade");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectCode",
                table: "GradeSubject",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Subject_ID",
                table: "GradeSubject",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "StudentCode",
                table: "GradeStudent",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Student_ID",
                table: "GradeStudent",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Score",
                table: "GradeGrade",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<int>(
                name: "Student_ID",
                table: "GradeGrade",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Subject_ID",
                table: "GradeGrade",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GradeSubject",
                table: "GradeSubject",
                column: "Subject_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GradeStudent",
                table: "GradeStudent",
                column: "Student_ID");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4566), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4568), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4570), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4571), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4572), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4574), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4576), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4577), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4579), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4581), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4583), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9734), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9738), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9783), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9663), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9670), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9673), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9675), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4601), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4605), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4429), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4431), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4432), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4435), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4436), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(205), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(207), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9801), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9805), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9806), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9808), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9810), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9812), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9815), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9816), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9818), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9820), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9821), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9823), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 13,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9825), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 14,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9826), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 15,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9828), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 16,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9830), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 17,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9832), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 18,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9834), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 19,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9836), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 20,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9838), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 21,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9840), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 22,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9841), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 23,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9843), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 24,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9845), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 25,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9846), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 26,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9848), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 27,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9850), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 28,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9851), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 29,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9853), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 30,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9859), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 31,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9860), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 32,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9862), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 33,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9864), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 34,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9865), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 35,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9867), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 36,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9869), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 37,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9870), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 38,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9872), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 39,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9874), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 40,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9876), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 41,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9878), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 42,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9880), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 43,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9881), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 44,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9883), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 45,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9885), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 46,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9887), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 47,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9888), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 48,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9890), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 49,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9892), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 50,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9893), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 51,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9895), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 52,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9898), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 53,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9899), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 54,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9901), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 55,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9903), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 56,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9905), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 57,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9906), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 58,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9908), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 59,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9910), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 60,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9911), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 61,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9913), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 62,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9915), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 63,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9917), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 64,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9919), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 65,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9922), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 66,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9923), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 67,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9926), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 68,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9927), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 69,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9929), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 70,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9931), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 71,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9933), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 72,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9935), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 73,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9938), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 74,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9940), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 75,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9941), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 76,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9943), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 77,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9983), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 78,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9985), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 79,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9987), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 80,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9989), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 81,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9991), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 82,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9992), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 83,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9994), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 84,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9996), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 85,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 12, 28, 20, 4, 47, 878, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 86,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 87,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(2), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 88,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(4), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 89,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(5), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 90,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(7), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 91,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(9), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 92,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(11), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 93,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(13), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 94,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(15), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 95,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(17), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 96,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(19), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 97,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(22), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 98,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(24), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 99,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(26), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 100,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(28), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 101,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(30), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 102,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(32), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 103,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(33), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 104,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(35), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 105,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(37), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 106,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(38), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 107,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(41), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 108,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(43), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 109,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(44), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 110,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(46), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 111,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(50), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 112,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(51), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 113,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(53), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 114,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(55), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 115,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(56), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 116,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(58), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 117,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(60), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 118,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(62), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 119,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(64), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 120,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(66), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 121,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(67), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 122,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(69), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 123,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(71), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 124,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(72), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 125,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(74), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 126,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(76), new DateTime(2023, 12, 28, 20, 4, 47, 879, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4392), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4405), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 12, 28, 20, 4, 47, 876, DateTimeKind.Local).AddTicks(4408) });

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

            migrationBuilder.CreateIndex(
                name: "IX_GradeGrade_Student_ID",
                table: "GradeGrade",
                column: "Student_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GradeGrade_Subject_ID",
                table: "GradeGrade",
                column: "Subject_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_GradeGrade_GradeStudent_Student_ID",
                table: "GradeGrade",
                column: "Student_ID",
                principalTable: "GradeStudent",
                principalColumn: "Student_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_GradeGrade_GradeSubject_Subject_ID",
                table: "GradeGrade",
                column: "Subject_ID",
                principalTable: "GradeSubject",
                principalColumn: "Subject_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
