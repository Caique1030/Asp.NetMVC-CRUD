using Asp.NetMVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NetMVC_CRUD.Controllers
{
    public class EstudanteController : Controller
    {
        // GET: Estudante
        public ActionResult Demo(int id)
        {
            Estudante estudante = new Estudante();
            EstudanteContext db = new EstudanteContext();
            estudante = db.Estudante.Single(x => x.Id == id);
            return View(estudante);
        }
    }
}