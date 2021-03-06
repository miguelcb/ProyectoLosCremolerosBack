﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTP.PortalEmpleabilidad.Modelo.Vistas.Empresa
{
    public class VistaRegistroEmpresa
    {
        //Datos de Empresa

        [Required(ErrorMessage = "Falta Nombre Comercial")]
        [StringLength(100)]
        public string NombreComercial { get; set; }

        [Required(ErrorMessage = "Falta Razón Social")]
        [StringLength(200)]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "Falta Identificador Tributario")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Este campo sólo acepta 11 números.")]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "Este campo sólo acepta números.")]
        public string IdentificadorTributario { get; set; }

        //[StringLength(500, ErrorMessage = "Este campo sólo acepta 500 caracteres.")]
        //[DataType(DataType.MultilineText)]
        //public string DescripcionEmpresa { get; set; }

        //public string LinkVideo { get; set; }
        //public int AnoCreacion { get; set; }
        public string CreadoPor { get; set; }

        [Required(ErrorMessage = "Falta País")]
        public string PaisIdListaValor { get; set; }
        //public string NumeroEmpleadosIdListaValor { get; set; }

        [Required(ErrorMessage = "Falta Sector Empresarial")]
        public string SectorEmpresarial1IdListaValor { get; set; }
        //public string SectorEmpresarial2IdListaValor { get; set; }
        //public string SectorEmpresarial3IdListaValor { get; set; }    
        public string EstadoIdListaValor { get; set; }

        //Ubicación

        [Required(ErrorMessage = "Falta Tipo de Ubicación")]
        public string TipoLocacionIdListaValor { get; set; }

        //[Required(ErrorMessage = "Falta Nombre de Ubicación")]
        public string NombreLocacion { get; set; }
        //public string EmailLocacion { get; set; }
        //public string TelefonoLocacion { get; set; }

        [Required(ErrorMessage = "Falta el Departamento de la Dirección")]
        public string DireccionDepartamentoLocacion { get; set; }

        [Required(ErrorMessage = "Falta la Ciudad de la Dirección")]
        public string DireccionCiudadLocacion { get; set; }

        [Required(ErrorMessage = "Falta el Distrito de la Dirección")]
        public string DireccionDistritoLocacion { get; set; }

        [Required(ErrorMessage = "Falta la Dirección")]
        public string DireccionLocacion { get; set; }

        public string EstadoLocacionIdListaValor { get; set; }
        
        //Usuario

        [Required(ErrorMessage = "Falta el Nombre del Contacto")]
        public string NombresUsuario { get; set; }

        [Required(ErrorMessage = "Falta el Apellidos del Contacto")]
        public string ApellidosUsuario { get; set; }

        [RegularExpression(@"[0-9A-Za-z]+", ErrorMessage = "Usuario no válido")]
        [Required(ErrorMessage = "Falta el Nombre de Usuario del Contacto")]
        [StringLength(50, ErrorMessage = "Este campo solo acepta 50 caracteres")]
        public string CuentaUsuario { get; set; }

        [RegularExpression(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*$", ErrorMessage = "Password no válido")]
        [Required(ErrorMessage = "Falta la Contraseña")]
        public string Contrasena { get; set; }

        [Compare("Contrasena", ErrorMessage = "Contraseña ingresada no coincide")]
        public string ContrasenaValidador { get; set; }


        [Required(ErrorMessage = "Falta el Tipo de Documento")]
        public string TipoDocumentoIdListaValor { get; set; }

        [Required(ErrorMessage = "Falta el Número de Documento de Identificación")]
        public string NumeroDocumento { get; set; }

        //public string SexoIdListaValor { get; set; }
        //public string TelefonoFijoUsuario { get; set; }
        //public string AnexoUsuario { get; set; }
        [Required(ErrorMessage = "Falta el Número Celular del Contacto")]
        [StringLength(15, ErrorMessage = "Este campo solo acepta 15 dígitos")]
        public string CelularUsuario { get; set; }

        [Required(ErrorMessage = "Falta el Correo electrónico del Contacto")]
        public string EmailUsuario { get; set; }
        public string EstadoUsuarioIdListaValor { get; set; }
        public string RolIdListaValor { get; set; }

        public string TextoDepartamento { get; set; }
        public string TextoCiudad { get; set; }
        public string TextDistrito { get; set; }
    }
}
