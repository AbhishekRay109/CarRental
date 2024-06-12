using Assignment.Api.Interfaces.BlogEngineInterfaces;
using Assignment.Api.Models.BlogModels;
using Assignment.Infrastructure.Repository.BlogRepositories;
using Assignment.Service.Model.BlogEngine;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Services.BlogServices
{
    public class BlogPostServices
    {
        public readonly IDBBlogPostRepository _dbBlogPostRepository;

        public BlogPostServices(IDBBlogPostRepository dbBlogPostRepository)
        {
            _dbBlogPostRepository = dbBlogPostRepository;
            
        }

        public async Task<BlogPosts> CreatePostAsync(BlogPostRQ request)
        {
            try
            {

                var postEntity = new BlogPosts
                {
                    Title = request.Title,
                    Content = request.Content,
                    Category = request.Category,
                    AuthorId = request.AuthorId,
                    Status = request.Status,
                    ImageMimeType = request.ImageMimeType,
                    IsActive = true,
                    CreationDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                };
                if (request.ImageData != null && request.ImageData.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await request.ImageData.CopyToAsync(memoryStream);
                        byte[] b = memoryStream.ToArray();
                        postEntity.ImageData = b;
                    }
                }

                await _dbBlogPostRepository.CreatePostAsync(postEntity);
                return postEntity;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating post: {ex.Message}");
                return null;
            }
        }

        public async Task<List<BlogPosts>> GetAllPostsAsync()
        {
            return await _dbBlogPostRepository.GetAllPostsAsync();
        }

        public async Task<List<BlogPosts>> GetPostsForTrialUserAsync()
        {
            return await _dbBlogPostRepository.GetPostsForTrialUserAsync();
        }

       
        public async Task<byte[]> GetImageUrlByPostIdAsync(int postId)
        {
            var imageData = await _dbBlogPostRepository.GetImageDataByIdAsync(postId);

            if (imageData != null && imageData.Length > 0)
            {
                
                return imageData;
            }

            return null;
        }

       
        public async Task<BlogPosts> UpdatePostAsync(int postId, BlogPostUpdateRQ request, int tokenUserId)
        {
            try
            {
                var existingPost = await _dbBlogPostRepository.GetPostByIdAsync(postId);

                if (existingPost.AuthorId == tokenUserId && existingPost.IsActive == true)
                {
                    existingPost.Title = request.Title;
                    existingPost.Content = request.Content;
                    existingPost.Category = request.Category;
                    existingPost.Status = request.Status;

                    if (request.ImageData != null && request.ImageData.Length > 0)
                    {

                        using (var memoryStream = new MemoryStream())
                        {
                            await request.ImageData.CopyToAsync(memoryStream);
                            existingPost.ImageData = memoryStream.ToArray();
                            existingPost.ImageMimeType = request.ImageMimeType;
                        }
                    }

                    var updatedpost = await _dbBlogPostRepository.UpdatePostAsync(existingPost);
                    return updatedpost;


                }
                return null;
                
  
  
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating post: {ex.Message}");
                throw;
            }
        }

        public async Task<BlogPosts> DeletePostAsync(int postId, int tokenUserId)
        {
            try
            {
                var existingPost = await _dbBlogPostRepository.GetPostByIdAsync(postId);

                if (existingPost.AuthorId == tokenUserId && existingPost.IsActive == true)
                {
                    existingPost.IsActive = false;

                    var deletedpost = await _dbBlogPostRepository.UpdatePostAsync(existingPost);
                    return deletedpost;
                }
                return null;

                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting post: {ex.Message}");
                throw;
            }
        }



    }
}

