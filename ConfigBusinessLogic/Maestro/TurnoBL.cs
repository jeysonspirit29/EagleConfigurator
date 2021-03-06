﻿using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Maestro
{
    public class TurnoBL
    {
        public int InsertarTurno(MSTt13_turno obj)
        {
            return new TurnoDA().InsertarTurno(obj);
        }
        public void EliminarTurno(int id)
        {
            new TurnoDA().EliminarTurno(id);
        }
        public void ActualizarTurno(MSTt13_turno actualizado)
        {
            new TurnoDA().ActualizarTurno(actualizado);
        }
        public MSTt13_turno TurnoXId(int id)
        {
            return new TurnoDA().TurnoXId(id);
        }
        public MSTt13_turno TurnoXCod(string cod)
        {
            return new TurnoDA().TurnoXCod(cod);
        }
        public List<MSTt13_turno> ListaTurno(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new TurnoDA().ListaTurno(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => x.cod_turno == Parameter.BlankRegister);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_turno != TopList.EstadoMesa).ThenBy(x => x.txt_desc).ToList();

            return lista;
        }
    }
}
