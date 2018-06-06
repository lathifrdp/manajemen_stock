using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManajemenBarang.Models;

namespace ManajemenBarang.Areas.Supplier.Models
{
    public class ProfilMod
    {
        dbStokEntities dbs = new dbStokEntities();
        public List<GetProfil_Result> GetProfil_Results(string id_supplier)
        {
            return dbs.GetProfil(id_supplier).ToList<GetProfil_Result>();
        }
    }
}