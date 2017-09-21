using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppExercicioPratico03_Lab2_2017_2.Models;

namespace WebAppExercicioPratico03_Lab2_2017_2.Controllers
{
    public class EstudanteController : Controller
    {
        private SistemaAcademicoContext db = new SistemaAcademicoContext();

        // GET: Estudante
        public ActionResult Index()
        {
            var estudantes = db.Estudante.Include(e => e.Endereco);
            return View(estudantes.ToList());
        }

        // GET: Estudante/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudante estudante = db.Estudante.Find(id);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }

        // GET: Estudante/Create
        public ActionResult Create()
        {
            ViewBag.EstundateId = new SelectList(db.Enderecos, "EnderecoId", "Cidade");
            return View();
        }

        // POST: Estudante/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EstundateId,EstusanteNome,DataDeNascimento,Foto,Altura,Peso,NivelEnsinoId")] Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                db.Estudante.Add(estudante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EstundateId = new SelectList(db.Enderecos, "EnderecoId", "Cidade", estudante.EstundateId);
            return View(estudante);
        }

        // GET: Estudante/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudante estudante = db.Estudante.Find(id);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            ViewBag.EstundateId = new SelectList(db.Enderecos, "EnderecoId", "Cidade", estudante.EstundateId);
            return View(estudante);
        }

        // POST: Estudante/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EstundateId,EstusanteNome,DataDeNascimento,Foto,Altura,Peso,NivelEnsinoId")] Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estudante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EstundateId = new SelectList(db.Enderecos, "EnderecoId", "Cidade", estudante.EstundateId);
            return View(estudante);
        }

        // GET: Estudante/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudante estudante = db.Estudante.Find(id);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }

        // POST: Estudante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estudante estudante = db.Estudante.Find(id);
            db.Estudante.Remove(estudante);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
