using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Api.Models;
using Assignment.Api;
using Microsoft.EntityFrameworkCore.Design;
using Assignment.Api.Models.Inventory;
using Assignment.Api.Models.QuizGame;
using Assignment.Api.Models.Grades;
using Assignment.Api.Models.Recipe;
using Assignment.Api.Models.BlogModels;
using Assignment.Api;
using Assignment.Api.Models.QuizGameModels;

namespace Assignment.Infrastructure
{
    public class RaidenDBContext : DbContext
    {

        public RaidenDBContext(DbContextOptions<RaidenDBContext> options) : base(options)
        {

        }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<Actions> Actions { get; set; }
        public DbSet<RoleActionPermission> RoleActionPermission { get; set; }
        public DbSet<Organizations> Organizations { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<OrganizationUsers> OrganizationUsers { get; set; }
        public DbSet<Applications> Applications { get; set; }
        public DbSet<ApplicationUsers> ApplicationUsers { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductsApplication> ProductsApplications { get; set; }
        public virtual DbSet<Recipes> Recipes { get; set; }

        public virtual DbSet<RecipeChefs> RecipeChefs { get; set; }

        public virtual DbSet<RecipeChefMapping> RecipeChefMapping { get; set; }
        public DbSet<AllowedDomains> AllowedDomains { get; set; }
        public DbSet<GoogleSignIn> GoogleSignIn { get; set; }
        public DbSet<InCategory> InCategory { get; set; }
        public DbSet<InWarehouse> InWarehouses { get; set; }
        public DbSet<InInventoryProduct> InInventoryProducts { get; set; }
        public DbSet<InOrderDetail> InOrderDetails { get; set; }
        public DbSet<InProvider> InProviders { get; set; }
        public DbSet<InInventory> InInventory { get; set; }
        public DbSet<InLocation> InLocations { get; set; }

        public DbSet<InInventoryWarehouseMapping> InInventoryWarehouseMappings { get; set; }
        public virtual DbSet<BudgetLedger> BudgetLedgers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<ExpenseUser> ExpenseUsers { get; set; }
        public DbSet<EventRegistrationUsers> EventRegistrationUsers { get; set; }
        public DbSet<EventRegistrationOrganizer> EventRegistrationOrganizer { get; set; }
        public DbSet<EventRegistrationEvent> EventRegistrationEvent { get; set; }
        public DbSet<EventRegistration> EventRegistration { get; set; }
        public DbSet<EventRegistrationPass> EventRegistrationPass { get; set; }
        public virtual DbSet<Quiz> Quiz { get; set; }
        public virtual DbSet<QuizAnswer> QuizAnswers { get; set; }
        public virtual DbSet<QuizCategory> QuizCategories { get; set; }
        public virtual DbSet<QuizLevel> QuizLevels { get; set; }
        public virtual DbSet<QuizQuestion> QuizQuestions { get; set; }
        public virtual DbSet<QuizScore> QuizScores { get; set; }
        public virtual DbSet<QuizUser> QuizUsers { get; set; }
        public virtual DbSet<QuizAnsweredQuestion> QuizAnsweredQuestion { get; set; }


        public DbSet<GradeClass> GradeClass { get; set; }

        public DbSet<GradeGrade> GradeGrade { get; set; }

        public DbSet<GradeStudent> GradeStudent { get; set; }

        public DbSet<GradeSubject> GradeSubject { get; set; }

        public DbSet<GradeTeacher> GradeTeacher { get; set; }
        public DbSet<CarRentalBooking> CarRentalBookings { get; set; }
        public DbSet<CarRentalCar> CarRentalCars { get; set; }
        public DbSet<CarRentalCustomer> CarRentalCustomers { get; set; }
        public DbSet<CarRentalImage> CarRentalImages { get; set; }
        public DbSet<CarRentalAdmin> CarRentalAdmins { get; set; }

        public virtual DbSet<BlogComments> BlogComments { get; set; }
        public virtual DbSet<BlogPosts> BlogPosts { get; set; }
        public virtual DbSet<BlogSubscription> BlogSubscriptions { get; set; }
        public virtual DbSet<BlogUsers> BlogUsers { get; set; }


        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookUser> BookUsers { get; set; }

        public DbSet<BorrowedBook> BorrowedBooks { get; set; }

        public DbSet<TaskUsers> TaskUsers { get; set; }
        public DbSet<TaskManager> TaskManager { get; set; }
        public DbSet<TaskTag> TaskTag { get; set; }
        public DbSet<TaskTimeLog> TaskTimeLog { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BudgetLedger>(entity =>
            {
                entity.HasKey(e => e.LedgerId).HasName("PK__BudgetLe__298DF4D5696FF6BF");

                entity.ToTable("BudgetLedger");

                entity.HasIndex(e => e.LedgerCode);

                entity.Property(e => e.LedgerId).HasColumnName("ledgerId");
                entity.Property(e => e.Name).HasColumnName("Name");
                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("amount");
                entity.Property(e => e.Type)
                .HasColumnName("Type");
                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("createdAt");
                entity.Property(e => e.LedgerCode)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(('BL'+replicate('0',(5)-len([ledgerId])))+CONVERT([varchar],[ledgerId]))", false)
                    .HasColumnName("ledgerCode");
                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User).WithMany(p => p.BudgetLedgers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__BudgetLed__userI__619B8048");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId).HasName("PK__category__23CAF1D8D15756DD");

                entity.ToTable("category");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");
                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("amount");
                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("description");
                entity.Property(e => e.LedgerId).HasColumnName("ledgerId");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.Ledger).WithMany(p => p.Categories)
                    .HasForeignKey(d => d.LedgerId)
                    .HasConstraintName("FK__category__ledger__6477ECF3");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasKey(e => e.ExpenseId).HasName("PK__expense__3672732E40DEC0D3");

                entity.ToTable("expense");

                entity.Property(e => e.ExpenseId).HasColumnName("expenseId");
                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("amount");
                entity.Property(e => e.CategoryId).HasColumnName("categoryId");
                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");
                entity.Property(e => e.Image)
                .HasColumnType("image")
                    .HasColumnName("image");
                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");
                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.HasOne(d => d.Category).WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__expense__amount__6754599E");
            });

            modelBuilder.Entity<ExpenseUser>(entity =>
            {
                entity.HasKey(e => e.UserId).HasName("PK__Users__CB9A1CFF793E5508");

                entity.HasIndex(e => e.Phone, "UQ__Users__B43B145F8AD33E47").IsUnique();

                entity.HasIndex(e => e.UserCode);

                entity.Property(e => e.UserId).HasColumnName("userId");
                entity.HasIndex(e => e.Email).IsUnique();
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");
                entity.Property(e => e.Password).HasColumnName("password");
                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phone");
                entity.Property(e => e.UserCode)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(('USER'+replicate('0',(5)-len([userId])))+CONVERT([varchar](5),[userId]))", true)
                    .HasColumnName("userCode");
            });

            modelBuilder.Entity<Organizations>()
            .HasIndex(o => o.OrgCode)
            .IsUnique();
            modelBuilder.Entity<EventRegistrationUsers>()
            .HasIndex(o => o.Email)
            .IsUnique();


            modelBuilder.Entity<GradeClass>()
            .HasIndex(g => g.Class)
                .IsUnique();

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Application)
                .WithMany()  // Assuming there's a navigation property in Applications pointing back to UserRoles
                .HasForeignKey(ur => ur.ApplicationId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure the relationship between UserRole and Users
            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany()  // Assuming there's a navigation property in Users pointing back to UserRoles
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure the relationship between UserRole and Roles
            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany()
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserRole>()
               .HasOne(ur => ur.Organization)
               .WithMany()
               .HasForeignKey(ur => ur.OrganizationId)
               .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ProductsApplication>()
               .HasOne(ur => ur.Products)
               .WithMany()
               .HasForeignKey(ur => ur.ProductId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InInventoryProduct>()
     .Property(ip => ip.Amount)
     .HasColumnType("float");

            modelBuilder.Entity<InInventory>()
                .Property(i => i.Amount)
                .HasColumnType("float");

            modelBuilder.Entity<InInventoryProduct>()
                 .HasOne(ip => ip.InCategory)
                 .WithMany()
                 .HasForeignKey(ip => ip.CategoryId)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InInventory>()
                .HasOne(i => i.InProvider)
                .WithOne()
                .HasForeignKey<InInventory>(i => i.ProviderId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<InLocation>()
                .HasOne(l => l.InWarehouse)
                .WithOne()
                .HasForeignKey<InLocation>(l => l.WarehouseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InUserInventoryMapping>()
                .HasOne(uim => uim.Users)
                .WithMany()
                .HasForeignKey(uim => uim.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EventRegistration>()
             .HasOne(ur => ur.EventRegistrationEvent)
             .WithMany()
             .HasForeignKey(ur => ur.EventID)
             .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EventRegistration>()
            .HasOne(ur => ur.EventRegistrationEvent)
            .WithMany()
            .HasForeignKey(ur => ur.UserID)
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EventRegistrationEvent>()
            .HasOne(ur => ur.EventRegistrationOrganizer)
            .WithMany()
            .HasForeignKey(ur => ur.OrganizerID)
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EventRegistrationEvent>()
            .HasOne(ur => ur.EventRegistrationOrganizer)
            .WithMany()
            .HasForeignKey(ur => ur.OrganizerID)
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EventRegistrationPass>()
            .HasOne(ur => ur.EventRegistration)
            .WithMany()
            .HasForeignKey(ur => ur.RegistrationID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InOrderDetail>()
                .HasOne(od => od.InInventoryProduct)
                .WithMany()
                .HasForeignKey(od => od.InProductID)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<InInventoryProduct>()
       .HasOne(ip => ip.InWarehouse)
       .WithMany()
       .HasForeignKey(ip => ip.WarehouseId)
       .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.AuthorId).HasName("PK__Authors__70DAFC141A2742D8");

                entity.Property(e => e.AuthorId)
                    .HasColumnName("AuthorID");
                entity.Property(e => e.AuthorBio).HasColumnType("text");
                entity.Property(e => e.AuthorName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.BookId).HasName("PK__Books__3DE0C227BF9B6851");

                entity.Property(e => e.BookId)
                    .HasColumnName("BookID");
                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");
                entity.Property(e => e.Genre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Isbn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Author).WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK__Books__AuthorID__398D8EEE");
            });

            modelBuilder.Entity<BookUser>(entity =>
            {
                entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC1BED877E");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID");
                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BorrowedBook>(entity =>
            {
                entity.HasKey(e => e.BorrowId).HasName("PK__Borrowed__4295F85F598F0F44");

                entity.Property(e => e.BorrowId)
                    .HasColumnName("BorrowID");
                entity.Property(e => e.BookId).HasColumnName("BookID");
                entity.Property(e => e.BorrowDate).HasColumnType("date");
                entity.Property(e => e.ReturnDate).HasColumnType("date");
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Book).WithMany(p => p.BorrowedBooks)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__BorrowedB__BookI__3F466844");

                entity.HasOne(d => d.User).WithMany(p => p.BorrowedBooks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__BorrowedB__UserI__3E52440B");
            });







            modelBuilder.Entity<Quiz>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Category).WithMany(p => p.Quizzes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade); // Disable cascade delete for QuizCategories relationship

                entity.HasOne(d => d.Level).WithMany(p => p.Quizzes)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.Cascade); // Disable cascade delete for QuizLevels relationship
            });

            modelBuilder.Entity<QuizAnswer>(entity =>
            {
                entity.HasKey(e => e.AnswerId).HasName("PK__QuizAnsw__D4825004917C4A47");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.Question).WithMany(p => p.QuizAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__QuizAnswe__Quest__5E8A0973");
            });

            modelBuilder.Entity<QuizCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId).HasName("PK__QuizCate__19093A0B787E379B");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Level).WithMany(p => p.QuizCategories)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK__QuizCateg__Level__58D1301D")
                    .OnDelete(DeleteBehavior.Restrict); // Disable cascade delete for QuizLevels relationship
            });


            modelBuilder.Entity<QuizLevel>(entity =>
            {
                entity.HasKey(e => e.LevelId).HasName("PK__QuizLeve__09F03C269EE1AA23");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.QuizType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QuizQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId).HasName("PK__QuizQues__0DC06FACA59EE87C");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.Category).WithMany(p => p.QuizQuestions)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__QuizQuest__Categ__5BAD9CC8");
            });

            modelBuilder.Entity<QuizScore>(entity =>
            {
                entity.HasKey(e => e.ScoreId).HasName("PK__QuizScor__7DD229D1A7C5F9C3");

                entity.HasOne(d => d.Level).WithMany(p => p.QuizScores)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK__QuizScore__Level__681373AD");

                entity.HasOne(d => d.Quiz).WithMany(p => p.QuizScores)
                    .HasForeignKey(d => d.QuizId)
                    .HasConstraintName("FK__QuizScore__QuizI__671F4F74");

                entity.HasOne(d => d.User).WithMany(p => p.QuizScores)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__QuizScore__UserI__662B2B3B");
            });

            modelBuilder.Entity<QuizUser>(entity =>
            {
                entity.HasKey(e => e.UserId).HasName("PK__QuizUser__1788CC4C7FFE809B");

                entity.HasIndex(e => e.Email, "UQ__QuizUser__A9D10534BCE506A7").IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);
                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);
                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });



            modelBuilder.Entity<GradeTeacher>()
                .Property(e => e.Role)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<GradeTeacher>()
                .Property(e => e.TeacherName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("Teacher_Name");



            modelBuilder.Entity<GradeClass>()
      .Property(e => e.Class)
          .IsRequired()
          .HasMaxLength(255);

            modelBuilder.Entity<GradeClass>()
      .Property(e => e.TeacherId).HasColumnName("Teacher_ID");

            modelBuilder.Entity<GradeClass>()
            .HasOne(d => d.Teacher).WithMany(p => p.GradeClasses)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GradeStudent>()
           .Property(e => e.StudentCode)

           .HasColumnName("StudentCode");

            modelBuilder.Entity<GradeStudent>()
        .Property(e => e.Class)
            .IsRequired()
            .HasMaxLength(255);

            modelBuilder.Entity<GradeStudent>()
        .Property(e => e.Dob)
          .HasMaxLength(255)
            .HasColumnName("DOB");

            modelBuilder.Entity<GradeStudent>()
        .Property(e => e.Email)
            .IsRequired()

            .HasMaxLength(255);

            modelBuilder.Entity<GradeStudent>()
        .Property(e => e.Gender)
            .IsRequired()
            .HasMaxLength(20);

            modelBuilder.Entity<GradeStudent>()
        .Property(e => e.StudentFname)
            .IsRequired()
            .HasMaxLength(255)
            .HasColumnName("Student_Fname");

            modelBuilder.Entity<GradeStudent>()
        .Property(e => e.StudentLname)
            .IsRequired()
            .HasMaxLength(255)
            .HasColumnName("Student_Lname");

            modelBuilder.Entity<GradeStudent>()
                .HasOne(d => d.ClassNavigation).WithMany(p => p.GradeStudents)
                    .HasPrincipalKey(p => p.Class)
                    .HasForeignKey(d => d.Class)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GradeSubject>()
                     .Property(e => e.SubjectCode)
                   .HasColumnName("SubjectCode");

            modelBuilder.Entity<GradeSubject>()
                .Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Subject_Name");


            modelBuilder.Entity<GradeGrade>()
                .Property(e => e.GradeId)
                .HasColumnName("Grade_ID");

            modelBuilder.Entity<GradeGrade>()
            .Property(e => e.GradeLetter)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("Grade_Letter");

            modelBuilder.Entity<GradeGrade>()
            .Property(e => e.Score)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<GradeGrade>()
            .Property(e => e.StudentCode).HasColumnName("StudentCode");

            modelBuilder.Entity<GradeGrade>()
            .Property(e => e.SubjectCode).HasColumnName("SubjectCode");

            modelBuilder.Entity<GradeGrade>()
            .HasOne(d => d.Student).WithMany(p => p.GradeGrades)
                .HasForeignKey(d => d.StudentCode)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<GradeGrade>()
            .HasOne(d => d.Subject).WithMany(p => p.GradeGrades)
                .HasForeignKey(d => d.SubjectCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RecipeChefMapping>()
             .HasKey(crm => new { crm.ChefId, crm.RecipeId });

            modelBuilder.Entity<RecipeChefMapping>()
             .HasOne(crm => crm.Chef)
             .WithMany(c => c.RecipeMappings)
             .HasForeignKey(crm => crm.ChefId);

            modelBuilder.Entity<RecipeChefMapping>()
                .HasOne(crm => crm.Recipe)
                .WithMany(r => r.ChefMappings)
                .HasForeignKey(crm => crm.RecipeId);
            modelBuilder.Entity<RecipeChefMapping>()
            .HasOne(crm => crm.Recipe)
            .WithMany(r => r.ChefMappings)
            .HasForeignKey(crm => crm.RecipeId)
            .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<QuizAnsweredQuestion>()
        .HasOne(qaq => qaq.User)
        .WithMany()
        .HasForeignKey(qaq => qaq.UserId)
        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<QuizAnsweredQuestion>()
                .HasOne(qaq => qaq.Level)
                .WithMany()
                .HasForeignKey(qaq => qaq.LevelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<QuizAnsweredQuestion>()
                .HasOne(qaq => qaq.Quiz)
                .WithMany()
                .HasForeignKey(qaq => qaq.QuizId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<QuizAnsweredQuestion>()
                .HasOne(qaq => qaq.Question)
                .WithMany()
                .HasForeignKey(qaq => qaq.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<QuizLevel>().HasData(
               new QuizLevel { LevelId = 1, Name = "Beginner", QuizType = "MCQ" },
               new QuizLevel { LevelId = 2, Name = "Pro", QuizType = "Typing" }
               );


            modelBuilder.Entity<Roles>().HasData(
                new Roles { RoleId = 1, RoleName = "SuperAdmin", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new Roles { RoleId = 2, RoleName = "OrgAdmin", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new Roles { RoleId = 3, RoleName = "AppAdmin", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now }

            );
            modelBuilder.Entity<Permissions>().HasData(
                new Permissions { PermissionId = 1, PermissionName = "view", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new Permissions { PermissionId = 2, PermissionName = "create", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new Permissions { PermissionId = 3, PermissionName = "edit", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new Permissions { PermissionId = 4, PermissionName = "delete", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new Permissions { PermissionId = 5, PermissionName = "enable", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new Permissions { PermissionId = 6, PermissionName = "disable", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now }
                );
            modelBuilder.Entity<InWarehouse>().HasData(
            new InWarehouse { WarehouseId = 1, WarehouseName = "Warehouse A" },
            new InWarehouse { WarehouseId = 2, WarehouseName = "Warehouse B" },
            new InWarehouse { WarehouseId = 3, WarehouseName = "Warehouse C" }
                );
            modelBuilder.Entity<InCategory>().HasData(
            new InCategory { CategoryId = 1, CategoryName = "Electronics" },
            new InCategory { CategoryId = 2, CategoryName = "Clothing"},
            new InCategory { CategoryId = 3, CategoryName = "Home and Kitchen"},
            new InCategory { CategoryId = 4, CategoryName = "Books"},
            new InCategory { CategoryId = 5, CategoryName = "Diary"}
            );           
            modelBuilder.Entity<InProvider>().HasData(
                new InProvider { ProviderId = 1, ProviderName = "Provider A", ProviderAddress = "Address A" },
                new InProvider { ProviderId = 2, ProviderName = "Provider B", ProviderAddress = "Address B" },
                new InProvider { ProviderId = 3, ProviderName = "Provider C", ProviderAddress = "Address C" },
                new InProvider { ProviderId = 4, ProviderName = "Provider D", ProviderAddress = "Address D" },
                new InProvider { ProviderId = 5, ProviderName = "Provider E", ProviderAddress = "Address E" },
                new InProvider { ProviderId = 6, ProviderName = "Provider F", ProviderAddress = "Address F" },
                new InProvider { ProviderId = 7, ProviderName = "Provider G", ProviderAddress = "Address G" },
                new InProvider { ProviderId = 8, ProviderName = "Provider H", ProviderAddress = "Address H" },
                new InProvider { ProviderId = 9, ProviderName = "Provider I", ProviderAddress = "Address I" },
                new InProvider { ProviderId = 10, ProviderName = "Provider J", ProviderAddress = "Address J" }
            );




            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    UserId = 1,
                    Password = Environment.GetEnvironmentVariable("PASSWORD1"),
                    Email = "Spurtree@example.com",
                    FirstName = "Spurtree",
                    IsActive = true
                },
                new Users
                {
                    UserId = 2,
                    Password = Environment.GetEnvironmentVariable("PASSWORD2"),
                    Email = "Abhay@example.com",
                    FirstName = "Abhay",
                    IsActive = true
                },
                new Users
                {
                    UserId = 3,
                    Password = Environment.GetEnvironmentVariable("PASSWORD3"),
                    Email = "Bhoomi@example.com",
                    FirstName = "Bhoomi",
                    IsActive = true
                },
                 new Users
                 {
                     UserId = 4,
                     Password = Environment.GetEnvironmentVariable("PASSWORD4"),
                     Email = "pavan.m@spurtreetech.com",
                     FirstName = "pavan",
                     IsActive = true
                 });
            modelBuilder.Entity<Actions>().HasData(
     new Actions { ActionId = 1, ActionName = "raiden-settings", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
     new Actions { ActionId = 2, ActionName = "orgsetting", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
     new Actions { ActionId = 3, ActionName = "appsetting", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
     new Actions { ActionId = 4, ActionName = "user", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
     new Actions { ActionId = 5, ActionName = "org-notification-setting", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
     new Actions { ActionId = 6, ActionName = "app-notification-setting", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
     new Actions { ActionId = 7, ActionName = "org-auditlog-setting", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
     new Actions { ActionId = 8, ActionName = "app-auditlog-setting", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
     new Actions { ActionId = 9, ActionName = "email-event", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
     new Actions { ActionId = 10, ActionName = "auditlog-event", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
     new Actions { ActionId = 11, ActionName = "emailtemplate", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
     new Actions { ActionId = 12, ActionName = "auditlog", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now });


            modelBuilder.Entity<Organizations>().HasData(
                new Organizations
                {
                    OrganizationId = 1,
                    OrgCode = "CD01",
                    OrganizationName = "Organization A",
                    OrganizationEmail = "orgA@example.com",
                    OrganizationPhone = "1234567890",
                    CreatedTimestamp = DateTime.Now,
                    ModifiedTimestamp = DateTime.Now,
                    IsActive = true
                },
                new Organizations
                {
                    OrganizationId = 2,
                    OrgCode = "AB01",
                    OrganizationName = "Organization B",
                    OrganizationEmail = "orgB@example.com",
                    OrganizationPhone = "9876543210",
                    CreatedTimestamp = DateTime.Now,
                    ModifiedTimestamp = DateTime.Now,
                    IsActive = true
                },
                new Organizations
                {
                    OrganizationId = 3,
                    OrgCode = "DC02",
                    OrganizationName = "Organization C",
                    OrganizationEmail = "orgC@example.com",
                    OrganizationPhone = "5555555555",
                    CreatedTimestamp = DateTime.Now,
                    ModifiedTimestamp = DateTime.Now,
                    IsActive = true
                },
                new Organizations
                {
                    OrganizationId = 8,
                    OrgCode = "STT01",
                    OrganizationName = "Spurtree",
                    OrganizationEmail = "spurtree2023@gmail.com",
                    OrganizationPhone = "5555555555",
                    CreatedTimestamp = DateTime.Now,
                    ModifiedTimestamp = DateTime.Now,
                    IsActive = true
                }
            );

            modelBuilder.Entity<CarRentalBooking>(entity =>
            {
                entity.HasKey(e => e.BookingId).HasName("PK__CarRenta__73951ACDA7E24354");

                entity.ToTable("CarRental_Bookings");

                entity.Property(e => e.BookingId)
                    .HasColumnName("BookingID");
                entity.Property(e => e.CarId).HasColumnName("CarID");
                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
                entity.Property(e => e.EndDate).HasColumnType("date");
                entity.Property(e => e.StartDate).HasColumnType("date");
                entity.Property(e => e.Status).HasMaxLength(50);
                entity.Property(e => e.TotalCost).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Car).WithMany(p => p.CarRentalBookings)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__CarRental__CarID__5224328E");

                entity.HasOne(d => d.Customer).WithMany(p => p.CarRentalBookings)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__CarRental__Custo__531856C7");
            });

            modelBuilder.Entity<CarRentalCar>(entity =>
            {
                entity.HasKey(e => e.CarId).HasName("PK__CarRenta__68A0340EBDB30A5A");

                entity.ToTable("CarRental_Cars");

                entity.Property(e => e.CarId)
                    .HasColumnName("CarID");
                entity.Property(e => e.Brand).HasMaxLength(100);
                entity.Property(e => e.Color).HasMaxLength(50);
                entity.Property(e => e.LastMaintenanceDate).HasColumnType("date");
                entity.Property(e => e.Model).HasMaxLength(100);
                entity.Property(e => e.RentalRatePerDay).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<CarRentalCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId).HasName("PK__CarRenta__A4AE64B83328061C");

                entity.ToTable("CarRental_Customers");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID");
                entity.Property(e => e.Address).HasMaxLength(200);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.MembershipExpiration).HasColumnType("date");
                entity.Property(e => e.Phone).HasMaxLength(20);
                entity.Property(e => e.Password).HasMaxLength(100);
            });
            modelBuilder.Entity<CarRentalAdmin>(entity =>
            {
                entity.HasKey(e => e.AdminId);
                entity.ToTable("CarRental_Admin");
                entity.Property(e => e.AdminId)
                    .HasColumnName("AdminID");
                entity.Property(e => e.CarId).HasMaxLength(5);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.Password).HasMaxLength(100);
                entity.HasOne(d => d.Car).WithMany(p => p.CarAdmin)
                   .HasForeignKey(d => d.CarId);
            });
            modelBuilder.Entity<CarRentalAdmin>()
            .Property(e => e.Email)
                .IsRequired().IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Admin_Email");
            modelBuilder.Entity<CarRentalImage>(entity =>
            {
                entity.HasKey(e => e.ImageId).HasName("PK__CarRenta__7516F4ECDBED5D35");

                entity.ToTable("CarRental_Images");

                entity.Property(e => e.ImageId)
                    .HasColumnName("ImageID");
                entity.Property(e => e.CarId).HasColumnName("CarID");
                entity.Property(e => e.Image)
                    .HasColumnName("Image");

                entity.HasOne(d => d.Car).WithMany(p => p.CarRentalImages)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__CarRental__CarID__55F4C372");
            });


            modelBuilder.Entity<BlogComments>(entity =>
            {
                entity.HasKey(e => e.CommentId).HasName("PK__Blog_Com__C3B4DFAA6558CCA9");

                entity.ToTable("Blog_Comments");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");
                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");
                entity.Property(e => e.Content).IsRequired();
                entity.Property(e => e.CreationDate).HasColumnType("datetime");
                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.HasOne(d => d.Author).WithMany(p => p.BlogComments)
                    .HasForeignKey(d => d.AuthorId)
                 .OnDelete(DeleteBehavior.Restrict);
                //.HasConstraintName("FK__Blog_Comm__Autho__5D60DB10");

                entity.HasOne(d => d.Post).WithMany(p => p.BlogComments)
                    .HasForeignKey(d => d.PostId)
                 .OnDelete(DeleteBehavior.Restrict);
                //.HasConstraintName("FK__Blog_Comm__PostI__5C6CB6D7");
            });

            modelBuilder.Entity<BlogPosts>(entity =>
            {
                entity.HasKey(e => e.PostId).HasName("PK__Blog_Pos__AA1260387789040E");

                entity.ToTable("Blog_Posts");

                entity.Property(e => e.PostId).HasColumnName("PostID");
                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");
                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(255);
                entity.Property(e => e.Content).IsRequired();
                entity.Property(e => e.CreationDate).HasColumnType("datetime");
                entity.Property(e => e.ImageMimeType).HasMaxLength(50);
                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Author).WithMany(p => p.BlogPosts)
                    .HasForeignKey(d => d.AuthorId);
                //.HasConstraintName("FK__Blog_Post__Autho__589C25F3");
            });

            modelBuilder.Entity<BlogSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId).HasName("PK__Blog_Sub__9A2B24BD2DD349F1");

                entity.ToTable("Blog_Subscription");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
                entity.Property(e => e.Role).IsRequired();
                entity.Property(e => e.SubscriptionType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BlogUsers>(entity =>
            {
                entity.HasKey(e => e.UserId).HasName("PK__Blog_Use__1788CCACC7675079");

                entity.ToTable("Blog_Users");

                entity.HasIndex(e => e.Username, "UQ__Blog_Use__536C85E4D316E809").IsUnique();

                entity.HasIndex(e => e.Email, "UQ__Blog_Use__A9D10534FDFECB16").IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);
                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);
                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
                entity.Property(e => e.SubscriptionType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Subscription_Type");
                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OrganizationUsers>().HasData(
                new OrganizationUsers { OrgUserId = 1, UserId = 1, OrganizationId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now, Orgcode = "CD01", IsActive = true },
                new OrganizationUsers { OrgUserId = 2, UserId = 2, OrganizationId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now, Orgcode = "CD01", IsActive = true },
                new OrganizationUsers { OrgUserId = 3, UserId = 2, OrganizationId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now, Orgcode = "AB01", IsActive = true },
                new OrganizationUsers { OrgUserId = 4, UserId = 4, OrganizationId = 8, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now, Orgcode = "STT01", IsActive = true }
            );

            modelBuilder.Entity<Applications>().HasData(
               new Applications { ApplicationId = 1, ApplicationName = "BIRA", Phone = "07601012345", OrganizationId = 1, AppCode = "BD420", ClientId = "8ff708940da64155a374154518d0191e", ClientSecret = "aWwseuUhomz5zlyJB6HfSqPKCAEoRP2erOGhM2lUNzA=", IsActive = true, FirstName = "Tony", LastName = "Stark" },
               new Applications { ApplicationId = 2, ApplicationName = "JACK DANIALS", Phone = "1800208663", OrganizationId = 3, AppCode = "JD420", ClientId = "8ff708940da64155a374154518d0000e", ClientSecret = "aWwseuUhomz5zlyJB6HfSqPKCAEoRP2erOGhM2lUccc=", IsActive = true, FirstName = "JACK", LastName = "SPARROW" },
               new Applications { ApplicationId = 8, ApplicationName = "CYRAX", Phone = "0987654321", OrganizationId = 8, AppCode = "Cyrax01", ClientId = "23ec653fa43f44f58f1e4ece3b673685", ClientSecret = "A8zvcp1ZkNJk4Sy1dzFkULSvYIGOPCFYdLFA4XbD4Ig=", IsActive = true, FirstName = "Cyrax", LastName = "Service", ApplicationEmail = "stlabmse@gmail.com", Description = "Send notifications" },
               new Applications { ApplicationId = 9, ApplicationName = "KITANA", Phone = "0987654321", OrganizationId = 8, AppCode = "Kitana01", ClientId = "bece4d5ec6bf40bba0396c732c47fd30", ClientSecret = "G9CCFOuRCsOSvQswI4bpgiiht8lIANEtqsQVrEytXQY=", IsActive = true, FirstName = "Kitana", LastName = "Service", ApplicationEmail = "kitana.dev@gmail.com", Description = "Audit Logging" },
               new Applications { ApplicationId = 10, ApplicationName = "RAIDEN", Phone = "9035402732", OrganizationId = 8, AppCode = "Raiden01", ClientId = "4ef085f15f1d488288d22645aeb62ab8", ClientSecret = "mk0BTaz5vuzfuicAgoGZ147GjVPVcDbYKdxpNs4nLpE=", IsActive = true, FirstName = "Raiden", LastName = "Service", ApplicationEmail = "raidendev08@gmail.com", Description = "Centralised authorization and authentication" }
           );
            modelBuilder.Entity<ApplicationUsers>().HasData(
               new ApplicationUsers { AppUserId = 1, UserId = 3, OrganizationId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now, Orgcode = "CD01", ApplicationId = 1, AppCode = "BD420", IsActive = true },
               new ApplicationUsers { AppUserId = 2, UserId = 2, OrganizationId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now, Orgcode = "DC02", ApplicationId = 2, AppCode = "JD420", IsActive = true },
               new ApplicationUsers { AppUserId = 3, UserId = 3, OrganizationId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now, Orgcode = "DC01", ApplicationId = 2, AppCode = "JD420", IsActive = true }
           );
            modelBuilder.Entity<RoleActionPermission>().HasData(
                new RoleActionPermission { OperationId = 1, ActionId = 1, PermissionId = 1, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 2, ActionId = 1, PermissionId = 2, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 3, ActionId = 1, PermissionId = 3, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 4, ActionId = 1, PermissionId = 4, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 5, ActionId = 2, PermissionId = 1, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 6, ActionId = 2, PermissionId = 2, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 7, ActionId = 2, PermissionId = 3, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 8, ActionId = 2, PermissionId = 4, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 9, ActionId = 2, PermissionId = 5, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 10, ActionId = 2, PermissionId = 6, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 11, ActionId = 3, PermissionId = 1, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 12, ActionId = 3, PermissionId = 2, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 13, ActionId = 3, PermissionId = 3, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 14, ActionId = 3, PermissionId = 4, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 15, ActionId = 3, PermissionId = 5, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 16, ActionId = 3, PermissionId = 6, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 17, ActionId = 4, PermissionId = 1, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 18, ActionId = 4, PermissionId = 2, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 19, ActionId = 4, PermissionId = 3, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 20, ActionId = 4, PermissionId = 4, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 21, ActionId = 4, PermissionId = 5, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 22, ActionId = 4, PermissionId = 6, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 23, ActionId = 5, PermissionId = 1, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 24, ActionId = 5, PermissionId = 2, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 25, ActionId = 5, PermissionId = 3, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 26, ActionId = 5, PermissionId = 4, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 27, ActionId = 6, PermissionId = 1, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 28, ActionId = 6, PermissionId = 2, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 29, ActionId = 6, PermissionId = 3, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 30, ActionId = 6, PermissionId = 4, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 31, ActionId = 7, PermissionId = 1, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 32, ActionId = 7, PermissionId = 2, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 33, ActionId = 7, PermissionId = 3, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 34, ActionId = 7, PermissionId = 4, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 35, ActionId = 8, PermissionId = 1, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 36, ActionId = 8, PermissionId = 2, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 37, ActionId = 8, PermissionId = 3, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 38, ActionId = 8, PermissionId = 4, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 39, ActionId = 9, PermissionId = 1, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 40, ActionId = 9, PermissionId = 2, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 41, ActionId = 9, PermissionId = 3, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 42, ActionId = 9, PermissionId = 4, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 43, ActionId = 10, PermissionId = 1, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 44, ActionId = 10, PermissionId = 2, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 45, ActionId = 10, PermissionId = 3, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 46, ActionId = 10, PermissionId = 4, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 47, ActionId = 11, PermissionId = 1, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 48, ActionId = 11, PermissionId = 2, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 49, ActionId = 11, PermissionId = 3, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 50, ActionId = 11, PermissionId = 4, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 51, ActionId = 12, PermissionId = 1, RoleId = 1, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 52, ActionId = 1, PermissionId = 1, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 53, ActionId = 2, PermissionId = 1, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 54, ActionId = 2, PermissionId = 2, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 55, ActionId = 2, PermissionId = 3, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 56, ActionId = 2, PermissionId = 4, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 57, ActionId = 2, PermissionId = 5, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 58, ActionId = 2, PermissionId = 6, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 59, ActionId = 3, PermissionId = 1, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 60, ActionId = 3, PermissionId = 2, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 61, ActionId = 3, PermissionId = 3, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 62, ActionId = 3, PermissionId = 4, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 63, ActionId = 3, PermissionId = 5, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 64, ActionId = 3, PermissionId = 6, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 65, ActionId = 4, PermissionId = 1, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 66, ActionId = 4, PermissionId = 2, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 67, ActionId = 4, PermissionId = 3, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 68, ActionId = 4, PermissionId = 4, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 69, ActionId = 4, PermissionId = 5, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 70, ActionId = 4, PermissionId = 6, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 71, ActionId = 5, PermissionId = 1, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 72, ActionId = 5, PermissionId = 2, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 73, ActionId = 5, PermissionId = 3, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 74, ActionId = 5, PermissionId = 4, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 75, ActionId = 6, PermissionId = 1, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 76, ActionId = 6, PermissionId = 2, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 77, ActionId = 6, PermissionId = 3, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 78, ActionId = 6, PermissionId = 4, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 79, ActionId = 7, PermissionId = 1, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 80, ActionId = 7, PermissionId = 2, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 81, ActionId = 7, PermissionId = 3, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 82, ActionId = 7, PermissionId = 4, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 83, ActionId = 8, PermissionId = 1, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 84, ActionId = 8, PermissionId = 2, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 85, ActionId = 8, PermissionId = 3, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 86, ActionId = 8, PermissionId = 4, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 87, ActionId = 9, PermissionId = 1, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 88, ActionId = 9, PermissionId = 2, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 89, ActionId = 9, PermissionId = 3, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 90, ActionId = 9, PermissionId = 4, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 91, ActionId = 10, PermissionId = 1, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 92, ActionId = 10, PermissionId = 2, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 93, ActionId = 10, PermissionId = 3, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 94, ActionId = 10, PermissionId = 4, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 95, ActionId = 11, PermissionId = 1, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 96, ActionId = 11, PermissionId = 2, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 97, ActionId = 11, PermissionId = 3, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 98, ActionId = 11, PermissionId = 4, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 99, ActionId = 12, PermissionId = 1, RoleId = 2, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 100, ActionId = 3, PermissionId = 1, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 101, ActionId = 3, PermissionId = 3, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 102, ActionId = 4, PermissionId = 1, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 103, ActionId = 4, PermissionId = 2, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 104, ActionId = 4, PermissionId = 3, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 105, ActionId = 4, PermissionId = 4, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 106, ActionId = 6, PermissionId = 1, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 107, ActionId = 6, PermissionId = 2, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 108, ActionId = 6, PermissionId = 3, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 109, ActionId = 6, PermissionId = 4, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 110, ActionId = 8, PermissionId = 1, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 111, ActionId = 8, PermissionId = 2, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 112, ActionId = 8, PermissionId = 3, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 113, ActionId = 8, PermissionId = 4, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 114, ActionId = 9, PermissionId = 1, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 115, ActionId = 9, PermissionId = 2, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 116, ActionId = 9, PermissionId = 3, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 117, ActionId = 9, PermissionId = 4, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 118, ActionId = 10, PermissionId = 1, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 119, ActionId = 10, PermissionId = 2, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 120, ActionId = 10, PermissionId = 3, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 121, ActionId = 10, PermissionId = 4, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 122, ActionId = 11, PermissionId = 1, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 123, ActionId = 11, PermissionId = 2, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 124, ActionId = 11, PermissionId = 3, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
                new RoleActionPermission { OperationId = 125, ActionId = 11, PermissionId = 4, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },

                new RoleActionPermission { OperationId = 126, ActionId = 12, PermissionId = 1, RoleId = 3, CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now }

            );

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { UserRoleId = 1, UserId = 1, RoleId = 1, OrganizationId = null, ApplicationId = null },
                new UserRole { UserRoleId = 2, UserId = 2, RoleId = 2, OrganizationId = 1, ApplicationId = null },
                new UserRole { UserRoleId = 3, UserId = 2, RoleId = 3, OrganizationId = 3, ApplicationId = 2 },
                new UserRole { UserRoleId = 4, UserId = 3, RoleId = 3, OrganizationId = 1, ApplicationId = 1 },
                new UserRole { UserRoleId = 5, UserId = 2, RoleId = 2, OrganizationId = 2, ApplicationId = null },
                new UserRole { UserRoleId = 6, UserId = 3, RoleId = 3, OrganizationId = 2, ApplicationId = null },
                new UserRole { UserRoleId = 7, UserId = 4, RoleId = 2, OrganizationId = 8, ApplicationId = null },
                new UserRole { UserRoleId = 8, UserId = 4, RoleId = 1, OrganizationId = null, ApplicationId = null }
                );
            modelBuilder.Entity<AllowedDomains>().HasData(
               new AllowedDomains { AllowedDomainId = 1, Domain = "spurtreetech.com", OrganizationId = null, ApplicationId = null, IsActive = true },
               new AllowedDomains { AllowedDomainId = 2, Domain = "spurtreetech.in", OrganizationId = null, ApplicationId = null, IsActive = true }
               );
            modelBuilder.Entity<Products>().HasData(
               new Products { ProductId = 1, ProductName = "KITANA", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now },
               new Products { ProductId = 2, ProductName = "CYRAX", CreatedTimestamp = DateTime.Now, ModifiedTimestamp = DateTime.Now }
               );
            modelBuilder.Entity<ProductsApplication>().HasData(
               new ProductsApplication { ProductAppId = 1, ApplicationId = 1, IsEnabled = true, ProductId = 1 },
               new ProductsApplication { ProductAppId = 2, ApplicationId = 1, IsEnabled = true, ProductId = 2 },
               new ProductsApplication { ProductAppId = 3, ApplicationId = 2, IsEnabled = true, ProductId = 1 },
               new ProductsApplication { ProductAppId = 4, ApplicationId = 2, IsEnabled = true, ProductId = 2 },
               new ProductsApplication { ProductAppId = 5, ApplicationId = 8, IsEnabled = true, ProductId = 1 },
               new ProductsApplication { ProductAppId = 6, ApplicationId = 8, IsEnabled = true, ProductId = 2 },
               new ProductsApplication { ProductAppId = 7, ApplicationId = 9, IsEnabled = true, ProductId = 1 },
               new ProductsApplication { ProductAppId = 8, ApplicationId = 9, IsEnabled = true, ProductId = 2 },
               new ProductsApplication { ProductAppId = 9, ApplicationId = 10, IsEnabled = true, ProductId = 1 },
               new ProductsApplication { ProductAppId = 10, ApplicationId = 10, IsEnabled = true, ProductId = 2 }
               );
        }

    }

}
