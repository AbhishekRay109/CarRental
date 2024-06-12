using Assignment.Api.Interfaces.BlogEngineInterfaces;
using Assignment.Api.Models.BlogModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.BlogRepositories
{
    public class BlogSubscriptionRepository : GenericRepository<BlogSubscription>, IDBBlogSubscriptionRepository
    {
        private readonly RaidenDBContext _context;

        public BlogSubscriptionRepository(RaidenDBContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<List<BlogSubscription>> GetAllSubscriptionsAsync()
        {
            return await _context.BlogSubscriptions.ToListAsync();
        }
    }
}
