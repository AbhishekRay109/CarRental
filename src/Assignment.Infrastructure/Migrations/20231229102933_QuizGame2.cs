using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class QuizGame2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuizId",
                table: "QuizQuestions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "QuizAnsweredQuestion",
                columns: table => new
                {
                    QuizAnsweredQuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    QuizScoreScoreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizAnsweredQuestion", x => x.QuizAnsweredQuestionId);
                    table.ForeignKey(
                        name: "FK_QuizAnsweredQuestion_QuizLevels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "QuizLevels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizAnsweredQuestion_QuizQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuizQuestions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizAnsweredQuestion_QuizScores_QuizScoreScoreId",
                        column: x => x.QuizScoreScoreId,
                        principalTable: "QuizScores",
                        principalColumn: "ScoreId");
                    table.ForeignKey(
                        name: "FK_QuizAnsweredQuestion_QuizUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "QuizUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizAnsweredQuestion_Quiz_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quiz",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9018), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9022), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9024), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9025), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9027), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9028), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9030), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9032), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9033), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9035), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9036), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6099), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6102), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "AppUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6104), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6018), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6031), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6033), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "OrganizationUsers",
                keyColumn: "OrgUserId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9067), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9069), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9071), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9072), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8769), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8772), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8782), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8783), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6523), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6525), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6127), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6130), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6132), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 4,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6134), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 5,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6136), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 6,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6138), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 7,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 8,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6141), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 9,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6143), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 10,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6145), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 11,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6146), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 12,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 13,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6149), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 14,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6151), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 15,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6153), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 16,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6154), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 17,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6156), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 18,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6158), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 19,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6159), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 20,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6162), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 21,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6164), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 22,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6166), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 23,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6167), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 24,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6169), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 25,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6170), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 26,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6172), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 27,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6173), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 28,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6175), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 29,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6177), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 30,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6179), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 31,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6180), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 32,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6182), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 33,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6183), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 34,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6185), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 35,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6186), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 36,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6188), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 37,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6248), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 38,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 39,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6252), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 40,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 41,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6255), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 42,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6256), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 43,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 44,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 45,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6261), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 46,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6263), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 47,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6264), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 48,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6266), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 49,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6267), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 50,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6269), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 51,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6271), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 52,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6273), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 53,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6274), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 54,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6276), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 55,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6277), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 56,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6280), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 57,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6281), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 58,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6283), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 59,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6285), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 60,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6286), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 61,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6288), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 62,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6290), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 63,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6291), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 64,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6293), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 65,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6295), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 66,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6296), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 67,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6298), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 68,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6300), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 69,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6301), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 70,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6303), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 71,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6304), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 72,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6306), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 73,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6308), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 74,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6310), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 75,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6311), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 76,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 77,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6314), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 78,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 79,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6318), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 80,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6320), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 81,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6321), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 82,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6323), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 83,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 84,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 85,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6328), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 86,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6330), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 87,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6331), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 88,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6333), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 89,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6334), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 90,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6336), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 91,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6337), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 92,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6339), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 93,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6340), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 94,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6342), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 95,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6344), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 96,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6346), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 97,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6347), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 98,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6349), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 99,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6351), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 100,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6352), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 101,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 102,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 103,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 104,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6359), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 105,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6360), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 106,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6363), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 107,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6364), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 108,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6365), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 109,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6367), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 110,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6369), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 111,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6371), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 112,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6373), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 113,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6374), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 114,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6376), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 115,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6377), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 116,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6379), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 117,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6381), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 118,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6383), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 119,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6384), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 120,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6386), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 121,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6387), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 122,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6389), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 123,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6390), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 124,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6392), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 125,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6393), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "RoleActionPermission",
                keyColumn: "OperationId",
                keyValue: 126,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6397), new DateTime(2023, 12, 29, 15, 59, 32, 444, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8688), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8708), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8711), new DateTime(2023, 12, 29, 15, 59, 32, 441, DateTimeKind.Local).AddTicks(8714) });

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
                name: "IX_QuizQuestions_QuizId",
                table: "QuizQuestions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizAnsweredQuestion_LevelId",
                table: "QuizAnsweredQuestion",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizAnsweredQuestion_QuestionId",
                table: "QuizAnsweredQuestion",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizAnsweredQuestion_QuizId",
                table: "QuizAnsweredQuestion",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizAnsweredQuestion_QuizScoreScoreId",
                table: "QuizAnsweredQuestion",
                column: "QuizScoreScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizAnsweredQuestion_UserId",
                table: "QuizAnsweredQuestion",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizQuestions_Quiz_QuizId",
                table: "QuizQuestions",
                column: "QuizId",
                principalTable: "Quiz",
                principalColumn: "QuizId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuizQuestions_Quiz_QuizId",
                table: "QuizQuestions");

            migrationBuilder.DropTable(
                name: "QuizAnsweredQuestion");

            migrationBuilder.DropIndex(
                name: "IX_QuizQuestions_QuizId",
                table: "QuizQuestions");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "QuizQuestions");

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
        }
    }
}
