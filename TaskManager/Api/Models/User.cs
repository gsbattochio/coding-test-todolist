using System.ComponentModel.DataAnnotations;

namespace Api.Models;

public class User
{
    [Key]
    public int UserId { get; set; }
    
    [Required, MaxLength(50)]
    public string Name { get; set; }
    
    [Required, MaxLength(30)]
    public string Username { get; set; }
    
    [Required]
    public string Email { get; set; }
    
    [Required, RegularExpression(@"^[a-zA-Z][a-zA-Z0-9._]*$")]
    public string PasswordHash { get; set; }
    
    public ICollection<TaskItem> Tasks { get; set; }
}