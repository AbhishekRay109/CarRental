using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AllTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    ActionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.ActionId);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    AuthorBio = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Authors__70DAFC141A2742D8", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Blog_Subscription",
                columns: table => new
                {
                    SubscriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubscriptionLimit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Blog_Sub__9A2B24BD2DD349F1", x => x.SubscriptionID);
                });

            migrationBuilder.CreateTable(
                name: "Blog_Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsAuthor = table.Column<bool>(type: "bit", nullable: false),
                    Subscription_Type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NumberOfPostAvailable = table.Column<int>(type: "int", nullable: false),
                    NumberOfPostRemaining = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Blog_Use__1788CCACC7675079", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "BookUsers",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Role = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__1788CCAC1BED877E", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "CarRental_Cars",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RentalRatePerDay = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: true),
                    LastMaintenanceDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsUnderMaintenance = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CarRenta__68A0340EBDB30A5A", x => x.CarID);
                });

            migrationBuilder.CreateTable(
                name: "CarRental_Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsPremiumCustomer = table.Column<bool>(type: "bit", nullable: true),
                    MembershipExpiration = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CarRenta__A4AE64B83328061C", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "EventRegistrationUsers",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    otp = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    IsOrganizer = table.Column<bool>(type: "bit", nullable: false),
                    IsEmailVerified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRegistrationUsers", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseUsers",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userCode = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true, computedColumnSql: "(('USER'+replicate('0',(5)-len([userId])))+CONVERT([varchar](5),[userId]))", stored: true),
                    name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    phone = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__CB9A1CFF793E5508", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "GradeSubject",
                columns: table => new
                {
                    Subject_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeSubject", x => x.Subject_ID);
                });

            migrationBuilder.CreateTable(
                name: "GradeTeacher",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teacher_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeTeacher", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "InCategory",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InCategory", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "InProviders",
                columns: table => new
                {
                    ProviderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ProviderAddress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InProviders", x => x.ProviderId);
                });

            migrationBuilder.CreateTable(
                name: "InWarehouses",
                columns: table => new
                {
                    WarehouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InWarehouses", x => x.WarehouseId);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OrganizationEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OrganizationPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    CreatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "QuizLevels",
                columns: table => new
                {
                    LevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    QuizType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuizLeve__09F03C269EE1AA23", x => x.LevelId);
                });

            migrationBuilder.CreateTable(
                name: "QuizUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuizUser__1788CC4C7FFE809B", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "RecipeChefs",
                columns: table => new
                {
                    ChefId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChefName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeChefs", x => x.ChefId);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cuisine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Steps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: true),
                    Genre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ISBN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Availability = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Books__3DE0C227BF9B6851", x => x.BookID);
                    table.ForeignKey(
                        name: "FK__Books__AuthorID__398D8EEE",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "AuthorID");
                });

            migrationBuilder.CreateTable(
                name: "Blog_Posts",
                columns: table => new
                {
                    PostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImageMimeType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Blog_Pos__AA1260387789040E", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_Blog_Posts_Blog_Users_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Blog_Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarRental_Images",
                columns: table => new
                {
                    ImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CarRenta__7516F4ECDBED5D35", x => x.ImageID);
                    table.ForeignKey(
                        name: "FK__CarRental__CarID__55F4C372",
                        column: x => x.CarID,
                        principalTable: "CarRental_Cars",
                        principalColumn: "CarID");
                });

            migrationBuilder.CreateTable(
                name: "CarRental_Bookings",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true),
                    TotalCost = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsApprovedByAdmin = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CarRenta__73951ACDA7E24354", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK__CarRental__CarID__5224328E",
                        column: x => x.CarID,
                        principalTable: "CarRental_Cars",
                        principalColumn: "CarID");
                    table.ForeignKey(
                        name: "FK__CarRental__Custo__531856C7",
                        column: x => x.CustomerID,
                        principalTable: "CarRental_Customers",
                        principalColumn: "CustomerID");
                });

            migrationBuilder.CreateTable(
                name: "EventRegistrationOrganizer",
                columns: table => new
                {
                    OrganizerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    OrganizerInfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRegistrationOrganizer", x => x.OrganizerID);
                    table.ForeignKey(
                        name: "FK_EventRegistrationOrganizer_EventRegistrationUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "EventRegistrationUsers",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BudgetLedger",
                columns: table => new
                {
                    ledgerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ledgerCode = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true, computedColumnSql: "(('BL'+replicate('0',(5)-len([ledgerId])))+CONVERT([varchar],[ledgerId]))", stored: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amount = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BudgetLe__298DF4D5696FF6BF", x => x.ledgerId);
                    table.ForeignKey(
                        name: "FK__BudgetLed__userI__619B8048",
                        column: x => x.userId,
                        principalTable: "ExpenseUsers",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "GradeClass",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Teacher_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeClass", x => x.ClassId);
                    table.UniqueConstraint("AK_GradeClass_Class", x => x.Class);
                    table.ForeignKey(
                        name: "FK_GradeClass_GradeTeacher_Teacher_ID",
                        column: x => x.Teacher_ID,
                        principalTable: "GradeTeacher",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InInventoryProducts",
                columns: table => new
                {
                    InProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductCategory = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InInventoryProducts", x => x.InProductID);
                    table.ForeignKey(
                        name: "FK_InInventoryProducts_InCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "InCategory",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InInventoryProducts_InWarehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "InWarehouses",
                        principalColumn: "WarehouseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InLocations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LocationAddress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WarehouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InLocations", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_InLocations_InWarehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "InWarehouses",
                        principalColumn: "WarehouseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AppCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientSecret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Applications_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuizCate__19093A0B787E379B", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK__QuizCateg__Level__58D1301D",
                        column: x => x.LevelId,
                        principalTable: "QuizLevels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeChefMapping",
                columns: table => new
                {
                    ChefId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeChefMapping", x => new { x.ChefId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_RecipeChefMapping_RecipeChefs_ChefId",
                        column: x => x.ChefId,
                        principalTable: "RecipeChefs",
                        principalColumn: "ChefId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeChefMapping_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleActionPermission",
                columns: table => new
                {
                    OperationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleActionPermission", x => x.OperationId);
                    table.ForeignKey(
                        name: "FK_RoleActionPermission_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "ActionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleActionPermission_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleActionPermission_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GoogleSignIn",
                columns: table => new
                {
                    GoogleSignInId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SigninEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    HasAcceptedInvite = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoogleSignIn", x => x.GoogleSignInId);
                    table.ForeignKey(
                        name: "FK_GoogleSignIn_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationUsers",
                columns: table => new
                {
                    OrgUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    Orgcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationUsers", x => x.OrgUserId);
                    table.ForeignKey(
                        name: "FK_OrganizationUsers_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizationUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowedBooks",
                columns: table => new
                {
                    BorrowID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    BookID = table.Column<int>(type: "int", nullable: true),
                    BorrowDate = table.Column<DateTime>(type: "date", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Borrowed__4295F85F598F0F44", x => x.BorrowID);
                    table.ForeignKey(
                        name: "FK__BorrowedB__BookI__3F466844",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID");
                    table.ForeignKey(
                        name: "FK__BorrowedB__UserI__3E52440B",
                        column: x => x.UserID,
                        principalTable: "BookUsers",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Blog_Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostID = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Blog_Com__C3B4DFAA6558CCA9", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Blog_Comments_Blog_Posts_PostID",
                        column: x => x.PostID,
                        principalTable: "Blog_Posts",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blog_Comments_Blog_Users_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Blog_Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventRegistrationEvent",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizerID = table.Column<int>(type: "int", nullable: false),
                    EventCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeInterval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Venue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosterImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRegistrationEvent", x => x.EventID);
                    table.ForeignKey(
                        name: "FK_EventRegistrationEvent_EventRegistrationOrganizer_OrganizerID",
                        column: x => x.OrganizerID,
                        principalTable: "EventRegistrationOrganizer",
                        principalColumn: "OrganizerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amount = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ledgerId = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__category__23CAF1D8D15756DD", x => x.categoryId);
                    table.ForeignKey(
                        name: "FK__category__ledger__6477ECF3",
                        column: x => x.ledgerId,
                        principalTable: "BudgetLedger",
                        principalColumn: "ledgerId");
                });

            migrationBuilder.CreateTable(
                name: "GradeStudent",
                columns: table => new
                {
                    Student_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Student_Fname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Student_Lname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DOB = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Class = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeStudent", x => x.Student_ID);
                    table.ForeignKey(
                        name: "FK_GradeStudent_GradeClass_Class",
                        column: x => x.Class,
                        principalTable: "GradeClass",
                        principalColumn: "Class",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InInventory",
                columns: table => new
                {
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantityAvailable = table.Column<int>(type: "int", nullable: false),
                    MinStockLevel = table.Column<int>(type: "int", nullable: false),
                    MaxStockLevel = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    InProductID = table.Column<int>(type: "int", nullable: false),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    WareHouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InInventory", x => x.InventoryId);
                    table.ForeignKey(
                        name: "FK_InInventory_InInventoryProducts_InProductID",
                        column: x => x.InProductID,
                        principalTable: "InInventoryProducts",
                        principalColumn: "InProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InInventory_InProviders_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "InProviders",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InInventory_InWarehouses_WareHouseId",
                        column: x => x.WareHouseId,
                        principalTable: "InWarehouses",
                        principalColumn: "WarehouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InOrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderQuantity = table.Column<int>(type: "int", nullable: false),
                    ExpectedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    InProductID = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InOrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_InOrderDetails_InCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "InCategory",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InOrderDetails_InInventoryProducts_InProductID",
                        column: x => x.InProductID,
                        principalTable: "InInventoryProducts",
                        principalColumn: "InProductID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InOrderDetails_InProviders_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "InProviders",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AllowedDomains",
                columns: table => new
                {
                    AllowedDomainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Domain = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    ApplicationId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowedDomains", x => x.AllowedDomainId);
                    table.ForeignKey(
                        name: "FK_AllowedDomains_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_AllowedDomains_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    Orgcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    AppCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.AppUserId);
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId");
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsApplications",
                columns: table => new
                {
                    ProductAppId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsApplications", x => x.ProductAppId);
                    table.ForeignKey(
                        name: "FK_ProductsApplications_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsApplications_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    ApplicationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_UserRoles_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    NumberOfQuestions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.QuizId);
                    table.ForeignKey(
                        name: "FK_Quiz_QuizCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "QuizCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quiz_QuizLevels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "QuizLevels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizQuestions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuizQues__0DC06FACA59EE87C", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK__QuizQuest__Categ__5BAD9CC8",
                        column: x => x.CategoryId,
                        principalTable: "QuizCategories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "EventRegistration",
                columns: table => new
                {
                    RegistrationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRegistration", x => x.RegistrationID);
                    table.ForeignKey(
                        name: "FK_EventRegistration_EventRegistrationEvent_UserID",
                        column: x => x.UserID,
                        principalTable: "EventRegistrationEvent",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventRegistration_EventRegistrationUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "EventRegistrationUsers",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "expense",
                columns: table => new
                {
                    expenseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    categoryId = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    image = table.Column<byte[]>(type: "image", nullable: true),
                    amount = table.Column<decimal>(type: "decimal(8,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__expense__3672732E40DEC0D3", x => x.expenseId);
                    table.ForeignKey(
                        name: "FK__expense__amount__6754599E",
                        column: x => x.categoryId,
                        principalTable: "category",
                        principalColumn: "categoryId");
                });

            migrationBuilder.CreateTable(
                name: "GradeGrade",
                columns: table => new
                {
                    Grade_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_ID = table.Column<int>(type: "int", nullable: false),
                    Subject_ID = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Grade_Letter = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeGrade", x => x.Grade_ID);
                    table.ForeignKey(
                        name: "FK_GradeGrade_GradeStudent_Student_ID",
                        column: x => x.Student_ID,
                        principalTable: "GradeStudent",
                        principalColumn: "Student_ID");
                    table.ForeignKey(
                        name: "FK_GradeGrade_GradeSubject_Subject_ID",
                        column: x => x.Subject_ID,
                        principalTable: "GradeSubject",
                        principalColumn: "Subject_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InInventoryWarehouseMappings",
                columns: table => new
                {
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WareHouseId = table.Column<int>(type: "int", nullable: false),
                    InInventoryInventoryId = table.Column<int>(type: "int", nullable: true),
                    InWarehouseWarehouseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InInventoryWarehouseMappings", x => x.InventoryId);
                    table.ForeignKey(
                        name: "FK_InInventoryWarehouseMappings_InInventory_InInventoryInventoryId",
                        column: x => x.InInventoryInventoryId,
                        principalTable: "InInventory",
                        principalColumn: "InventoryId");
                    table.ForeignKey(
                        name: "FK_InInventoryWarehouseMappings_InWarehouses_InWarehouseWarehouseId",
                        column: x => x.InWarehouseWarehouseId,
                        principalTable: "InWarehouses",
                        principalColumn: "WarehouseId");
                });

            migrationBuilder.CreateTable(
                name: "InUserInventoryMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InUserInventoryMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InUserInventoryMapping_InInventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "InInventory",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InUserInventoryMapping_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuizScores",
                columns: table => new
                {
                    ScoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    QuizId = table.Column<int>(type: "int", nullable: true),
                    LevelId = table.Column<int>(type: "int", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuizScor__7DD229D1A7C5F9C3", x => x.ScoreId);
                    table.ForeignKey(
                        name: "FK__QuizScore__Level__681373AD",
                        column: x => x.LevelId,
                        principalTable: "QuizLevels",
                        principalColumn: "LevelId");
                    table.ForeignKey(
                        name: "FK__QuizScore__QuizI__671F4F74",
                        column: x => x.QuizId,
                        principalTable: "Quiz",
                        principalColumn: "QuizId");
                    table.ForeignKey(
                        name: "FK__QuizScore__UserI__662B2B3B",
                        column: x => x.UserId,
                        principalTable: "QuizUsers",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "QuizAnswers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuizAnsw__D4825004917C4A47", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK__QuizAnswe__Quest__5E8A0973",
                        column: x => x.QuestionId,
                        principalTable: "QuizQuestions",
                        principalColumn: "QuestionId");
                });

            migrationBuilder.CreateTable(
                name: "EventRegistrationPass",
                columns: table => new
                {
                    PassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationID = table.Column<int>(type: "int", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRegistrationPass", x => x.PassID);
                    table.ForeignKey(
                        name: "FK_EventRegistrationPass_EventRegistration_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "EventRegistration",
                        principalColumn: "RegistrationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "ActionId", "ActionName", "CreatedTimestamp", "ModifiedTimestamp" },
                values: new object[,]
                {
                    { 1, "raiden-settings", new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7405), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7408) },
                    { 2, "orgsetting", new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7409), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7410) },
                    { 3, "appsetting", new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7411), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7412) },
                    { 4, "user", new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7413), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7413) },
                    { 5, "org-notification-setting", new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7415), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7415) },
                    { 6, "app-notification-setting", new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7416), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7434) },
                    { 7, "org-auditlog-setting", new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7457), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7458) },
                    { 8, "app-auditlog-setting", new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7461) },
                    { 9, "email-event", new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7462), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7463) },
                    { 10, "auditlog-event", new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7464), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7465) },
                    { 11, "emailtemplate", new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7466), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7467) },
                    { 12, "auditlog", new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7469), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7470) }
                });

            migrationBuilder.InsertData(
                table: "AllowedDomains",
                columns: new[] { "AllowedDomainId", "ApplicationId", "Domain", "IsActive", "OrganizationId" },
                values: new object[,]
                {
                    { 1, null, "spurtreetech.com", true, null },
                    { 2, null, "spurtreetech.in", true, null }
                });

            migrationBuilder.InsertData(
                table: "InCategory",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Clothing" },
                    { 3, "Home and Kitchen" },
                    { 4, "Books" },
                    { 5, "Diary" }
                });

            migrationBuilder.InsertData(
                table: "InWarehouses",
                columns: new[] { "WarehouseId", "WarehouseName" },
                values: new object[,]
                {
                    { 1, "Warehouse A" },
                    { 2, "Warehouse B" },
                    { 3, "Warehouse C" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationId", "CreatedTimestamp", "IsActive", "ModifiedTimestamp", "OrgCode", "OrganizationEmail", "OrganizationName", "OrganizationPhone" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7502), true, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7503), "CD01", "orgA@example.com", "Organization A", "1234567890" },
                    { 2, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7506), true, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7507), "AB01", "orgB@example.com", "Organization B", "9876543210" },
                    { 3, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7508), true, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7509), "DC02", "orgC@example.com", "Organization C", "5555555555" },
                    { 8, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7511), true, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7511), "STT01", "spurtree2023@gmail.com", "Spurtree", "5555555555" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionId", "CreatedTimestamp", "ModifiedTimestamp", "PermissionName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7150), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7151), "view" },
                    { 2, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7153), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7154), "create" },
                    { 3, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7155), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7156), "edit" },
                    { 4, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7157), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7158), "delete" },
                    { 5, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7159), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7160), "enable" },
                    { 6, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7161), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7162), "disable" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CreatedTimestamp", "ModifiedTimestamp", "ProductName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9556), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9558), "KITANA" },
                    { 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9560), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9560), "CYRAX" }
                });

            migrationBuilder.InsertData(
                table: "QuizLevels",
                columns: new[] { "LevelId", "Name", "QuizType" },
                values: new object[,]
                {
                    { 1, "Beginner", "MCQ" },
                    { 2, "Pro", "Typing" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedTimestamp", "ModifiedTimestamp", "RoleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7092), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7111), "SuperAdmin" },
                    { 2, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7113), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7114), "OrgAdmin" },
                    { 3, new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7115), new DateTime(2023, 12, 28, 19, 24, 25, 828, DateTimeKind.Local).AddTicks(7116), "AppAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "IsActive", "LastName", "Password", "RefreshToken", "TokenExpiryTime" },
                values: new object[,]
                {
                    { 1, "Spurtree@example.com", "Spurtree", true, null, "Spurtree@1234", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Abhay@example.com", "Abhay", true, null, "Abhay@1234", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Bhoomi@example.com", "Bhoomi", true, null, "Bhoomika@1234", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "pavan.m@spurtreetech.com", "pavan", true, null, "Pavan@1234", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "ApplicationId", "AppCode", "ApplicationEmail", "ApplicationName", "ClientId", "ClientSecret", "Description", "FirstName", "IsActive", "LastName", "OrganizationId", "Phone" },
                values: new object[,]
                {
                    { 1, "BD420", null, "BIRA", "8ff708940da64155a374154518d0191e", "aWwseuUhomz5zlyJB6HfSqPKCAEoRP2erOGhM2lUNzA=", null, "Tony", true, "Stark", 1, "07601012345" },
                    { 2, "JD420", null, "JACK DANIALS", "8ff708940da64155a374154518d0000e", "aWwseuUhomz5zlyJB6HfSqPKCAEoRP2erOGhM2lUccc=", null, "JACK", true, "SPARROW", 3, "1800208663" },
                    { 8, "Cyrax01", "stlabmse@gmail.com", "CYRAX", "23ec653fa43f44f58f1e4ece3b673685", "A8zvcp1ZkNJk4Sy1dzFkULSvYIGOPCFYdLFA4XbD4Ig=", "Send notifications", "Cyrax", true, "Service", 8, "0987654321" },
                    { 9, "Kitana01", "kitana.dev@gmail.com", "KITANA", "bece4d5ec6bf40bba0396c732c47fd30", "G9CCFOuRCsOSvQswI4bpgiiht8lIANEtqsQVrEytXQY=", "Audit Logging", "Kitana", true, "Service", 8, "0987654321" },
                    { 10, "Raiden01", "raidendev08@gmail.com", "RAIDEN", "4ef085f15f1d488288d22645aeb62ab8", "mk0BTaz5vuzfuicAgoGZ147GjVPVcDbYKdxpNs4nLpE=", "Centralised authorization and authentication", "Raiden", true, "Service", 8, "9035402732" }
                });

            migrationBuilder.InsertData(
                table: "OrganizationUsers",
                columns: new[] { "OrgUserId", "CreatedTimestamp", "IsActive", "ModifiedTimestamp", "OrganizationId", "Orgcode", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8836), true, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8843), 1, "CD01", 1 },
                    { 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8846), true, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8847), 1, "CD01", 2 },
                    { 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8849), true, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8850), 2, "AB01", 2 },
                    { 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8852), true, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8853), 8, "STT01", 4 }
                });

            migrationBuilder.InsertData(
                table: "RoleActionPermission",
                columns: new[] { "OperationId", "ActionId", "CreatedTimestamp", "ModifiedTimestamp", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8972), 1, 1 },
                    { 2, 1, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8975), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8976), 2, 1 },
                    { 3, 1, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8978), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8979), 3, 1 },
                    { 4, 1, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8981), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8982), 4, 1 },
                    { 5, 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8984), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8986), 1, 1 },
                    { 6, 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8987), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8988), 2, 1 },
                    { 7, 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8991), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8992), 3, 1 },
                    { 8, 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8994), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8994), 4, 1 },
                    { 9, 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8997), 5, 1 },
                    { 10, 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8998), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8999), 6, 1 },
                    { 11, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9001), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9002), 1, 1 },
                    { 12, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9003), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9004), 2, 1 },
                    { 13, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9006), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9007), 3, 1 },
                    { 14, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9063), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9064), 4, 1 },
                    { 15, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9065), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9066), 5, 1 },
                    { 16, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9068), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9069), 6, 1 },
                    { 17, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9070), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9071), 1, 1 },
                    { 18, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9073), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9075), 2, 1 },
                    { 19, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9076), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9077), 3, 1 },
                    { 20, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9079), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9080), 4, 1 },
                    { 21, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9081), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9082), 5, 1 },
                    { 22, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9084), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9085), 6, 1 },
                    { 23, 5, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9087), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9087), 1, 1 },
                    { 24, 5, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9089), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9090), 2, 1 },
                    { 25, 5, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9092), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9093), 3, 1 },
                    { 26, 5, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9094), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9095), 4, 1 },
                    { 27, 6, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9097), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9098), 1, 1 },
                    { 28, 6, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9099), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9100), 2, 1 },
                    { 29, 6, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9102), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9107), 3, 1 },
                    { 30, 6, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9109), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9110), 4, 1 },
                    { 31, 7, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9112), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9112), 1, 1 },
                    { 32, 7, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9115), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9116), 2, 1 },
                    { 33, 7, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9117), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9119), 3, 1 },
                    { 34, 7, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9122), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9122), 4, 1 },
                    { 35, 8, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9124), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9125), 1, 1 },
                    { 36, 8, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9126), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9127), 2, 1 },
                    { 37, 8, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9129), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9130), 3, 1 },
                    { 38, 8, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9131), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9132), 4, 1 },
                    { 39, 9, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9134), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9134), 1, 1 },
                    { 40, 9, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9136), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9137), 2, 1 },
                    { 41, 9, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9140), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9141), 3, 1 },
                    { 42, 9, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9142), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9143), 4, 1 },
                    { 43, 10, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9145), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9146), 1, 1 },
                    { 44, 10, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9147), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9148), 2, 1 },
                    { 45, 10, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9150), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9151), 3, 1 },
                    { 46, 10, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9153), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9153), 4, 1 },
                    { 47, 11, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9155), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9156), 1, 1 },
                    { 48, 11, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9158), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9158), 2, 1 },
                    { 49, 11, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9160), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9161), 3, 1 },
                    { 50, 11, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9164), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9164), 4, 1 },
                    { 51, 12, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9167), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9168), 1, 1 },
                    { 52, 1, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9171), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9171), 1, 2 },
                    { 53, 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9173), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9174), 1, 2 },
                    { 54, 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9176), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9177), 2, 2 },
                    { 55, 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9178), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9179), 3, 2 },
                    { 56, 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9181), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9181), 4, 2 },
                    { 57, 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9184), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9185), 5, 2 },
                    { 58, 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9186), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9187), 6, 2 },
                    { 59, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9189), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9190), 1, 2 },
                    { 60, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9191), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9192), 2, 2 },
                    { 61, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9194), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9195), 3, 2 },
                    { 62, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9196), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9197), 4, 2 },
                    { 63, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9199), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9200), 5, 2 },
                    { 64, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9201), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9202), 6, 2 },
                    { 65, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9204), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9205), 1, 2 },
                    { 66, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9206), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9207), 2, 2 },
                    { 67, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9209), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9209), 3, 2 },
                    { 68, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9211), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9213), 4, 2 },
                    { 69, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9215), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9215), 5, 2 },
                    { 70, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9217), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9218), 6, 2 },
                    { 71, 5, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9219), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9220), 1, 2 },
                    { 72, 5, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9222), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9223), 2, 2 },
                    { 73, 5, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9225), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9225), 3, 2 },
                    { 74, 5, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9228), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9229), 4, 2 },
                    { 75, 6, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9231), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9231), 1, 2 },
                    { 76, 6, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9233), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9234), 2, 2 },
                    { 77, 6, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9235), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9236), 3, 2 },
                    { 78, 6, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9239), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9240), 4, 2 },
                    { 79, 7, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9243), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9245), 1, 2 },
                    { 80, 7, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9247), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9248), 2, 2 },
                    { 81, 7, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9250), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9251), 3, 2 },
                    { 82, 7, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9252), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9253), 4, 2 },
                    { 83, 8, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9255), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9255), 1, 2 },
                    { 84, 8, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9260), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9261), 2, 2 },
                    { 85, 8, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9264), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9266), 3, 2 },
                    { 86, 8, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9267), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9268), 4, 2 },
                    { 87, 9, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9270), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9270), 1, 2 },
                    { 88, 9, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9272), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9273), 2, 2 },
                    { 89, 9, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9274), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9275), 3, 2 },
                    { 90, 9, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9277), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9278), 4, 2 },
                    { 91, 10, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9280), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9280), 1, 2 },
                    { 92, 10, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9282), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9283), 2, 2 },
                    { 93, 10, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9284), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9285), 3, 2 },
                    { 94, 10, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9287), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9288), 4, 2 },
                    { 95, 11, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9289), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9290), 1, 2 },
                    { 96, 11, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9293), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9293), 2, 2 },
                    { 97, 11, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9295), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9296), 3, 2 },
                    { 98, 11, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9297), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9298), 4, 2 },
                    { 99, 12, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9300), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9301), 1, 2 },
                    { 100, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9302), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9303), 1, 3 },
                    { 101, 3, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9305), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9306), 3, 3 },
                    { 102, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9307), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9308), 1, 3 },
                    { 103, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9311), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9311), 2, 3 },
                    { 104, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9313), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9314), 3, 3 },
                    { 105, 4, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9316), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9317), 4, 3 },
                    { 106, 6, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9318), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9319), 1, 3 },
                    { 107, 6, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9370), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9371), 2, 3 },
                    { 108, 6, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9373), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9374), 3, 3 },
                    { 109, 6, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9376), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9377), 4, 3 },
                    { 110, 8, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9379), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9379), 1, 3 },
                    { 111, 8, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9381), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9382), 2, 3 },
                    { 112, 8, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9384), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9385), 3, 3 },
                    { 113, 8, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9387), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9388), 4, 3 },
                    { 114, 9, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9391), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9392), 1, 3 },
                    { 115, 9, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9393), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9394), 2, 3 },
                    { 116, 9, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9396), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9396), 3, 3 },
                    { 117, 9, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9398), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9399), 4, 3 },
                    { 118, 10, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9402), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9402), 1, 3 },
                    { 119, 10, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9404), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9405), 2, 3 },
                    { 120, 10, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9407), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9407), 3, 3 },
                    { 121, 10, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9409), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9410), 4, 3 },
                    { 122, 11, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9412), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9413), 1, 3 },
                    { 123, 11, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9415), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9415), 2, 3 },
                    { 124, 11, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9417), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9419), 3, 3 },
                    { 125, 11, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9421), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9421), 4, 3 },
                    { 126, 12, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9424), new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(9425), 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleId", "ApplicationId", "OrganizationId", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, 1, 1 },
                    { 2, null, 1, 2, 2 },
                    { 5, null, 2, 2, 2 },
                    { 6, null, 2, 3, 3 },
                    { 7, null, 8, 2, 4 },
                    { 8, null, null, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "AppUserId", "AppCode", "ApplicationId", "CreatedTimestamp", "IsActive", "ModifiedTimestamp", "OrganizationId", "Orgcode", "UserId" },
                values: new object[,]
                {
                    { 1, "BD420", 1, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8934), true, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8936), 1, "CD01", 3 },
                    { 2, "JD420", 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8940), true, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8941), 3, "DC02", 2 },
                    { 3, "JD420", 2, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8945), true, new DateTime(2023, 12, 28, 19, 24, 25, 831, DateTimeKind.Local).AddTicks(8946), 3, "DC01", 3 }
                });

            migrationBuilder.InsertData(
                table: "ProductsApplications",
                columns: new[] { "ProductAppId", "ApplicationId", "IsEnabled", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, true, 1 },
                    { 2, 1, true, 2 },
                    { 3, 2, true, 1 },
                    { 4, 2, true, 2 },
                    { 5, 8, true, 1 },
                    { 6, 8, true, 2 },
                    { 7, 9, true, 1 },
                    { 8, 9, true, 2 },
                    { 9, 10, true, 1 },
                    { 10, 10, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleId", "ApplicationId", "OrganizationId", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 3, 2, 3, 3, 2 },
                    { 4, 1, 1, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllowedDomains_ApplicationId",
                table: "AllowedDomains",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_AllowedDomains_OrganizationId",
                table: "AllowedDomains",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_OrganizationId",
                table: "Applications",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_ApplicationId",
                table: "ApplicationUsers",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_OrganizationId",
                table: "ApplicationUsers",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_UserId",
                table: "ApplicationUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_Comments_AuthorID",
                table: "Blog_Comments",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_Comments_PostID",
                table: "Blog_Comments",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_Posts_AuthorID",
                table: "Blog_Posts",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "UQ__Blog_Use__536C85E4D316E809",
                table: "Blog_Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Blog_Use__A9D10534FDFECB16",
                table: "Blog_Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorID",
                table: "Books",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_BookID",
                table: "BorrowedBooks",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_UserID",
                table: "BorrowedBooks",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetLedger_ledgerCode",
                table: "BudgetLedger",
                column: "ledgerCode");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetLedger_userId",
                table: "BudgetLedger",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_CarRental_Bookings_CarID",
                table: "CarRental_Bookings",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_CarRental_Bookings_CustomerID",
                table: "CarRental_Bookings",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CarRental_Images_CarID",
                table: "CarRental_Images",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_category_ledgerId",
                table: "category",
                column: "ledgerId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistration_UserID",
                table: "EventRegistration",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistrationEvent_OrganizerID",
                table: "EventRegistrationEvent",
                column: "OrganizerID");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistrationOrganizer_UserID",
                table: "EventRegistrationOrganizer",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistrationPass_RegistrationID",
                table: "EventRegistrationPass",
                column: "RegistrationID");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistrationUsers_Email",
                table: "EventRegistrationUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_expense_categoryId",
                table: "expense",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseUsers_Email",
                table: "ExpenseUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseUsers_userCode",
                table: "ExpenseUsers",
                column: "userCode");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__B43B145F8AD33E47",
                table: "ExpenseUsers",
                column: "phone",
                unique: true,
                filter: "[phone] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GoogleSignIn_UserId",
                table: "GoogleSignIn",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GradeClass_Class",
                table: "GradeClass",
                column: "Class",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GradeClass_Teacher_ID",
                table: "GradeClass",
                column: "Teacher_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GradeGrade_Student_ID",
                table: "GradeGrade",
                column: "Student_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GradeGrade_Subject_ID",
                table: "GradeGrade",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GradeStudent_Class",
                table: "GradeStudent",
                column: "Class");

            migrationBuilder.CreateIndex(
                name: "IX_InInventory_InProductID",
                table: "InInventory",
                column: "InProductID");

            migrationBuilder.CreateIndex(
                name: "IX_InInventory_ProviderId",
                table: "InInventory",
                column: "ProviderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InInventory_WareHouseId",
                table: "InInventory",
                column: "WareHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_InInventoryProducts_CategoryId",
                table: "InInventoryProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InInventoryProducts_WarehouseId",
                table: "InInventoryProducts",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_InInventoryWarehouseMappings_InInventoryInventoryId",
                table: "InInventoryWarehouseMappings",
                column: "InInventoryInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InInventoryWarehouseMappings_InWarehouseWarehouseId",
                table: "InInventoryWarehouseMappings",
                column: "InWarehouseWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_InLocations_WarehouseId",
                table: "InLocations",
                column: "WarehouseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InOrderDetails_CategoryId",
                table: "InOrderDetails",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InOrderDetails_InProductID",
                table: "InOrderDetails",
                column: "InProductID");

            migrationBuilder.CreateIndex(
                name: "IX_InOrderDetails_ProviderId",
                table: "InOrderDetails",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_InUserInventoryMapping_InventoryId",
                table: "InUserInventoryMapping",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InUserInventoryMapping_UserId",
                table: "InUserInventoryMapping",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_OrgCode",
                table: "Organizations",
                column: "OrgCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationUsers_OrganizationId",
                table: "OrganizationUsers",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationUsers_UserId",
                table: "OrganizationUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsApplications_ApplicationId",
                table: "ProductsApplications",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsApplications_ProductId",
                table: "ProductsApplications",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_CategoryId",
                table: "Quiz",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_LevelId",
                table: "Quiz",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizAnswers_QuestionId",
                table: "QuizAnswers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizCategories_LevelId",
                table: "QuizCategories",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizQuestions_CategoryId",
                table: "QuizQuestions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizScores_LevelId",
                table: "QuizScores",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizScores_QuizId",
                table: "QuizScores",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizScores_UserId",
                table: "QuizScores",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UQ__QuizUser__A9D10534BCE506A7",
                table: "QuizUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RecipeChefMapping_RecipeId",
                table: "RecipeChefMapping",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleActionPermission_ActionId",
                table: "RoleActionPermission",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleActionPermission_PermissionId",
                table: "RoleActionPermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleActionPermission_RoleId",
                table: "RoleActionPermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_ApplicationId",
                table: "UserRoles",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_OrganizationId",
                table: "UserRoles",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllowedDomains");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Blog_Comments");

            migrationBuilder.DropTable(
                name: "Blog_Subscription");

            migrationBuilder.DropTable(
                name: "BorrowedBooks");

            migrationBuilder.DropTable(
                name: "CarRental_Bookings");

            migrationBuilder.DropTable(
                name: "CarRental_Images");

            migrationBuilder.DropTable(
                name: "EventRegistrationPass");

            migrationBuilder.DropTable(
                name: "expense");

            migrationBuilder.DropTable(
                name: "GoogleSignIn");

            migrationBuilder.DropTable(
                name: "GradeGrade");

            migrationBuilder.DropTable(
                name: "InInventoryWarehouseMappings");

            migrationBuilder.DropTable(
                name: "InLocations");

            migrationBuilder.DropTable(
                name: "InOrderDetails");

            migrationBuilder.DropTable(
                name: "InUserInventoryMapping");

            migrationBuilder.DropTable(
                name: "OrganizationUsers");

            migrationBuilder.DropTable(
                name: "ProductsApplications");

            migrationBuilder.DropTable(
                name: "QuizAnswers");

            migrationBuilder.DropTable(
                name: "QuizScores");

            migrationBuilder.DropTable(
                name: "RecipeChefMapping");

            migrationBuilder.DropTable(
                name: "RoleActionPermission");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Blog_Posts");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "BookUsers");

            migrationBuilder.DropTable(
                name: "CarRental_Customers");

            migrationBuilder.DropTable(
                name: "CarRental_Cars");

            migrationBuilder.DropTable(
                name: "EventRegistration");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "GradeStudent");

            migrationBuilder.DropTable(
                name: "GradeSubject");

            migrationBuilder.DropTable(
                name: "InInventory");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "QuizQuestions");

            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.DropTable(
                name: "QuizUsers");

            migrationBuilder.DropTable(
                name: "RecipeChefs");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Blog_Users");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "EventRegistrationEvent");

            migrationBuilder.DropTable(
                name: "BudgetLedger");

            migrationBuilder.DropTable(
                name: "GradeClass");

            migrationBuilder.DropTable(
                name: "InInventoryProducts");

            migrationBuilder.DropTable(
                name: "InProviders");

            migrationBuilder.DropTable(
                name: "QuizCategories");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "EventRegistrationOrganizer");

            migrationBuilder.DropTable(
                name: "ExpenseUsers");

            migrationBuilder.DropTable(
                name: "GradeTeacher");

            migrationBuilder.DropTable(
                name: "InCategory");

            migrationBuilder.DropTable(
                name: "InWarehouses");

            migrationBuilder.DropTable(
                name: "QuizLevels");

            migrationBuilder.DropTable(
                name: "EventRegistrationUsers");
        }
    }
}
