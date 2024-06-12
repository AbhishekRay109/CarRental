using Assignment.Api.Models.BlogModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.BlogEngineInterfaces
{
    public interface IDBBlogCommentRepository
    {
        Task<BlogComments> CreateCommentAsync(BlogComments comment);

        Task<List<BlogComments>> GetCommentIdByIdAsync(int postId);

        Task DeleteCommentAsync(int commentId);

        //Task UpdateCommentAsync(int commentId, string Content);

        Task<BlogComments> GetCommentByIdAsync(int commentId);

        Task<BlogComments> UpdateCommentAsync(BlogComments comment);
    }
}
