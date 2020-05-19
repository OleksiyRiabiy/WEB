﻿using System.ComponentModel.DataAnnotations;

 namespace Web1.Models.ViewModels
{
    public class LoginViewModel
    {
     
        public string Email { get; set; }
 
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}