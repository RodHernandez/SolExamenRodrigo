using ExamenRodrigo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ExamenRodrigo.Controllers
{
    public class IndexController : Controller
    {
        ExamenM modelo = new ExamenM();
        // GET: Index
        public ActionResult Index()
        {
            DataTable tabla = modelo.Obtener();
            return View(tabla);
        }

        public ActionResult Insertar()
        {
            return View();
        }

        public ActionResult InsertarPost(string Nombre, string ApellidoP, string ApellidoM)
        {
            modelo.Insertar(Nombre, ApellidoP, ApellidoM);
            return RedirectToAction("Index");
        }

        public ActionResult Editar()
        {
            return View();
        }

        public ActionResult EditarPost(string Nombre, string ApellidoP, string ApllidoM, int id)
        {
            modelo.Editar(Nombre, ApellidoP, ApllidoM, id);
            return RedirectToAction("Index");
        }

        public ActionResult Eliminar(int id) 
        { 
            modelo.eliminar(id);
            return RedirectToAction("Index");
        }
    }
}