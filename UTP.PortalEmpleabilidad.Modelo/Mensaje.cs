﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTP.PortalEmpleabilidad.Modelo
{
    public class Mensaje
    {
        public int IdMensaje { get; set; }
        public string DeUsuario { get; set; }
        public string DeUsuarioNombre { get; set; }
        public string DeUsuarioCorreoElectronico { get; set; }
        public string ParaUsuario { get; set; }
        public string ParaUsuarioNombre { get; set; }
        public string ParaUsuarioCorreoElectronico { get; set; }
        public int IdOferta { get; set; }
        public Oferta Oferta { get; set; }
        public int IdEvento { get; set; }
        public Evento Evento { get; set; }
        public DateTime FechaEnvio { get; set; }                        
        
        [Required]
        public string Asunto { get; set; }

        [Required]
        public string MensajeTexto { get; set; }
        public string EstadoMensaje { get; set; }
        public DateTime FechaLectura { get; set; }
        public int IdMensajePadre { get; set; }
        public string CreadoPor { get; set; }
        public string ModificadoPor { get; set; }
        
        public string Pantalla { get; set; } //Parámetro para conocer el origen de la llamada.

        //Datos mensaje anterior.
        public int MensajeAnteriorIdMensaje { get; set; }
        public string MensajeAnteriorAsunto { get; set; }
        public DateTime MensajeAnteriorFechaEnvio { get; set; }

        //Datos mensaje posterior
        public int MensajePosteriorIdMensaje { get; set; }
        public string MensajePosteriorAsunto { get; set; }
        public DateTime MensajePosteriorFechaEnvio { get; set; }

        public int? IdOfertaMensaje { get; set; }

        /// <summary>
        /// Campo que se utiliza para pasar los datos del alumno en los mensajes de UTP - Alumno.
        /// </summary>
        public string UsuarioAlumno { get; set; }

        public int IdEmpresa { get; set; }
        public Mensaje()
        {
            Oferta = new Oferta();
            Evento = new Evento();
            IdOfertaMensaje = 0;
        }
    }
}
