﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UTP.PortalEmpleabilidad.Logica;
using UTP.PortalEmpleabilidad.Modelo;
using UTP.PortalEmpleabilidad.Modelo.Vistas.Ofertas;

namespace UTPPrototipo.Controllers
{
    public class AlumnoController : Controller
    {
        LNAlumno lnAlumno = new LNAlumno();

        LNOferta lnoferta = new LNOferta();

        public string codigoAlumno = "82727128";

        public ActionResult Index()
        {            

            return View();
        }

        /// <summary>
        /// Obtiene los datos que van en la cabecera del alumno
        /// </summary>
        /// <returns></returns>
        //public ActionResult VistaCabecera()
        //{
        //    VistaPanelAlumno panel = lnAlumno.ObtenerPanel(codigoAlumno);

        //    return PartialView("_DatosPersonales", panel);
        //}

        public ActionResult Postulacion() 
        {
            VistaPanelAlumnoPostulaciones panel = lnAlumno.ObtenerPanelPostulaciones(codigoAlumno);

            return View(panel);
        }
        public ActionResult PostulacionOferta()
        {
            return View();
        }
        public ActionResult PostulacionOferta2()
        {
            return View();
        }
        public ActionResult BusquedaOferta()
        {
            List<VistaOfertaAlumno> listaOferta = new List<VistaOfertaAlumno>();

            listaOferta = lnoferta.Oferta_Mostrar();

            return View(listaOferta);
        }
        public ActionResult MiCV()
        {
            VistaPanelAlumnoMiCV panel = lnAlumno.ObtenerPanelMiCV(codigoAlumno);
            return View(panel);
        }

        public ActionResult VistaCabecera()
        {
            string codigoAlumno = "82727128";

            VistaPanelAlumno panel = lnAlumno.ObtenerPanel(codigoAlumno);

            return PartialView("_DatosPersonales", panel.Alumno);

        }
	}
}