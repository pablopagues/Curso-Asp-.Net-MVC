using AutoMapper;
using LocadoraDeCarros.Controllers.Base;
using LocadoraDeCarros.Models;
using Microsoft.AspNetCore.Mvc;
using Negocio.Models;
using Negocio.ServicoNegocio.Base;
using System.Collections.Generic;

namespace LocadoraDeCarros.Controllers
{
    public class ClienteController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IClienteServico _clienteServico;

        public ClienteController(IMapper mapper, IClienteServico clienteServico)
        {
            _mapper = mapper;
            _clienteServico = clienteServico;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            var listaClienteVM = _mapper.Map<List<ClienteViewModel>>(_clienteServico.ObterListaClientes());
            return View(listaClienteVM);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            ClienteViewModel clienteVM = _mapper.Map<ClienteViewModel>(_clienteServico.ObterClientePorID(id));
            return View(clienteVM);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View(new ClienteViewModel());
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel clienteVM)
        {
            try
            {

                var novoCliente = _mapper.Map<Cliente>(clienteVM);

                //TODO: validar regras de negocio
                if (novoCliente.EmailEstaDuplicado(_clienteServico))
                    ModelState.AddModelError("Email", "O email ja existe no banco de dados");

                if (ModelState.IsValid)
                {
                    if (_clienteServico.Inserir(novoCliente))
                    {
                        Mensagem("O cliente foi inserido com sucesso.", "Info");
                        return RedirectToAction(nameof(Index));
                    }
                }
                Mensagem("Ocorreu algum erro ao inserir o novo cliente.", "Error");
                return View(clienteVM);
            }
            catch
            {
                Mensagem("Ocorreu alguma exception ao inserir o novo cliente.", "Error");
                return View(clienteVM);
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            var clienteEditar = _mapper.Map<ClienteViewModel>(_clienteServico.ObterClientePorID(id));
            return View(clienteEditar);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel clienteVM)
        {
            try
            {

                var clienteEditado = _mapper.Map<Cliente>(clienteVM);

                if (clienteEditado.EmailEstaDuplicado(_clienteServico))
                    ModelState.AddModelError("Email", "O email ja existe no banco de dados");

                if (ModelState.IsValid)
                {

                    if (_clienteServico.Editar(clienteEditado))
                    {
                        Mensagem("O cliente foi editado com sucesso.", "Info");
                        return RedirectToAction(nameof(Index));
                    }
                }

                Mensagem("Ocorreu algum erro ao editar o cliente.", "Error");
                return View(clienteVM);
            }
            catch
            {
                Mensagem("Ocorreu alguma exception ao editar o cliente.", "Error");
                return View(clienteVM);
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            var clienteExcluir = _mapper.Map<ClienteViewModel>(_clienteServico.ObterClientePorID(id));
            return View(clienteExcluir);
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ClienteViewModel clienteExcluir)
        {
            try
            {
                if (_clienteServico.Excluir(clienteExcluir.id))
                {
                    Mensagem("O cliente foi excluido com sucesso.", "Info");
                    return RedirectToAction(nameof(Index));
                }

                Mensagem("Ocorreu alguma erro ao excluir o cliente.", "Error");
                return View(clienteExcluir);
            }
            catch
            {
                Mensagem("Ocorreu alguma exception ao excluir o cliente.", "Error");
                return View(clienteExcluir);
            }
        }
    }
}