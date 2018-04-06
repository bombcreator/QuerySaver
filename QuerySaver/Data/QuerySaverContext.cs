using Microsoft.EntityFrameworkCore;
using QuerySaver.Data.Entities;

namespace QuerySaver.Data
{
    public class QuerySaverContext : DbContext
    {
        private readonly DbContextOptions<QuerySaverContext> _options;

        public QuerySaverContext(DbContextOptions<QuerySaverContext> options) : base(options)
        {
            _options = options;
        }
        public DbSet<File> Files { get; set; }
        public DbSet<Query> Queries { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectPart> ProjectParts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
