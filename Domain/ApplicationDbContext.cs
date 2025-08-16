using bankstan_payment.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace bankstan_payment.Domain;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Account> Accounts => Set<Account>();
    public DbSet<Transaction> Transactions => Set<Transaction>();
    public DbSet<TransactionType> TransactionTypes => Set<TransactionType>();
    public DbSet<RiskFlag> RiskFlags => Set<RiskFlag>();
    public DbSet<Notifications> Notifications => Set<Notifications>();
    public DbSet<TransactionStatus> TransactionStatus => Set<TransactionStatus>();
    public DbSet<ServicesProviders> ServicesProviders => Set<ServicesProviders>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
}