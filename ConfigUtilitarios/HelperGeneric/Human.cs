﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios.HelperGeneric
{
    public class Human
    {
        public static string Nombre(string apPaterno, string apMaterno, string primerNom, string segundoNom = null, string rznSocial = null)
        {
            string nombre = "";
            if (apPaterno != null && apPaterno.Trim() != "")
            {
                nombre = apPaterno + " ";
            }
            if (apMaterno != null && apMaterno.Trim() != "")
            {
                nombre += apMaterno + " ";
            }
            if (primerNom != null && primerNom.Trim() != "")
            {
                nombre += primerNom + " ";
            }
            if (segundoNom != null && segundoNom.Trim() != "")
            {
                nombre += segundoNom + " ";
            }
            if (rznSocial != null && rznSocial.Trim() != "")
            {
                if (nombre.Length > 0)
                {
                    nombre += "| " + rznSocial;
                }
                else
                {
                    nombre = rznSocial;
                }
            }
            return nombre;
        }

    }
}
