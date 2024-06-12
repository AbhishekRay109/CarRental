using Assignment.Api.Interfaces.BlogEngineInterfaces;
using Assignment.Api.Models.BlogModels;
using Assignment.Service.Model.BlogEngine;
using Assignment.Service.Services;
using Assignment.Service.Services.BlogServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Assignment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCommentController : ControllerBase
    {
        private readonly BlogCommentServices _blogCommentService;
        private readonly IDBBlogCommentRepository _dbBlogCommentRepository;
        private readonly AuthService _authService;



        public BlogCommentController(BlogCommentServices blogCommentServices, IDBBlogCommentRepository dBBlogCommentRepository, AuthService authService)
        {
            _blogCommentService = blogCommentServices;
            _dbBlogCommentRepository = dBBlogCommentRepository;
            _authService = authService;

        }


        [ProducesResponseType(typeof(BlogComments), 201)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]

        [HttpPost("comment")]
        [CustomAuthorize("blogauthor")]
        public async Task<ActionResult<BlogCommentRS>> CreateComment([FromBody] BlogCommentRQ commentRequest)
        {
            try
            {
                string authorizationHeader = Request.Headers["Authorization"].ToString();
                string token = authorizationHeader.Replace("Bearer ", "");
                token = await _authService.DecryptJwt(token);
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;

                var createdComment = await _blogCommentService.CreateCommentAsync(commentRequest);
                return CreatedAtAction(nameof(CreateComment), createdComment);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }


        [HttpGet("")]
        [CustomAuthorize("blogreader")]
        [ProducesResponseType(typeof(BlogComments), 200)]
        [ProducesResponseType(typeof(string), 401)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> GetApplication(int PostId)
        {
            try
            {
                string authorizationHeader = Request.Headers["Authorization"].ToString();
                string token = authorizationHeader.Replace("Bearer ", "");
                token = await _authService.DecryptJwt(token);
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;

                var blogComment = await _dbBlogCommentRepository.GetCommentIdByIdAsync(PostId);
                if (blogComment == null )
                {
                    return NotFound(new { StatusCode = 404, Message = "Comments Not Found" });
                }

                var comments = await _blogCommentService.GetCommentIdByIdAsync(PostId);
                return Ok(comments);
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpDelete("comments/{commentId}")]
        [CustomAuthorize("blogauthor")]
        public async Task<ActionResult> DeleteComment(int commentId)
        {
            try
            {
                string authorizationHeader = Request.Headers["Authorization"].ToString();
                string token = authorizationHeader.Replace("Bearer ", "");
                token = await _authService.DecryptJwt(token);
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
                string UserId = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "userId")?.Value;
                int tokenUserId = Convert.ToInt32(UserId);

                var deletedcomment = await _blogCommentService.DeleteCommentAsync(commentId, tokenUserId);
                if (deletedcomment != null)
                {
                    return Ok("Comment deleted successfully");
                }
                return BadRequest("Invalid User or comment doesn't exist");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }


        [HttpPut("{commentId}")]
        public async Task<IActionResult> UpdateComment([FromRoute] int commentId, [FromBody] BlogCommentUpdateRQ request)
        {
            string authorizationHeader = Request.Headers["Authorization"].ToString();
            string token = authorizationHeader.Replace("Bearer ", "");
            token = await _authService.DecryptJwt(token);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
            string UserId = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "userId")?.Value;
            int tokenUserId = Convert.ToInt32(UserId);

            var updatedcomment = await _blogCommentService.UpdateCommentAsync(commentId, request.Content, tokenUserId);

            if (updatedcomment != null)
            {
                return Ok("Comment updated successfully");
            }
            return BadRequest("Invalid User or comment doesn't exist");
        }

    }
}
