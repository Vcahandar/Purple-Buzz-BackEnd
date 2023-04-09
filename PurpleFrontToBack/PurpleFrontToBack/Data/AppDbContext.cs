using Microsoft.EntityFrameworkCore;
using PurpleFrontToBack.Models;

namespace PurpleFrontToBack.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<SliderImg> SliderImgs { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImg> ProductImgs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<RecentWork> RecentWorks { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Contact> Contacts  { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Offer> Offers { get; set; }










    }
}
