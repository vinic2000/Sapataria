using Microsoft.EntityFrameworkCore;
using Sapataria_Web.Models;
using Sapataria_Web.Models.JsonModelos;
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
        public List<PedidosJson> ListarPedidos()
        {
            List<PedidosJson> pJson = new List<PedidosJson>();

            var pedidos = dbSet.
                Include(c => c.Cliente)
                .ToList();

            foreach (var item in pedidos)
            {
                pJson.Add(new PedidosJson()
                {
                    Id = item.Id,
                    Cliente = item.Cliente.Nome,
                    Titulo = item.Titulo,
                    D_Entrada = item.D_Entrada,
                    D_Entrega = item.D_Entrega
                });
            }

            return pJson;
        }

        public List<PedidosJson> ListapedidosEmOrdem()
        {
            var pedidosEmOrdem = ListarPedidos().OrderBy(p => p.D_Entrega).ToList();
            return pedidosEmOrdem;
        }

    }

}

