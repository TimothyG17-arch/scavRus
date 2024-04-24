using System.ComponentModel.DataAnnotations;
namespace ScavengeRUs.Models.Entities;
/// <summary>
/// This is a model for taking in input from a user and sending an email to a specific user.
/// </summary>
public class SendEmailViewModel
    {
        [Microsoft.Build.Framework.Required]
        [EmailAddress]
        public string Email { get; set; }
    
        [Microsoft.Build.Framework.Required]
        public string Subject { get; set; }
    
        [Microsoft.Build.Framework.Required]
        public string Body { get; set; }
    }
