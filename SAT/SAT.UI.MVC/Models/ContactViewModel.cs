using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SAT.UI.MVC.Models
{
    [Keyless]
    public class ContactViewModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Subject { get; set; } = null!;

        [Required]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; } = null!;
    }
}
