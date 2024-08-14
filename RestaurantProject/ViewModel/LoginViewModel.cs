﻿using System.ComponentModel.DataAnnotations;

namespace RestaurantProject.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Email
        {
            get; set;
        }

        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get; set;
        }
    }
}
