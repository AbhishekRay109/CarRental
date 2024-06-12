using Assignment.Infrastructure;
using Assignment.Service.Model;
using Assignment.Service.Model.CarRentalModels;
using Assignment.Service.Services;
using Assignment.Service.Services.CarRentalServices;
using Assignment.Service.Services.EventRegistrationServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace Assignment.Api.Controllers
{
    /// <summary>
    /// Controller for managing car rental customer operations.
    /// </summary>
    [ApiController]
    [Route("carRental/customer")]
    public class CarRental_CustomerController : ControllerBase
    {
        private readonly CarRental_CustomerService _customerService;
        private readonly AuthService _auth;
        /// <summary>
        /// Constructor for the CarRental_CustomerController.
        /// </summary>
        /// <param name="customerService">Injected CarRental_CustomerService instance.</param>
        /// <param name="auth">Injected AuthService instance.</param>
        public CarRental_CustomerController(CarRental_CustomerService customerService, AuthService auth)
        {
            _customerService = customerService;
            _auth = auth;
        }

        /// <summary>
        /// Retrieves a customer by their ID.
        /// </summary>
        /// <returns>Returns the customer details.</returns>
        [HttpGet()]
        public async Task<IActionResult> GetCustomerById()
        {
            try
            {
                var customerId = Convert.ToInt32(await CheckParams());
                var customer = await _customerService.GetCustomerById(customerId);
                if (customer == null)
                {
                    return NotFound();
                }
                return Ok(customer);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Creates a new customer profile.
        /// </summary>
        /// <param name="customerDetails">Details of the customer to be created.</param>
        /// <returns>Returns the newly created customer details.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateCustomerProfile([FromBody] CarRentalCustomerRQ customerDetails)
        {
            try
            {
                var createdCustomer = await _customerService.CreateCustomerProfile(customerDetails);
                return Ok(createdCustomer);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Updates an existing customer's information.
        /// </summary>
        /// <param name="customerDetails">Updated details of the customer.</param>
        /// <returns>Returns the updated customer details.</returns>
        [HttpPut()]
        public async Task<IActionResult> UpdateCustomer([FromBody] CarRentalCustomerRQ customerDetails)
        {
            try
            {
                var customerId = Convert.ToInt32(await CheckParams());
                var updatedCustomer = await _customerService.UpdateCustomerInformation(customerId, customerDetails);
                return Ok(updatedCustomer);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
        [HttpPost("signin")]
        public async Task<string> SignInUser([FromForm] AuthRQ authRQ)
        {
            return await _customerService.AuthenticationAsync(authRQ);
        }
        private async Task<string> CheckParams()
        {
            try
            {

                string JwtToken = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
                var handler = new JwtSecurityTokenHandler();
                var decryptedToken = await _auth.DecryptJwt(JwtToken);
                var tokens = handler.ReadJwtToken(decryptedToken);
                var claims = tokens.Claims;
                var userCode = claims.FirstOrDefault(c => c.Type == "customerId")?.Value;
                return userCode;
            }
            catch (Exception)
            {
                throw new Exception("unable to read the token, we are working on it........");
            }
        }
    }
}
