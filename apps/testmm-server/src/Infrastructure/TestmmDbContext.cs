using Microsoft.EntityFrameworkCore;

namespace Testmm.Infrastructure;

public class TestmmDbContext : DbContext
{
    public TestmmDbContext(DbContextOptions<TestmmDbContext> options)
        : base(options) { }
}
