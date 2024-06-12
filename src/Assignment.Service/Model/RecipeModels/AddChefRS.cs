using System.ComponentModel.DataAnnotations;

namespace Assignment.Service.Model
{
    public class AddChefRS : BaseRS
    {
        public int ChefId{get;set;}
        public string ChefName{get;set;}
        public string Email{get;set;}
    }
}