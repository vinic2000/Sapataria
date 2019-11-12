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
            return dbSet.Where(c => c.Nome == cliente.Nome).SingleOrDefault();

        }
        public void Cadastrar(Cliente cliente)
        {
            dbSet.Add(cliente);
            context.SaveChanges();
        }
    }
}
