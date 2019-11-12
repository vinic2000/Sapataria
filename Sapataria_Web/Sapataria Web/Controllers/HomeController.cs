using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sapataria_Web.Controlador;
using Sapataria_Web.Models;

namespace Sapataria_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPedidoControlador pedidoControlador;
        private readonly IClienteControlador clienteControlador;

        public HomeController(ILogger<HomeController> logger, IPedidoControlador pedidoControlador, IClienteControlador clienteControlador)
        {
            _logger = logger;
            this.pedidoControlador = pedidoControlador;
            this.clienteControlador = clienteControlador;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
            return RedirectToAction("index");
        }
        [HttpPost]
        public JsonResult Listar()
        {
            return Json(pedidoControlador.ListarPedidos());
        }
    }
}
