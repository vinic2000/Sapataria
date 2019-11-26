using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sapataria_Web.Models.JsonModelos
{
    public class PedidosJson : Modelo
    {
        public String Titulo { get; set; }
        public String Cliente { get; set; }
        public DateTime D_Entrada { get; set; }
        public DateTime D_Entrega { get; set; }
    }
}
