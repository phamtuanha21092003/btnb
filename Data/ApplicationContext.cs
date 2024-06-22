using Microsoft.EntityFrameworkCore;
using btvn.Models;

namespace btvn.Data;

public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
{
    public DbSet<Member> Members { set; get; }

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Member>().HasData(
            new { MemberName = "a", YearOfBirth = 2021, Email = "test@example.com", Gender = true },
            new { MemberName = "b", YearOfBirth = 2022, Email = "testb@example.com", Gender = true }
        );
    }
}