﻿using ConfigBusinessEntity;
using ConfigDataAccess.Sunat;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Sunat
{
    public class SituacionEducativaBL
    {
        public List<SNTt18_situacion_educativa> ListaSituacionEducativa(int? id_estado = null, bool enableTopList = false)
        {
            var list = new SituacionEducativaDA().ListaSituacionEducativa(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_situacion_educativa != TopList.SituacionEducativa).ThenBy(x => x.txt_abrv).ToList();

            return list;
        }
    }
}
