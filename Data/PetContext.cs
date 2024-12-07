using Microsoft.EntityFrameworkCore;
using PetAsp.Models;

namespace PetAsp.Data;


public class PetContext : DbContext
{
    public PetContext(DbContextOptions<PetContext> options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Pet> Pets { get; set; }
}

