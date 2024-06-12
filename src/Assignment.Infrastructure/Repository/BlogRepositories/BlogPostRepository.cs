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
    public class BlogPostRepository : IDBBlogPostRepository
    {

        private readonly RaidenDBContext _context;

        public BlogPostRepository(RaidenDBContext context)
        {
            _context = context;
        }

        public async Task<BlogPosts> CreatePostAsync(BlogPosts blogPosts)
        {
            _context.BlogPosts.Add(blogPosts);
            await _context.SaveChangesAsync();

            return blogPosts;
        }

        public async Task<List<BlogPosts>> GetAllPostsAsync()
        {
            return await _context.BlogPosts.Where(post => post.IsActive).ToListAsync();
        }

        public async Task<List<BlogPosts>> GetPostsForTrialUserAsync()
        {
            var trialUserPosts = await _context.BlogPosts.Where(post => post.IsActive).Take(10).ToListAsync();

            if (trialUserPosts.Count < 10)
            {
                return trialUserPosts; 
            }

            var messagePost = new BlogPosts
            {
                Title = "Upgrade Your Subscription",
                Content = "Upgrade the subscription to premium to see all the posts.",
               
            };

            trialUserPosts.Add(messagePost);

            return trialUserPosts;
        }


        public async Task<byte[]> GetImageDataByIdAsync(int postId)
        {
            var post = await _context.BlogPosts.FindAsync(postId);

            return post?.ImageData;
        }

        // Inside BlogPostRepository
        public async Task<BlogPosts> GetPostByIdAsync(int postId)
        {
            return await _context.BlogPosts.FindAsync(postId);
        }

        

        public async Task<BlogPosts> UpdatePostAsync(BlogPosts blogPosts)
        {
            _context.Entry(blogPosts).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return blogPosts;
        }

    }



}
