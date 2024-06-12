using Assignment.Service.Services.BlogServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment.Api.Interfaces.BlogEngineInterfaces;
using Assignment.Service.Model.BlogEngine;

namespace Assignment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogSubscriptionController : ControllerBase
    {
        private readonly BlogSubscriptionServices _blogSubscriptionServices;
        private readonly IDBBlogSubscriptionRepository _dbBlogSubscriptionRepository;

        public BlogSubscriptionController(BlogSubscriptionServices blogSubscriptionServices, IDBBlogSubscriptionRepository dBBlogSubscriptionRepository) 
        {
            _blogSubscriptionServices = blogSubscriptionServices;
            _dbBlogSubscriptionRepository = dBBlogSubscriptionRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetBlogSubscriptions()
        {
            try
            {
                var blogSubscriptions = await _blogSubscriptionServices.GetAllBlogSubscriptions();

                if (blogSubscriptions != null && blogSubscriptions.Any())
                {
                    var response = blogSubscriptions.Select(subscription => new BlogSubscriptionRS
                    {
                        Role = subscription.Role,
                        SubscriptionType = subscription.SubscriptionType,
                        SubscriptionLimit = subscription.SubscriptionLimit
                    });

                    return Ok(response);
                }
                else
                {
                    return NotFound("No blog subscriptions found.");
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error retrieving Subscriptions: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }


    }
}
