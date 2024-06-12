using Assignment.Api.Interfaces.BlogEngineInterfaces;
using Assignment.Api.Models.BlogModels;
using Assignment.Infrastructure.Repository.BlogRepositories;
using Assignment.Service.Model.BlogEngine;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment.Service.Services.BlogServices
{
    public class BlogCommentServices
    {

        private readonly IDBBlogCommentRepository _dbBlogCommentRepository;


        public BlogCommentServices(IDBBlogCommentRepository dbBlogCommentRepository)
        {
            _dbBlogCommentRepository = dbBlogCommentRepository;
        }

        public async Task<BlogComments> CreateCommentAsync(BlogCommentRQ commentRequest)
        {
            
            var commentEntity = new BlogComments
            {
                PostId = commentRequest.PostID,
                Content = commentRequest.Content,
                AuthorId = commentRequest.AuthorID,
                CreationDate = DateTime.Now,
                //IsActive = true
            };

            return await _dbBlogCommentRepository.CreateCommentAsync(commentEntity);
        }

        public async Task<List<BlogCommentRS>> GetCommentIdByIdAsync(int postId)
        {
            var blogComments =  await _dbBlogCommentRepository.GetCommentIdByIdAsync(postId);

            var rs = blogComments.Select(comment => new BlogCommentRS
            {
                CommentID = comment.CommentId,
                Content = comment.Content,
                AuthorID = comment.AuthorId,
                CreationDate = comment.CreationDate
            }).ToList();

            return rs;
        }

        public async Task<BlogComments> DeleteCommentAsync(int commentId, int tokenUserId)
        {
            
            var deletecomment = await _dbBlogCommentRepository.GetCommentByIdAsync(commentId);

            if (deletecomment.AuthorId == tokenUserId && deletecomment.IsActive == true)
            {
                deletecomment.IsActive = false;

                var deletedcomment = await _dbBlogCommentRepository.UpdateCommentAsync(deletecomment);
                return deletedcomment;
            }
            return null;
        }

        

        public async Task<BlogComments> UpdateCommentAsync(int commentId, string newContent, int tokenUserId)
        {
            var existingComment = await _dbBlogCommentRepository.GetCommentByIdAsync(commentId);

            if (existingComment != null && existingComment.AuthorId == tokenUserId && existingComment.IsActive == true)
            {
                existingComment.Content = newContent;
                var updatedcomment = await _dbBlogCommentRepository.UpdateCommentAsync(existingComment);
                return updatedcomment;
                
            }
            return null;
            
        }

    }
}
