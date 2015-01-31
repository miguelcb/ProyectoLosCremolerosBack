﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UTP.PortalEmpleabilidad.Modelo;

namespace UTPPrototipo.Models.ViewModels.UTP
{
    public class VistaOferta
    {
        public DateTime FechaPublicacion { get; set; }
        public string NombreComercial { get; set; }
        public string Clasificación { get; set; }

        public string CargoOfrecido { get; set; }
        public string NumeroVacantes { get; set; }
        public string FacultadPrincipal { get; set; }
        public string EjecutivoUTP { get; set; }
        public string Nrocv { get; set; }

        public int IdOferta { get; set; }
        public string  Estado { get; set; }
        public List<ListaValor> ListaTipoCargo { get; set; }
        public string PalabraClave { get; set; }
        public string Cargo { get; set; }
        public string IdTipoCargoutp { get; set; }
        //public DateTime FechaSeguimiento { get; set; }
        public string FechaSeguimiento { get; set; }
        public string Comentarios { get; set; }

        public int nroPaginaActual { get; set; }
        public int filasPorPagina { get; set; }


        //Paginación:
        public int CantidadTotal { get; set; }

    }
}