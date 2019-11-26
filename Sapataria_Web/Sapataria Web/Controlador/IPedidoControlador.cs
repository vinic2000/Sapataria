using System.Collections.Generic;
using Sapataria_Web.Models;
using Sapataria_Web.Models.JsonModelos;

namespace Sapataria_Web.Controlador
{
    public interface IPedidoControlador
    {
        void CadasdrarPedido(Pedido pedido);
        List<PedidosJson> ListapedidosEmOrdem();
        List<PedidosJson> ListarPedidos();
    }
}