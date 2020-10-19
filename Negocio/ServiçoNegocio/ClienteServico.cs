using Negocio.Models;
using Negocio.RepositorioDados;
using Negocio.ServicoNegocio.Base;
using System.Collections.Generic;

namespace Negocio.ServicoNegocio
{
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public Cliente ObterClientePorEmail(string email)
        {
            return _clienteRepositorio.ObterClientePorEmail(email);
        }

        public Cliente ObterClientePorID(int id)
        {
            return _clienteRepositorio.ObterCliente(id);
        }

        public List<Cliente> ObterListaClientes()
        {
            return _clienteRepositorio.ObterListaCliente();
        }

        public bool Editar(Cliente clienteEditado)
        {
            return _clienteRepositorio.Editar(clienteEditado);
        }

        public bool Inserir(Cliente novoCliente)
        {
            return _clienteRepositorio.Inserir(novoCliente);
        }

        public bool Excluir(int id)
        {
            return _clienteRepositorio.Excluir(id);
        }
    }
}
