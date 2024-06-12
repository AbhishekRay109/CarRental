using Assignment.Api.Interfaces.BlogEngineInterfaces;
using Assignment.Api.Models.BlogModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.BlogRepositories
{
    public class BlogCommentRepository : IDBBlogCommentRepository
    {

        private readonly RaidenDBContext _context;

        public BlogCommentRepository(RaidenDBContext context)
        {
            _context = context;
        }

        public async Task<BlogComments> CreateCommentAsync(BlogComments comment)
        {
            _context.BlogComments.Add(comment);
            await _context.SaveChangesAsync();

            return comment;
        }

        public async Task<List<BlogComments>> GetCommentIdByIdAsync(int postId)
        {
            return await _context.BlogComments
                .Where(comment => comment.PostId == postId)
                .ToListAsync();
        }

        public async Task DeleteCommentAsync(int commentId)
        {
            var comment = await _context.BlogComments.FindAsync(commentId);

            if (comment != null)
            {
                _context.BlogComments.Remove(comment);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<BlogComments> GetCommentByIdAsync(int commentId)
        {
            return await _context.BlogComments.FindAsync(commentId);
        }

        public async Task<BlogComments> UpdateCommentAsync(BlogComments comment)
        {
            _context.Entry(comment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return comment;
        }

        
    }
}
