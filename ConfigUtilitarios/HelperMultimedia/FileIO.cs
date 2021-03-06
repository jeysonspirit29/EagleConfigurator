﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConfigUtilitarios
{
    public class FileIO
    {
        public bool DeleteFilesPath(string strPath, string strExtension)
        {
            bool _result = false;
            var oLog = new Log();
            try
            {
                string[] txtList = Directory.GetFiles(strPath, "*." + strExtension);

                foreach (string f in txtList)
                {
                    File.Delete(f);
                }
                oLog.ArchiveLog("Utilitarios: Delete Files Path : ", "Archivos eliminados de la carpeta " + strPath);
            }
            catch (DirectoryNotFoundException Ex)
            {
                oLog.ArchiveLog("Utilitarios: Delete Files Path - Directorio no encontrado. : ", Ex.Message.ToString());
            }
            catch(Exception ExGeneric)
            {
                oLog.ArchiveLog("Utilitarios: Delete Files Path : ", ExGeneric.Message.ToString());
            }

            return _result;
        }
         
    }
}
