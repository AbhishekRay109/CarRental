using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
namespace Assignment.Service.Services
{
    public interface IPermissionMappingService
    {
        string[] GetPermissionsForIdentifier(string identifier);
    }

    public class PermissionMappingService : IPermissionMappingService
    {
        private readonly Dictionary<string, string[]> _permissionMappings = new Dictionary<string, string[]>
    {
        {"app-management", new[] { "appsetting::create", "appsetting::delete" } },
        {"app-permissions-all", new[] { "appsetting::create", "appsetting::delete", "appsetting::view", "appsetting::edit" } },
        {"org-management", new[] { "orgsetting::create", "orgsetting::delete" } },
        {"org-permissions-all", new[] { "orgsetting::create", "orgsetting::delete", "orgsetting::view", "orgsetting::edit" } },
        {"view-roles-permissions", new[] { "user::view" } },
        {"manage-org-users", new[] { "user::create", "user::delete", } },
        {"view-users", new[] { "user::view" } },
        {"manage-app-users", new[] { "user::create", "user::delete", } },
        {"carRentalAdmin" , new[]{"car::create", "car::delete", "car::view", "car::edit", "image::create","image::view","booking::create","booking::update","booking::view"}},
        {"carRentalCustomer", new[]{ "car::view", "image::view", "booking::create", "booking::update", "booking::view" } },
        {"enable-disable-product", new[] { "appsetting::enable", "appsetting::disable" } },
        {"organizer", new[] { "event::create","event::delete","event::edit"} },
        {"audience", new[] { "event::view"} },
        {"manage-chef", new[] { "chef::create", "chef::update", "chef::delete" } },
        {"manage-recipe", new[] { "recipe::create", "recipe::update", "recipe::delete"} },
        {"view-recipe", new[] { "recipe::view" } },


        {"task-admin", new[] { "Task::delete","Task::create" } },
        {"task-user", new[] { "Task::view","Task::update" } },
        {"task-all", new[] { "Task::delete","Task::create","Task::view","Task::update" } },

        //QuizGame
        {"quiz-admin", new[] {"user::view","questions::create","questions::delete","questions::fetch","categories::create","categories::update","categories::fetch","categories::delete","answer::create","answer::delete","answer::fetch","quiz-details::fetch","levels::fetch"}},
        {"quiz-user", new[] {"quiz::view","quiz::play","score::view","leaderboard::view",}},

        {"authorizedPrincipal", new[] {"teacher::create", "teacher::delete", "teacher::update", "teacher::view", "class::create", "class::view", "class::delete", "class::update" } },
        {"authorizedTeacher", new[] { "student::create", "student::update", "student::delete", "grade::create", "grade::view", "grade::delete", "grade::update", "subject::create", "subject::delete", "subject::update" } },
        {"authorizedStudent", new[] { "student::view" } },
        

        {"blogreader", new[] { "bloguser::create", "bloguser::view", "blogpost::view","blogcomment::view", "blogsubscription::view", } },
        {"blogauthor", new[] { "bloguser::create", "bloguser::view", "bloguser::edit", "bloguser::delete", "blogpost::create", "blogpost::view", "blogpost::edit", "blogpost::delete", "blogcomment::create", "blogcomment::view", "blogcomment::edit", "blogcomment::delete", "blogsubscription::view", } },

         //BookLibrary
        {"book-admin", new[] { "book::delete", "book::fetch", "book::edit", "book::create", "author::create", "author::update", "author::fetch", "author::delete", "bookuser::fetch", "bookuser::create", "bookuser::delete", "bookuser::update", "borrowedbook::update", "borrowedbook::create", "borrowedbook::delete", "borrowedbook::fetch" } },
        {"book-user", new[]  { "book::fetch", "author::fetch", "bookuser::fetch", "bookuser::create", "bookuser::update", "bookuser::delete", "borrowedbook::fetch", "borrowedbook::create", "borrowedbook::update"} }
    };
        public string[] GetPermissionsForIdentifier(string identifier)
        {
            return _permissionMappings.TryGetValue(identifier, out var permissions) ? permissions : Array.Empty<string>();
        }



    }
}
