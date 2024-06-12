using Amazon.Util.Internal.PlatformServices;
using Assignment.Api.Models;
using Assignment.Api.Models.BlogModels;
using Assignment.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.BlogEngineInterfaces
{
    public interface IDBBlogUserRepository : IDBGenericRepository<BlogUsers>
    {
        Task<BlogUsers> GetUsernameByIdAsync(string username);

        Task<BlogUsers> GetUserIdByIdAsync(int userId);

        Task<BlogUsers> GetUserByUsernameAsync(string username);

        Task<BlogUsers> GetUserByIdAsync(int userId);

        Task<BlogUsers> UpdateUserAsync(BlogUsers user);

    }
}
