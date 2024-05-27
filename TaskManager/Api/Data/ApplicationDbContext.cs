using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<TaskItem> Tasks { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .Property(b => b.UserId)
            .IsRequired();
        
        modelBuilder.Entity<User>()
            .Property(b => b.Username)
            .IsRequired();
        
        modelBuilder.Entity<User>()
            .Property(b => b.Email)
            .IsRequired();
        
        modelBuilder.Entity<TaskItem>()
            .Property(b => b.Id)
            .IsRequired();
        
        modelBuilder.Entity<TaskItem>()
            .Property(b => b.DueDate)
            .IsRequired();
        
        modelBuilder.Entity<TaskItem>()
            .Property(b => b.UserId)
            .IsRequired();
        
        modelBuilder.Entity<TaskItem>()
            .Property(b => b.Title)
            .IsRequired();
        
        modelBuilder.Entity<TaskItem>()
            .HasOne(p => p.User)
            .WithMany(b => b.Tasks)
            .HasForeignKey(p => p.UserId)
            .HasPrincipalKey(b => b.UserId);
    }
}