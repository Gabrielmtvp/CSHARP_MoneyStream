using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;

internal class CashFlowDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        try
        {
            var connectionString = "Server=localhost;Database=cashflowdb;Uid=root;Pwd=Gabriel@123";

            var serverVersion = new MariaDbServerVersion(new Version(8, 0, 29));

            optionsBuilder
                .UseMySql(connectionString, serverVersion)
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}