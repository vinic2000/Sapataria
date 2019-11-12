using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Sapataria_Web.Models
{
    [DataContract]
    public abstract class Modelo
    {
        [DataMember]
        public int Id { get; set; }
    }
}
