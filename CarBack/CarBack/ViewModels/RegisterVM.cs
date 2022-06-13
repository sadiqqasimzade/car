﻿using System.ComponentModel.DataAnnotations;

namespace CarBack.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string Login { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,DataType(DataType.Password),Compare(nameof(Password)),Display(Name ="Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
