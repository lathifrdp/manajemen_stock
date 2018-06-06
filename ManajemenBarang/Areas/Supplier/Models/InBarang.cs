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
        public List<GetBarangWhere3_Result> GetBarangWhere3_Results(string id_supplier)
        {
            return dbe.GetBarangWhere3(id_supplier).ToList<GetBarangWhere3_Result>();
        }
        public List<GetCreatedSupplier3_Result> GetNama(string id_supplier)
        {
            return dbe.GetCreatedSupplier3(id_supplier).ToList<GetCreatedSupplier3_Result>();
        }

    }
}