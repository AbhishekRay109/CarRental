using Assignment.Service.Model.ExpenseModel;
using Assignment.Service.Services.ExpenseService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class ExpenseTrackerExpenseUserController : BaseController
    {
        private readonly ExpenseTrackerExpenseUserService userService;
        public ExpenseTrackerExpenseUserController(ExpenseTrackerExpenseUserService userService, Serilog.Core.Logger logger) : base(logger)
        {
            this.userService = userService;
        }

        [HttpPost("/register")]
        public async Task<IActionResult> LoginUser([FromBody] ExpenseTrackerRegisterUserRQ registerUser)
        {
            var response = await userService.registerUser(registerUser);
            if (response != null)
            {
                return Ok(ResponseHandler.HandleSuccess("You have been registered as a new user!", response));
            }
            return Ok(ResponseHandler.HandleError<ExpenseTrackerRegisterUserRQ>("BadRequest", "User has been already registered"));
        }

        [HttpPost("/signin")]
        public async Task<IActionResult> SignInUser([FromBody] ExpenseTrackerUserSigninRQ user)
        {
            try
            {
                var response = await userService.UserSignin(user);
                return Ok(ResponseHandler.HandleSuccess("Valid User! Successfully logged in!", response));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<ExpenseTrackerUserSigninRS>("Unauthorized", ex.Message));
            }
        }
    }
}
