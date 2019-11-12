using Sapataria_Web.Models;

namespace Sapataria_Web.Controlador
{
    public interface IClienteControlador
    {
        Cliente localizar(Cliente cliente);
        void Cadastrar(Cliente cliente);
    }
}