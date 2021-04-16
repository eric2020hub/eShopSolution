using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class UserVm
    {
     
        public Guid Id { get; set; }
        [Display(Name = "Ten")]
        public string FirstName { get; set; }
        [Display(Name = "Ho")]
        public string LastName { get; set; }
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Dob")]
        public DateTime Dob { get; set; }

    }
}
