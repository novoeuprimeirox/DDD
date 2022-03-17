using Domain.Interfaces.Generics;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net;


namespace WebEmpresaX.Controllers
{
    public class EmpresaController : BaseController
    {
        private readonly IRepository _repository;
        public EmpresaController(IRepository repository)
        {
            this._repository = repository;
        }
        // GET: EmpresaController
        public ActionResult Index()
        {
            _ = new List<Empresa>();
            IEnumerable<Empresa> empresas = _repository.GetAll();
            return View(empresas);
        }

        // GET: EmpresaController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var empresa = _repository.GetById(id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }


        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpresaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Empresa empresa)
        {
            try
            {
                if (!ModelState.IsValid) return View(empresa);

                _repository.Add(empresa);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

     

        public ActionResult Edit(int id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var empresa =  _repository.GetById(id);
            if (empresa == null)
            {
                return NotFound();
            }
            return View(empresa);


        }


        [HttpPost]
         
        public IActionResult Edit(int id,Empresa empresa)
        {
            if (id != empresa.Id)
            {
                return NotFound();
            }

           
                try
                {
                    _repository.Update(empresa);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpresaExists(empresa.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
          
            return View(empresa);
        }

        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = _repository.GetById(id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var empresa = _repository.GetById(id);
            _repository.Delete(empresa);
             
            return RedirectToAction(nameof(Index));
        }

        private bool EmpresaExists(int id)
        {
            var empresa = _repository.GetById(id);

            if (empresa==null)
            {
                return true;
            }
            return false;
        }
    }
}
