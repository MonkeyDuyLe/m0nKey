using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class ApplicationsUser :IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string? Address {  get; set; }
    }
}
