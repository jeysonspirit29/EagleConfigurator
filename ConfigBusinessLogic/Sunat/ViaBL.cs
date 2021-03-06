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
    public class ViaBL
    {
        public List<SNTt15_via> ListaVia(int? id_estado = null, bool enableTopList = false)
        {
            var list = new ViaDA().ListaVia(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_via != TopList.Via).ThenBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
