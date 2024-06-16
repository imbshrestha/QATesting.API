using Microsoft.EntityFrameworkCore;

namespace QATesting.API.Models
{
    public class QAContext : DbContext
    {
        public QAContext(DbContextOptions<QAContext> options) : base(options) { }

        public DbSet<TestResult> TestResults { get; set; }
    }
}
