using Negocio.Models;
using System.Collections.Generic;

namespace Negocio.ServicoNegocio.Base
{
    public interface IClienteServico
    {
        Cliente ObterClientePorEmail(string email);

        Cliente ObterClientePorID(int id);

        List<Cliente> ObterListaClientes();
        bool Inserir(Cliente novoCliente);
        bool Editar(Cliente clienteEditado);
        bool Excluir(int id);
    }
}
