using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace practica4.Controllers
{
    public class PrestamosController : Controller
    {
        #region Contexto
        // ATRIBUTO CONTEXTO
        private bibliotecaEntities1 _contexto;

        // PROPIEDAD CONTEXTO
        public bibliotecaEntities1 Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new bibliotecaEntities1();
                return _contexto;
            }
        }
        #endregion
        // GET: Prestamos
        public ActionResult Index()
        {
            //var query = from p in Contexto.Prestamos
            //            join a in Contexto.Libro
            //            on p.Idlibro equals a.IdLibro
            //            join u in Contexto.Usuarios
            //            on p.IdUsuario equals u.IdUsuario
            //            select new
            //            {
            //                p_pres = p.IdPrestamo,
            //                a_tit = a.Titulo,
            //                u_nom = u.Nombre
            //            };
            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name={1} \t Proveedor={2}",
            //    prod.p_pres, prod.a_tit, prod.u_nom);
            //}
            //return View(query.ToList());
            return View(Contexto.Prestamos.ToList());
        }

    }
}