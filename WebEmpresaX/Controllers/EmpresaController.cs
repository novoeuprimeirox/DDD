using Domain.Interfaces.Generics;
using Domain.Interfaces.IServices;
using Domain.Services;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            return View();
        }

        // GET: EmpresaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpresaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpresaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpresaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpresaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpresaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
