using Microsoft.AspNetCore.Mvc;
using Sapataria_Web.Controlador;
using Sapataria_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sapataria_Web.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoControlador pedidoControlador;
        private readonly IClienteControlador clienteControlador;


        public PedidoController(IPedidoControlador pedidoControlador, IClienteControlador clienteControlador)
        {
            this.pedidoControlador = pedidoControlador;
            this.clienteControlador = clienteControlador;
        }
        [HttpPost]
        public IActionResult Cadastrar([FromForm]Pedido pedido)
        {
            if (clienteControlador.localizar(pedido.Cliente) == null)
            {
                clienteControlador.Cadastrar(pedido.Cliente);
            }
            pedido.D_Entrada = DateTime.Now.Date;
            pedidoControlador.CadasdrarPedido(pedido);

            return RedirectToAction("Index");
        }


        [HttpPost]
        public JsonResult Listar()
        {
            return Json(pedidoControlador.ListarPedidos());
        }

        [HttpPost]
        public JsonResult PedidoOrdemData()
        {
            return Json(pedidoControlador.ListapedidosEmOrdem());
        }
    }
}
