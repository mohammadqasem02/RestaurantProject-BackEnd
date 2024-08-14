using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantProject.Models
{
    public class Register
    {
        [Key]
        public string RandomId { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Username
        {
            get; set;
        }

        [Required]
        public string Password
        {
            get; set;
        }

        [Required]
        public string Email
        {
            get; set;
        }


    }
}
