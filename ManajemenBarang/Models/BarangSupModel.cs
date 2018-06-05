using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManajemenBarang.Models
{
    public class BarangSupModel
    {
        dbStokEntities dbe = new dbStokEntities();
        public List<GetBarangSup_Result> GetBarangSup_Results(int id_supplier)
        {
            return dbe.GetBarangSup(id_supplier).ToList<GetBarangSup_Result>();
        }
    }
}