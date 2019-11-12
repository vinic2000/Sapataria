using System.Collections.Generic;

namespace Sapataria_Web.Models
{
    public class Cliente : Modelo
    {
        public string Nome { get; set; }
        public List<Pedido> Pedido { get; set; }

    }
}