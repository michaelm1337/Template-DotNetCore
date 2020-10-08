using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;
using Template.Data.Extensions;
using Template.Data.Mapping;
using Template.Domain.Entities;

namespace Template.Data.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        #region DbSets

        public DbSet<User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
