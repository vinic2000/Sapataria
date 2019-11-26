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

        public Cliente localizar(Cliente cliente)
        {
            if(dbSet.Where(c => c.Nome.ToUpper() == cliente.Nome.ToUpper()).SingleOrDefault())
            return ;
        }

        public void Cadastrar(Cliente cliente)
        {
            dbSet.Add(cliente);
            context.SaveChanges();
        }
    }
}
