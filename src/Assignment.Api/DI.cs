using Amazon.CloudWatchLogs.Model;
using Microsoft.Extensions.Configuration;
using Assignment.Api.Controllers;
using Assignment.Api.Interfaces;
using Assignment.Core.Interfaces;
using Assignment.Infrastructure.AuditLog;
using Assignment.Infrastructure.Interfaces;
using Assignment.Infrastructure.Notification;
using Assignment.Infrastructure.Raiden;
using Assignment.Infrastructure.Repository;
using Assignment.Service.Services;
using Serilog.Core;
using System.ComponentModel;
using static Assignment.Api.Controllers.GoogleWorkSpaceController;
using IdentityServer4.Services;
using Assignment.Service.Services.RecipeService;
using Assignment.Api.Interfaces.RecipeInterfaces;
using Assignment.Infrastructure.Repository.RecipeRepository;
using Assignment.Api.Interfaces.ExpenseInterfaces;
using Assignment.Infrastructure.Repository.ExpenseRepository;
using Assignment.Service.Services.ExpenseService;
using Assignment.Service.Model.ExpenseModel;
using Assignment.Api.Interfaces.EventRegistrationInterfaces;
using Assignment.Infrastructure.Repository.EventRegistrationRepositories;
using Assignment.Service.Services.EventRegistrationServices;
using Assignment.Infrastructure.Repository.Inventory;
using Assignment.Service.Services.Inventory;
using Assignment.Api.Interfaces.Inventory;
using Assignment.Service.Services.QuizGame;
using Assignment.Infrastructure.Repository.QuizGame;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Infrastructure.Repository.QuizGameRepositories;
using Assignment.Service.Services.QuizGameServices;
using Assignment.Service.Services.Grades;
using Assignment.Api.Interfaces.Grades;
using Assignment.Infrastructure.Repository.Grades;
using Assignment.Api.Interfaces.CarRentalInterfaces;
using Assignment.Service.Services.CarRentalServices;
using Assignment.Infrastructure.Repository.CarRentalRepository;
using Assignment.Service.Model.EventRegistration;
using Assignment.Api.Interfaces.BlogEngineInterfaces;
using Assignment.Infrastructure.Repository.BlogRepositories;
using Assignment.Service.Services.BlogServices;
using Microsoft.AspNetCore.Identity;
using Assignment.Infrastructure.Repository.TaskUser;
using Assignment.Service.Services.TaskUserServices;
using Assignment.Infrastructure.Repository.TaskManager;
using Assignment.Service.Services.TaskServices;
using Assignment.Api.Interfaces.TaskManagement;
using Quartz;
using Assignment.Infrastructure.Repository.BookLibrary;
using Assignment.Service.Services.BookLibraryService;
using Assignment.Api.Interfaces.BookLibraryInterfaces;

