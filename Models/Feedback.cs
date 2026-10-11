using System.ComponentModel.DataAnnotations;
namespace Practical_7_Feedback_Management.Models;
public class Feedback
{
    [Required(ErrorMessage = "Please enter your name.")]
    [StringLength(60, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 60 characters.")]
    [Display(Name = "Full Name")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your email address.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    [Display(Name = "Email Address")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please choose a rating.")]
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    [Display(Name = "Rating")]
    public int? Rating { get; set; }

    [Required(ErrorMessage = "Please enter your feedback.")]
    [StringLength(500, MinimumLength = 10, ErrorMessage = "Feedback must be between 10 and 500 characters.")]
    [Display(Name = "Your Feedback")]
    public string Comments { get; set; } = string.Empty;
}