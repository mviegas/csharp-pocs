using Microsoft.EntityFrameworkCore;

namespace PoC.EF.EnumTable;

public enum EStatus
{
    None = 0,
    Created = 1,
    Completed = 2,
    Discarded = 3
}

public class Status
{
    public EStatus Id { get; set; }
    public string Description { get; set; }
}


public class MyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(opt =>
        {
            
        });
        
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Status>()
            .HasData(Enum.GetValues<EStatus>()
                .Select(x => new Status()
                {
                    Id = x,
                    Description = x.ToString()
                }));
    }
}