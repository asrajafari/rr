using Microsoft.EntityFrameworkCore;

namespace Data;

public class todoLtcContext: DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Todo> Todos { get; set; }

    public string DbPath { get; set; }

    public todoLtcContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
} 
 protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Category>()
        .HasMany(e => e.Todos)
        .WithOne(e => e.Category)
        .HasForeignKey(e => e.Id);
    modelBuilder.Entity<Todo>()
        .HasOne(p => p.Category)
        .WithMany(p => p.Todos)
        .HasForeignKey(p => p.Id);
}