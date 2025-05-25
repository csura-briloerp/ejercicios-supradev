using Semana05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semana05.Controllers
{
    public class LibroController : Controller
    {
        List<Libro> libros = new List<Libro>()
        {
            new Libro { Id = 1, Titulo = "El Camino De Los Reyes", Autor = "Brandon Sanderson" },
            new Libro { Id = 3, Titulo = "Los Pilares De La Tierra", Autor = "Ken Follett" },
            new Libro { Id = 2, Titulo = "Cien años de soledad", Autor = "Gabriel García Márquez" },
            new Libro { Id = 4, Titulo = "1984", Autor = "George Orwell" },
            new Libro { Id = 5, Titulo = "Orgullo y prejuicio", Autor = "Jane Austen" },
        };

        // GET: Libro
        public ActionResult Index()
        {
            return View(libros);
        }

        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                foreach (var libro in libros)
                {
                    if (libro.Id == id)
                    {
                        return View(libro);
                    }
                }
            }
            return HttpNotFound();
        }
    }
}