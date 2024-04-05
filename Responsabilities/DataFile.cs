using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace ParticleReader.Responsabilities
{
    public class DataFile
    {
        public bool checkIfFileIsValid(string filePath)
        {
            try
            {
                using (var excelPackage = new ExcelPackage(new System.IO.FileInfo(filePath)))
                {
                    excelPackage.Dispose();
                    return true;
                }
            }catch (Exception ex)
            {
                Trace.WriteLine("Archivo Excell no valido "+ex.Message);
                return false;
            }
        }

    }
}
