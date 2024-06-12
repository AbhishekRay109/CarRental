using Assignment.Api.Interfaces.BlogEngineInterfaces;
using Assignment.Api.Models.BlogModels;
using Assignment.Infrastructure.Repository.BlogRepositories;
using Assignment.Service.Model.BlogEngine;
using Assignment.Service.Services;
using Assignment.Service.Services.BlogServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Assignment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly BlogPostServices _blogPostServices;
        private readonly IDBBlogPostRepository _dBBlogPostRepository;
        private readonly AuthService _authService;

        public BlogPostController(BlogPostServices blogPostServices, IDBBlogPostRepository dBBlogPostRepository, AuthService authService)
        {
            _blogPostServices = blogPostServices;
            this._dBBlogPostRepository = dBBlogPostRepository;
            _authService = authService;
        }


        [HttpPost("")]
        [CustomAuthorize("blogauthor")]
        [ProducesResponseType(typeof(BlogPosts), 201)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<ActionResult<BlogPostRS>> CreateBlogPost([FromForm] BlogPostRQ request)
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

                if (tokenUserId == request.AuthorId)
                {
                    if (request.ImageData != null && request.ImageData.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await request.ImageData.CopyToAsync(memoryStream);
                            byte[] b = memoryStream.ToArray();

                        }
                    }
                    
                }
                await _blogPostServices.CreatePostAsync(request);
                return Ok("Post Created");

            }
            catch(Exception ex)
            {
                return StatusCode(500, $"An error occured: {ex.Message}");
            }

        }

        
        [HttpGet("all")]
        [CustomAuthorize("blogauthor")]
        public async Task<ActionResult<List<BlogPostRS>>> GetAllPosts()
        {
            var posts = await _blogPostServices.GetAllPostsAsync();
            return Ok(posts);
        }

        [HttpGet("trial")]
        [CustomAuthorize("blogreader")]
        public async Task<ActionResult<List<BlogPostRS>>> GetPostsForTrialUser()
        {
            var posts = await _blogPostServices.GetPostsForTrialUserAsync();
            return Ok(posts);
        }


        [HttpGet("{postId}/image")]
        [CustomAuthorize("blogauthor")]
        public async Task<IActionResult> GetImageByPostId(int postId)
        {
            var imageData = await _blogPostServices.GetImageUrlByPostIdAsync(postId);

            return File(imageData, "image/png"); 
        }

        
        [HttpPut("{postId}")]
        [CustomAuthorize("blogauthor")]
        public async Task<IActionResult> UpdatePost([FromRoute] int postId, [FromForm] BlogPostUpdateRQ request)
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


                if (request.ImageData != null && request.ImageData.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await request.ImageData.CopyToAsync(memoryStream);
                        byte[] b = memoryStream.ToArray();

                    }
                }
                var updatedpost = await _blogPostServices.UpdatePostAsync(postId, request, tokenUserId);

                if (updatedpost != null)
                {
                    return Ok("Post updated successfully");
                }

                return BadRequest("Invalid User or Post doesn't exist");
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpDelete("{postId}")]
        [CustomAuthorize("blogauthor")]

        public async Task<IActionResult> DeletePost([FromRoute] int postId)
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

                var deletedpost = await _blogPostServices.DeletePostAsync(postId, tokenUserId);

                if (deletedpost != null)
                {
                    return Ok("Post deleted successfully");
                }

                return BadRequest("Invalid User or Post doesn't exist");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

    }

}
