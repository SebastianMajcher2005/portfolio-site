using System.ComponentModel.DataAnnotations;

namespace portfolio_site.Models
{
    public class Mail
    {
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Message is required!")]
        public string Message { get; set; }
    }
}
