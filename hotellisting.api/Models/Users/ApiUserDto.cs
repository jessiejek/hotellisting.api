﻿using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace hotellisting.api.Models.Users
{
    public class ApiUserDto : LoginDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

    }
}
