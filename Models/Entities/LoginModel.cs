using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities
{
   
        public class LoginModel
        {
            [Required]
            public string Identity { get; set; }

            [Required]
            public string Password { get; set; }
        }
    
}
