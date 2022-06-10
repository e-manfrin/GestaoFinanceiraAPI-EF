using GestaoFinanceira.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoFinanceira.Data
{
    public class ContaContext : DbContext
    {
        public ContaContext(DbContextOptions<ContaContext> opt) : base(opt)
        {

        }
        public DbSet<Conta> Contas { get; set; }
    }
}

