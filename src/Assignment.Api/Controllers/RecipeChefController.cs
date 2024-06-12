using Assignment.Api.Models.Recipe;
using Assignment.Service.Model;
using Assignment.Service.Model.Grades;
using Assignment.Service.Model.RecipeModels;
using Assignment.Service.Services;
using Assignment.Service.Services.RecipeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;

namespace Assignment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeChefController : BaseController
    {
        private readonly ChefService _chefService;
        private readonly AuthService _authService;
        private readonly RolesPermissionService _roleService;
        private readonly Serilog.Core.Logger logger;

        public RecipeChefController(ChefService chefService, RolesPermissionService roleService, AuthService authService, Serilog.Core.Logger logger) : base(logger)
        {
            _chefService = chefService;
            _authService = authService;
            _roleService = roleService;
            this.logger = logger;
        }

        [CustomAuthorize("view-recipe")]
        [HttpGet]
        public async Task<IActionResult> GetAllChef()
        {
            try
            {
                var result = await _chefService.GetAllChefsAsync();
                if (result == null)
                {
                    return NotFound("Chef not found");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", ErrorDetails = ex.Message });
            }
        }


        [CustomAuthorize("view-recipe")]
        [HttpGet("{chefId}")]
        public async Task<IActionResult> GetChefByName(int chefId)
        {
            try
            {
                var result = await _chefService.GetChefsAsync(chefId);
                if (result == null)
                {
                    return NotFound("Chef not found");
                }
                var result1 = new AddChefRS
                {
                    ChefId = result.ChefId,
                    ChefName = result.ChefName,
                    Email = result.EmailAddress
                };
                return Ok(result1);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", ErrorDetails = ex.Message });
            }
        }

        [CustomAuthorize("manage-chef")]
        [HttpPost]
        public async Task<IActionResult> AddChef(AddChefRQ addChefRQ)
        {
            try
            {
                var validName = _chefService.CheckChefName(addChefRQ.ChefName);
                if(!validName)
                {
                    return BadRequest("Give different username");
                }
                var validemail = _chefService.CheckEmail(addChefRQ.EmailAddress);
                if (!validemail)
                {
                    return BadRequest("email is already registered");
                }
                var result = await _chefService.AddChefs(addChefRQ);
                var chefDetails = new AddChefRS
                {
                    ChefId = result.ChefId,
                    ChefName = result.ChefName,
                    Email = result.EmailAddress
                };
                return Ok(chefDetails);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", ErrorDetails = ex.Message });
            }

        }

        [CustomAuthorize("manage-chef")]
        [HttpPut("{chefId}")]
        public async Task<IActionResult> UpdateChef(int chefId, UpdateChefRQ updateChefRQ)
        {
            try
            {
               
                var result = await _chefService.UpdateChef(chefId, updateChefRQ);
                if (result == null)
                {
                    return NotFound("Not found");
                }
                var chefDetails = new AddChefRS
                {
                    ChefId = result.ChefId,
                    ChefName = result.ChefName,
                    Email = result.EmailAddress
                };
                return Ok(chefDetails);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", ErrorDetails = ex.Message });
            }

        }


        [CustomAuthorize("manage-chef")]
        [HttpDelete("{chefId}")]
        public async Task<IActionResult> DeleteChef(int chefId)
        {
            try
            {
                var result = await _chefService.DeleteChef(chefId);
                if (!result)
                {
                    return NotFound("Not Found");
                }
                return Ok("Deleted Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", ErrorDetails = ex.Message });
            }

        }

        

        [HttpPost("GenerateChefToken")]
        public IActionResult GenerateChefToken(TokenRQ tokenRQ)
        {
            string jwtToken = _authService.GenerateJwtTokenForChef(tokenRQ.Email, tokenRQ.Password);
            if (!string.IsNullOrEmpty(jwtToken))
            {
                return Ok(new { Token = jwtToken });
            }
            else
            {
                return NotFound(new { Message = "Invalid email or password" });
            }
        }

        [HttpPost("GenerateSuperChefToken")]
        public IActionResult GenerateSuperChefToken(TokenRQ tokenRQ)
        {
            string jwtToken = _authService.GenerateJwtTokenForSuperChef(tokenRQ.Email, tokenRQ.Password);
            if (!string.IsNullOrEmpty(jwtToken))
            {
                return Ok(new { Token = jwtToken });
            }
            else
            {
                return NotFound(new { Message = "Invalid Email or password" });
            }
        }


        [HttpPost("GenerateUserToken")]
        public IActionResult GenerateToken()
        {
            string jwtToken = _authService.GenerateJwtTokenForUser();
            if (!string.IsNullOrEmpty(jwtToken))
            {
                return Ok(new { Token = jwtToken });
            }
            else
            {
                return NotFound(new { Message = "Invalid Email or password" });
            }
        }

    }
}
