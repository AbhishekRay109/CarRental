using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TaskManager1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskUsers",
                columns: table => new
                {
                    TaskUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskUsers", x => x.TaskUserId);
                });

            migrationBuilder.CreateTable(
                name: "TaskManager",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    TaskUserId = table.Column<int>(type: "int", nullable: false),
                    DependencyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskManager", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_TaskManager_TaskUsers_DependencyId",
                        column: x => x.DependencyId,
                        principalTable: "TaskUsers",
                        principalColumn: "TaskUserId");
                });

            migrationBuilder.CreateTable(
                name: "TaskTag",
                columns: table => new
                {
                    TaskTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    TagName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TaskManagerTaskTaskId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTag", x => x.TaskTagId);
                    table.ForeignKey(
                        name: "FK_TaskTag_TaskManager_TaskManagerTaskTaskId",
                        column: x => x.TaskManagerTaskTaskId,
                        principalTable: "TaskManager",
                        principalColumn: "TaskId");
                });

            migrationBuilder.CreateTable(
                name: "TaskTimeLog",
                columns: table => new
                {
                    TimeLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StopTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    TaskManagerTaskTaskId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTimeLog", x => x.TimeLogId);
                    table.ForeignKey(
                        name: "FK_TaskTimeLog_TaskManager_TaskManagerTaskTaskId",
                        column: x => x.TaskManagerTaskTaskId,
                        principalTable: "TaskManager",
                        principalColumn: "TaskId");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TaskManager_DependencyId",
                table: "TaskManager",
                column: "DependencyId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTag_TaskManagerTaskTaskId",
                table: "TaskTag",
                column: "TaskManagerTaskTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTimeLog_TaskManagerTaskTaskId",
                table: "TaskTimeLog",
                column: "TaskManagerTaskTaskId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskTag");

            migrationBuilder.DropTable(
                name: "TaskTimeLog");

            migrationBuilder.DropTable(
                name: "TaskManager");

            migrationBuilder.DropTable(
                name: "TaskUsers");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7405), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7409), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7411), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7413), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7415), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7416), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7457), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7462), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7464), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7466), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7469), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8934), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8945), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8846), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7502), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7506), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7508), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7511), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7150), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7153), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7155), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7157), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7159), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7161), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9556), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9560), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8975), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8978), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8981), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8984), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8987), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8991), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8994), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8998), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9001), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9003), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 13,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9006), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 14,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9063), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 15,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9065), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 16,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9068), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 17,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9070), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 18,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9073), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 19,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9076), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 20,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9079), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 21,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9081), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 22,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9084), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 23,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9087), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 24,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9089), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 25,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9092), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 26,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9094), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 27,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9097), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 28,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9099), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 29,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9102), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 30,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9109), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 31,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9112), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 32,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9115), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 33,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9117), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 34,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9122), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 35,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9124), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 36,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9126), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 37,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9129), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 38,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9131), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 39,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9134), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 40,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9136), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 41,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9140), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 42,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9142), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 43,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9145), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 44,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9147), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 45,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9150), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 46,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9153), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 47,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9155), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 48,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9158), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 49,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9160), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 50,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9164), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 51,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9167), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 52,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9171), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 53,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9173), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 54,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9176), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 55,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9178), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 56,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9181), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 57,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9184), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 58,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9186), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 59,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9189), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 60,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9191), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 61,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9194), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 62,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9196), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 63,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9199), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 64,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9201), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 65,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9204), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 66,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9206), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 67,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9209), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 68,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9211), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 69,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9215), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 70,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9217), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 71,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9219), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 72,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9222), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 73,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9225), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 74,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9228), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 75,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9231), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 76,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9233), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 77,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9235), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 78,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9239), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 79,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9243), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 80,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9247), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 81,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9250), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 82,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9252), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 83,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9255), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 84,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9260), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 85,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9264), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 86,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9267), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 87,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9270), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 88,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9272), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 89,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9274), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 90,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9277), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 91,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9280), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 92,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9282), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 93,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9284), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 94,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9287), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 95,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9289), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 96,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9293), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 97,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9295), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 98,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9297), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 99,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9300), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 100,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9302), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 101,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9305), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 102,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9307), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 103,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9311), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 104,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9313), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 105,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9316), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 106,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9318), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 107,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9370), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 108,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9373), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 109,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9376), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 110,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9379), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 111,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9381), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 112,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9384), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 113,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9387), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 114,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9391), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 115,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9393), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 116,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9396), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 117,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9398), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 118,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9402), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 119,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9404), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 120,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9407), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 121,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9409), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 122,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9412), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 123,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9415), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 124,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9417), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 125,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9421), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 126,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9424), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7092), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7113), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7115), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7116) });
        }
    }
}
