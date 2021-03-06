﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTP.PortalEmpleabilidad.Modelo;

namespace UTP.PortalEmpleabilidad.Datos
{
    public class ADAlumnoInformacionAdicional
    {
        ADConexion cnn = new ADConexion();
        SqlCommand cmd = new SqlCommand();
        public DataTable ObtenerAlumnoInformacionAdicionalPorIdAlumno(int IdAlumno)
        {
            DataTable dtResultado = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cnn.Conexion()))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AlumnoInformacionAdicional_ObtenerPorIdAlumno";
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add(new SqlParameter("@IdAlumno", SqlDbType.Int)).Value = IdAlumno;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dtResultado = new DataTable();
                da.Fill(dtResultado);
                conexion.Close();
            }

            return dtResultado;
        }

        public void Registrar(AlumnoInformacionAdicional alumnoinformacionadicional)
        {
 
            using (SqlConnection conexion = new SqlConnection(cnn.Conexion()))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AlumnoInformacionAdicional_Registrar";
                cmd.Connection = conexion;

                conexion.Open();

                cmd.Parameters.Add(new SqlParameter("@IdAlumno", alumnoinformacionadicional.IdAlumno));
                cmd.Parameters.Add(new SqlParameter("@TipoConocimiento", alumnoinformacionadicional.TipoConocimientoIdListaValor));
                cmd.Parameters.Add(new SqlParameter("@Conocimiento", alumnoinformacionadicional.Conocimiento));
                cmd.Parameters.Add(new SqlParameter("@NivelConocimiento", alumnoinformacionadicional.NivelConocimientoIdListaValor));
                cmd.Parameters.Add(new SqlParameter("@FechaConocimientoDesdeMes", alumnoinformacionadicional.FechaConocimientoDesdeMes));
                cmd.Parameters.Add(new SqlParameter("@FechaConocimientoDesdeAno", alumnoinformacionadicional.FechaConocimientoDesdeAno));
                cmd.Parameters.Add(new SqlParameter("@FechaConocimientoHastaMes", alumnoinformacionadicional.FechaConocimientoHastaMes));
                cmd.Parameters.Add(new SqlParameter("@FechaConocimientoHastaAno", alumnoinformacionadicional.FechaConocimientoHastaAno));
                cmd.Parameters.Add(new SqlParameter("@Pais", alumnoinformacionadicional.PaisIdListaValor));
                cmd.Parameters.Add(new SqlParameter("@Ciudad", alumnoinformacionadicional.Ciudad));
                cmd.Parameters.Add(new SqlParameter("@InstituciónDeEstudio", alumnoinformacionadicional.InstituciónDeEstudio));
                cmd.Parameters.Add(new SqlParameter("@AnosExperiencia", alumnoinformacionadicional.AnosExperiencia));
                cmd.Parameters.Add(new SqlParameter("@CreadoPor", alumnoinformacionadicional.Usuario));
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
          

        }

        public DataTable ObtenerAlumnoInformacionAdicionalPorId(int IdInformacionAdicional)
        {
            DataTable dtResultado = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cnn.Conexion()))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AlumnoInformacionAdicional_ObtenerPorID";
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add(new SqlParameter("@IdInformacionAdicional", SqlDbType.Int)).Value = IdInformacionAdicional;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dtResultado = new DataTable();
                da.Fill(dtResultado);
                conexion.Close();
            }

            return dtResultado;
        }

        public void Update(AlumnoInformacionAdicional alumnoinformacionadicional)
        {
            using (SqlConnection conexion = new SqlConnection(cnn.Conexion()))
            {
                conexion.Open();

                SqlTransaction transaccion;
                transaccion = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.Transaction = transaccion;

                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AlumnoInformacionAdicional_Update";
                    cmd.Parameters.Add(new SqlParameter("@IdInformacionAdicional", alumnoinformacionadicional.IdInformacionAdicional));
                    cmd.Parameters.Add(new SqlParameter("@TipoConocimiento", alumnoinformacionadicional.TipoConocimientoIdListaValor));
                    cmd.Parameters.Add(new SqlParameter("@Conocimiento", alumnoinformacionadicional.Conocimiento));
                    cmd.Parameters.Add(new SqlParameter("@NivelConocimiento", alumnoinformacionadicional.NivelConocimientoIdListaValor));
                    cmd.Parameters.Add(new SqlParameter("@FechaConocimientoDesdeMes", alumnoinformacionadicional.FechaConocimientoDesdeMes));
                    cmd.Parameters.Add(new SqlParameter("@FechaConocimientoDesdeAno", alumnoinformacionadicional.FechaConocimientoDesdeAno));
                    cmd.Parameters.Add(new SqlParameter("@FechaConocimientoHastaMes", alumnoinformacionadicional.FechaConocimientoHastaMes));
                    cmd.Parameters.Add(new SqlParameter("@FechaConocimientoHastaAno", alumnoinformacionadicional.FechaConocimientoHastaAno));
                    cmd.Parameters.Add(new SqlParameter("@Pais", alumnoinformacionadicional.PaisIdListaValor));
                    cmd.Parameters.Add(new SqlParameter("@Ciudad", alumnoinformacionadicional.Ciudad));
                    cmd.Parameters.Add(new SqlParameter("@InstituciónDeEstudio", alumnoinformacionadicional.InstituciónDeEstudio));
                    cmd.Parameters.Add(new SqlParameter("@AnosExperiencia", alumnoinformacionadicional.AnosExperiencia));
                    cmd.Parameters.Add(new SqlParameter("@ModificadoPor", alumnoinformacionadicional.Usuario));
                    cmd.ExecuteNonQuery();
                    transaccion.Commit();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw ex;
                }
            }

        }

        public void Desactivar(int IdInformacionAdicional,string Usuario)
        {
            using (SqlConnection conexion = new SqlConnection(cnn.Conexion()))
            {
                conexion.Open();

                SqlTransaction transaccion;
                transaccion = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.Transaction = transaccion;

                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AlumnoInformacionAdicional_Desactivar";
                    cmd.Parameters.Add(new SqlParameter("@IdInformacionAdicional", SqlDbType.Int)).Value = IdInformacionAdicional;
                    cmd.Parameters.Add(new SqlParameter("@ModificadoPor", SqlDbType.VarChar, 50)).Value = Usuario;

                    cmd.ExecuteNonQuery();
                    transaccion.Commit();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw ex;
                }
            }

        }
    }
}
