using Microsoft.EntityFrameworkCore;
using Sapataria_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sapataria_Web.Controlador
{
    public class PedidoControlador : modeloControlador<Pedido>, IPedidoControlador
    {
        public PedidoControlador(SapatariaContext context) : base(context)
        {
        }

        public void CadasdrarPedido(Pedido pedido)
        {
           
            dbSet.Add(pedido);
            context.SaveChanges();
        }
        public List<Pedido> ListarPedidos()
        {
            return dbSet.ToList();
        }

        public List<Pedido> ListarPedidosCliente(Cliente cliente)
        {
            var pedidos = dbSet
                .Include(c => c.Cliente)
                .Where(p => p.Cliente.Id == cliente.Id)
                .ToList();
            return pedidos;
        }

    }
}
