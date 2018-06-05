using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManajemenBarang.Models;

namespace ManajemenBarang.Areas.Supplier.Models
{
    public class BarangWhere
    {
        dbStokEntities dbe = new dbStokEntities();
        public List<GetBarangWhere2_Result> GetBarangWhere2_Results(string id_supplier)
        {
            return dbe.GetBarangWhere2(id_supplier).ToList<GetBarangWhere2_Result>();
        }
    }
}