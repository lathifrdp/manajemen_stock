using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManajemenBarang.Models;
namespace ManajemenBarang.Areas.Supplier.Models
{
    public class InBarang
    {
        dbStokEntities dbe = new dbStokEntities();
        public List<GetKategori_Result> GetKategori_Results()
        {
            return dbe.GetKategori().ToList<GetKategori_Result>();
        }
    }
}