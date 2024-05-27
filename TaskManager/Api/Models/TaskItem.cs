using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Api.Models;

public class TaskItem
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    
    [Required, MaxLength(50)]
    public string Title { get; set; }
    
    [Required, MaxLength(500)]
    public string Description { get; set; }
    
    [Required]
    public DateTime DueDate { get; set; }
    
    public DateTime FinishedDate { get; set; }
    
    public bool IsCompleted { get; set; }
    
    public User User { get; set; }
}