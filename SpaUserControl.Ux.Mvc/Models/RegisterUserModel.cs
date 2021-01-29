using System;
using System.ComponentModel.DataAnnotations;

namespace SpaUserControl.Ux.Mvc.Models
{
    public class RegisterUserModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get;  set; }
        public string Email { get;  set; }
        public string Password { get;  set; }
        public string ConfirmPassword { get;  set; }
    }
}