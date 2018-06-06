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
        public List<GetBarangWhere3_Result> GetBarangWhere3_Results(string id_supplier)
        {
            return dbe.GetBarangWhere3(id_supplier).ToList<GetBarangWhere3_Result>();
        }
    }
}