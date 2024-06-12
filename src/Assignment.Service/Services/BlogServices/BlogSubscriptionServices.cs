using Assignment.Api.Interfaces.BlogEngineInterfaces;
using Assignment.Api.Models.BlogModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Services.BlogServices
{
    public class BlogSubscriptionServices
    {
        private readonly IDBBlogSubscriptionRepository _blogSubscriptionRepository;


        public BlogSubscriptionServices(IDBBlogSubscriptionRepository blogSubscriptionRepository)
        {
            _blogSubscriptionRepository = blogSubscriptionRepository;

        }


        public async Task<List<BlogSubscription>> GetAllBlogSubscriptions()
        {
            try
            {
                var blogSubscriptions = await _blogSubscriptionRepository.GetAllAsync();

                return blogSubscriptions.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving blog subscriptions: {ex.Message}");
                throw; 
            }
        }

    }
}
