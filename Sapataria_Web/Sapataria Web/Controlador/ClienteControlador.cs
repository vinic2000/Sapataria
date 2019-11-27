using Sapataria_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sapataria_Web.Controlador
{
    public class ClienteControlador : modeloControlador<Cliente>, IClienteControlador
    {
        public ClienteControlador(SapatariaContext context) : base(context)
        {
        }

        public bool localizar(Cliente cliente)
        {
            var validador = true;
            try
            {
                var pesquisa = dbSet.Where(c => c.Nome.ToUpper().Equals(cliente.Nome)).SingleOrDefault();
            }
            catch (InvalidOperationException)
            {
                validador = false;
            }

            return validador;

        }

        public void Cadastrar(Cliente cliente)
        {
            dbSet.Add(cliente);
            context.SaveChanges();
        }
    }
}
