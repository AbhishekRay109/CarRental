using Assignment.Api.Models.BlogModels;
using Assignment.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.BlogEngineInterfaces
{
    public interface IDBBlogSubscriptionRepository : IDBGenericRepository<BlogSubscription>
    {

        Task<List<BlogSubscription>> GetAllSubscriptionsAsync();

        

    }
}
