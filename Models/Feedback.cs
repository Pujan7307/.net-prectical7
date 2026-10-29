
using System.ComponentModel.DataAnnotations;

namespace FeedbackManagement.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter the subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please select a rating")]
        public string Rating { get; set; }

        [Required(ErrorMessage = "Please enter your comments")]
        [StringLength(500, MinimumLength = 10,
            ErrorMessage = "Comments must be 10 to 500 characters")]
        public string Comments { get; set; }
    }
}
