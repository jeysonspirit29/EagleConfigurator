﻿using ConfigBusinessEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using ConfigUtilitarios;

namespace ConfigDataAccess.Utiles
{
    public class UtilDA
    {
        public bool ValidarDetele(long idPadre, int codValPadre)
        {
            bool valido = false;
            long numHijosActivos = -99;

            using (var conexion = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    using (var cmd = new SqlCommand("USP_SIS_CNS_NUM_HIJOS_ACTIVOS", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@idPadre", idPadre));
                        cmd.Parameters.Add(new SqlParameter("@codValPadre", codValPadre));

                        var numHijos = new SqlParameter("@numHijos", -99);
                        numHijos.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(numHijos);

                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        numHijosActivos = long.Parse(cmd.Parameters["@numHijos"].Value.ToString());
                    }

                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Validar Delete Master: ", e.Message);
                }
            }

            if (numHijosActivos == 0)
                valido = true;

            return valido;
        }

        public static DateTime GetCurrentDateTime()
        {
            DateTime ahora = DateTime.Now;
            using (var conexion = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    using (var cmd = new SqlCommand("USP_SIS_CNS_FECHA_HORA_ACTUAL", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conexion.Open();
                        ahora = DateTime.Parse(cmd.ExecuteScalar().ToString());
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("GetCurrentDateTime: ", e.Message);
                }
            }
            return ahora;
        }

        public bool RunContext(GRLt01_parametro paramRun)
        {
            bool isSuccess = false;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.GRLt01_parametro.Attach(paramRun);
                    ctx.Entry(paramRun).State = EntityState.Modified;
                    ctx.SaveChanges();
                    isSuccess = true;
                }
                catch (Exception e)
                {
                    isSuccess = false;
                    var log = new Log();
                    log.ArchiveLog("Run Context: ", e.Message);
                }
            }
            return isSuccess;
        }
    }
}
