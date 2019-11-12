using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Sapataria_Web.Models
{
    public class Pedido : Modelo
    {
        [DataMember]
        [Required(ErrorMessage ="Campo é obrigatorio")]
        public string Titulo { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Campo é obrigatorio")]
        public Cliente Cliente { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Campo é obrigatorio")]
        public DateTime D_Entrada { get; set; }
        
        [DataMember]
        [Required(ErrorMessage = "Campo é obrigatorio")]
        public DateTime D_Entrega { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Campo é obrigatorio")]
        public string Descricao { get; set; }
    }
}
