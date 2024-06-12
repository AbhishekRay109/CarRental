using Assignment.Api.Models.BlogModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.BlogEngineInterfaces
{
    public interface IDBBlogPostRepository
    {
        Task<BlogPosts> CreatePostAsync(BlogPosts blogPosts);

        Task<List<BlogPosts>> GetAllPostsAsync();

        Task<List<BlogPosts>> GetPostsForTrialUserAsync();

        Task<byte[]> GetImageDataByIdAsync(int postId);

        Task<BlogPosts> GetPostByIdAsync(int postId);

        //Task UpdatePostAsync(BlogPosts post);

        Task<BlogPosts> UpdatePostAsync(BlogPosts blogPosts);




    }
}
