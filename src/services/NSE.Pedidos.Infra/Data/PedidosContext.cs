using Microsoft.EntityFrameworkCore;
using NSE.Core.Mediator;

namespace NSE.Pedidos.Infra.Data
{
    public class PedidosContext : DbContext
    {
        private readonly IMediatorHandler _mediatorHandler;

        public PedidosContext(DbContextOptions<PedidosContext> options, IMediatorHandler mediatorHandler)
            : base(options)
        {
            _mediatorHandler = mediatorHandler;
        }
    }
}
