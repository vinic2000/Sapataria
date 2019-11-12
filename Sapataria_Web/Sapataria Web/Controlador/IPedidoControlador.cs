using System.Collections.Generic;
using Sapataria_Web.Models;

namespace Sapataria_Web.Controlador
{
    public interface IPedidoControlador
    {
        void CadasdrarPedido(Pedido pedido);
        List<Pedido> ListarPedidos();
        List<Pedido> ListarPedidosCliente(Cliente cliente);
    }
}