namespace Assignment.Api
{
    internal static partial class DI
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            var logger = Logger.CreateLogger(configuration);
            CS_AppServices(services, configuration, logger);
        }
        private static void CS_AppServices(IServiceCollection services, IConfiguration configuration, Serilog.Core.Logger logger)
        {
            services.AddHttpClient<LoggingService>();
            services.AddTransient(typeof(GenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient(typeof(IDBRolesPermissionsRepository), typeof(RolesPermissionsRepository));
            services.AddTransient(typeof(RolesPermissionService), typeof(RolesPermissionService));
            services.AddScoped(typeof(IDBOrganization), typeof(OrganizationRepository));
            services.AddTransient(typeof(AuthService), typeof(AuthService));
            services.AddTransient(typeof(IDBAuthRepository), typeof(AuthRepository));
            services.AddTransient(typeof(IDBUserRepository), typeof(UserRepository));
            services.AddTransient(typeof(UserService), typeof(UserService));
            services.AddScoped(typeof(ApplicationsService), typeof(ApplicationsService));
            services.AddScoped(typeof(IDBApplicationRepository), typeof(ApplicationRepository));
            services.AddScoped(typeof(AuthController), typeof(AuthController));
            services.AddScoped(typeof(GoogleWorkSpaceService), typeof(GoogleWorkSpaceService));
            services.AddScoped(typeof(IDBGoogleWorkSpaceRepository), typeof(GoogleWorkSpaceRepository));
            services.AddScoped(typeof(CustomAuthorizationService), typeof(CustomAuthorizationService));
            services.AddScoped(typeof(IDBProductsRepository), typeof(ProductsRepository));
            services.AddScoped(typeof(ProductsService), typeof(ProductsService));
            services.AddScoped(typeof(INotificationService), typeof(NotificationService));
            services.AddScoped(typeof(IRaidenService), typeof(RaidenService));

            services.AddScoped(typeof(CarRental_CarService), typeof(CarRental_CarService));
            services.AddScoped(typeof(IDBCarRental_Car), typeof(CarRental_CarRepository));
            services.AddScoped(typeof(CarRental_CustomerService), typeof(CarRental_CustomerService));
            services.AddScoped(typeof(IDBCarRental_Customer), typeof(CarRental_CustomerRepository));
            services.AddScoped(typeof(CarRental_ImageService), typeof(CarRental_ImageService));
            services.AddScoped(typeof(IDBCarRental_Images), typeof(CarRental_ImagesRepository));
            services.AddScoped(typeof(CarRental_BookingService), typeof(CarRental_BookingService));
            services.AddScoped(typeof(IDBCarRental_Booking), typeof(CarRental_BookingRepository));

            services.AddHttpClient<GoogleWorkSpaceController>();
            services.AddHttpClient<NotificationService>();
            services.AddHttpClient<RaidenService>();
            services.AddScoped(typeof(OrganizationService), typeof(OrganizationService));
            services.AddScoped(typeof(ILoggingService), typeof(LoggingService));

            //Event Registration services
            services.AddScoped(typeof(IDBEventRegistrationUserRepository), typeof(EventRegistrationUsersRepository));
            services.AddScoped(typeof(EventRegistrationUserService), typeof(EventRegistrationUserService));
            services.AddScoped(typeof(EventRegistrationEventService), typeof(EventRegistrationEventService));
            services.AddScoped(typeof(IDBEventRegistrationEventRepository), typeof(EventRegistrationEventRepository));
            services.AddScoped(typeof(IDBEventRegistrationRepository), typeof(EventRegistrationRepository));
            services.AddScoped(typeof(EventRegistrationService), typeof(EventRegistrationService));
            services.AddSingleton<Serilog.Core.Logger>(logger);





























           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            services.AddScoped(typeof(IDBTaskUserRepository), typeof(TaskUserRepository));
            services.AddScoped(typeof(TaskUserService),typeof(TaskUserService));
            services.AddScoped(typeof(IDBTaskRepository),typeof(TaskRepository));
            services.AddScoped(typeof(TaskService),typeof(TaskService));
            services.AddTransient<ChefService>();
            services.AddTransient<RecipesService>();
            services.AddScoped(typeof(IDBChefRepository), typeof(RecipeChefRepository));
            services.AddScoped(typeof(IDBRecipeMappingRepository), typeof(RecipeMappingRepository));
            services.AddScoped(typeof(IDBRecipeRepository), typeof(RecipeRepository));
            


            //Quiz Game Application
            services.AddScoped(typeof(IDBQuizUserRepository), typeof(QuizUserRepository));
            services.AddScoped(typeof(QuizUserService), typeof(QuizUserService));
            services.AddScoped(typeof(IDBQuizCategoryRepository), typeof(QuizCategoryRepository));
            services.AddScoped(typeof(QuizCategoryService), typeof(QuizCategoryService));
            services.AddScoped(typeof(IDBQuizLevelRepository), typeof(QuizLevelRepository));
            services.AddScoped(typeof(QuizLevelService), typeof(QuizLevelService));
            services.AddScoped(typeof(IDBQuizQuestionRepository), typeof(QuizQuestionRepository));
            services.AddScoped(typeof(QuizQuestionService), typeof(QuizQuestionService));
            services.AddScoped(typeof(IDBQuizAnswerRepository), typeof(QuizAnswerRepository));
            services.AddScoped(typeof(QuizAnswerService), typeof(QuizAnswerService));
            services.AddScoped(typeof(IDBQuizPlayRepository), typeof(QuizPlayRepository));
            services.AddScoped(typeof(QuizPlayService), typeof(QuizPlayService));
            services.AddScoped(typeof(IDBQuizDetailRepository), typeof(QuizDetailRepository));
            services.AddScoped(typeof(QuizDetailService), typeof(QuizDetailService));
            services.AddScoped(typeof(IDBQuizScoreRepository), typeof(QuizScoreRepository));
            services.AddScoped(typeof(QuizScoreService), typeof(QuizScoreService));

            //Expense Tracker Services
            services.AddScoped<IDBExpenseUserRepository, ExpenseTrackerExpenseUserRepository>();
            services.AddScoped<IDBBudgetLedgerRepository, ExpenseTrackerBudgetLedgerRepository>();
            services.AddScoped<IDBCategoryRepository,ExpenseTrackerCategoryRepository>();
            services.AddScoped<IDBExpensesRepository, ExpenseTrackerExpensesRepository>();
            services.AddScoped<ExpenseTrackerExpenseUserService>();
            services.AddScoped<ExpenseTrackerSecurity>();
            services.AddScoped<ResponseHandler>();
            services.AddScoped<ExpenseTrackerLedgerService>();
            services.AddScoped<ExpenseTrackerCategoryService>();
            services.AddScoped<ExpenseTrackerExpensesService>();
            services.AddQuartz(opt => {
                opt.UseMicrosoftDependencyInjectionJobFactory();
                var jobKey = new JobKey("EmailSendingJob");
                opt.AddJob<EmailJob>(options => options.WithIdentity(jobKey));
                opt.AddTrigger(options => {
                    options.ForJob(jobKey)
                    .WithIdentity("EmailTrigger")
                    .WithCronSchedule("0 0 10 1 * ?");
                });
            });
            services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);
          
            //Inventory Management System
            services.AddScoped(typeof(InProductService), typeof(InProductService));
            services.AddScoped(typeof(IDBInProductRepository), typeof(InProductRepository));
            services.AddScoped(typeof(IDBInOrderRepository), typeof(InOrderRepository));
            services.AddScoped(typeof(InOrderService), typeof(InOrderService));
            services.AddScoped(typeof(InventoryService),typeof(InventoryService));
            services.AddScoped(typeof(IDBInventoryRepository),typeof(InventoryRepository));
            services.AddScoped(typeof(IDBInCategoryRepository),typeof(InCategoryRepository));
            services.AddScoped(typeof(InCategoryService), typeof(InCategoryService));

            // Grade Service
            services.AddScoped<GradeTeacherService>();
            services.AddScoped(typeof(IDBGradeTeacherRepository), typeof(GradeTeacherRepository));
            services.AddScoped<GradeClassService>();
            services.AddScoped(typeof(IDBGradeClassRepository), typeof(GradeClassRepository));
            services.AddScoped<GradeStudentService>();
            services.AddScoped(typeof(IDBGradeStudentRepository), typeof(GradeStudentRepository));

            //Book Library
            services.AddScoped(typeof(BookService), typeof(BookService));
            services.AddScoped(typeof(IDBBookRepository), typeof(BookRepository));
            services.AddScoped(typeof(AuthorService), typeof(AuthorService));
            services.AddScoped(typeof(IDBAuthorRepository), typeof(AuthorRepository));
            services.AddScoped(typeof(BookUserService), typeof(BookUserService));
            services.AddScoped(typeof(IDBBookUserRepository), typeof(BookUserRepository));
            services.AddScoped(typeof(BorrowedBookService), typeof(BorrowedBookService));
            services.AddScoped(typeof(IDBBorrowedBookRepository), typeof(BorrowedBookRepository));
            services.AddScoped(typeof(BorrowedBooksController), typeof(BorrowedBooksController));
            //services.AddScoped(typeof(IPasswordHasher<object>), typeof(BookUserService));


            //BlogEngine
            services.AddScoped(typeof(IDBBlogUserRepository), typeof(BlogUserRepository));
            services.AddScoped<BlogUserServices>();

            services.AddScoped(typeof(IDBBlogSubscriptionRepository), typeof(BlogSubscriptionRepository));
            services.AddScoped<BlogSubscriptionServices>();

            services.AddScoped(typeof(IDBBlogPostRepository), typeof(BlogPostRepository));
            services.AddScoped<BlogPostServices>();
            services.AddScoped<GradeSubjectService>();
            services.AddScoped(typeof(IDBGradeSubjectRepository), typeof(GradeSubjectRepository));
            services.AddScoped<GradeGradeService>();
            services.AddScoped(typeof(IDBGradeGradeRepository), typeof(GradeGradeRepository));

            services.AddScoped(typeof(IDBBlogCommentRepository), typeof(BlogCommentRepository));
            services.AddScoped<BlogCommentServices>();

        }
    }
}