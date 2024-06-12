using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Service.Model
{
    public class AddChefRQ : BaseRQ
    {
        [Required]
        public string ChefName{get;set;}
        [EmailAddress]
        public string EmailAddress { get;set;} 
        public string Password {  get;set;}
    }
}