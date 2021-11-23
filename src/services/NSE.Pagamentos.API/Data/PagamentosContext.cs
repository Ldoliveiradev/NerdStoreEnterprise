using Microsoft.EntityFrameworkCore;

namespace NSE.Pagamentos.API.Data
{
    public sealed class PagamentosContext : DbContext
    {
        public PagamentosContext(DbContextOptions<PagamentosContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}
