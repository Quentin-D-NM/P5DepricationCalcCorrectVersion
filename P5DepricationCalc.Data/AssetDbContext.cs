using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using P5DepricationCalc.Data.Models;

namespace P5DepricationCalc.Data.Models
{
    public class AssetDbContext : DbContext
    {

        public AssetDbContext(DbContextOptions<AssetDbContext> context) : base(context)
        {

        }

        public DbSet<MyAsset> MyAssets { get; set; }
    }

    public class AssetDbContextFactory : IDesignTimeDbContextFactory<AssetDbContext>
    {
        public AssetDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AssetDbContext>();
            optionsBuilder.UseSqlite("Data Source = ../Asset.db");

            return new AssetDbContext(optionsBuilder.Options);
        }
    }
}
