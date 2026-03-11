using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore; // Required for [Index]

namespace WebApplication1.Models.Entities
{
    [Table("Clients")]
    // Define unique constraints here
    [Index(nameof(ClientEmail), IsUnique = true)]
    [Index(nameof(PhoneNumber), IsUnique = true)]
    public class Clients
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Full Name is required for the Brotherhood.")]
        [StringLength(100)]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Email is mandatory.")]
        [EmailAddress]
        [StringLength(150)]
        public string ClientEmail { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone]
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters.")]
        public string Password { get; set; }
    }
}