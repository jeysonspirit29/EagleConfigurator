﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios.ViewModels
{
    public class ComboItem
    {
        public long id_combo_item { get; set; }

        public string txt_desc_item { get; set; }

        public string cod_combo_item { get; set; }

        public decimal cantidad { get; set; }

        public decimal mto_pvpu_sin_tax { get; set; }

        public decimal mto_pvpu_con_tax { get; set; }

        public int id_estado { get; set; }

    }
}
