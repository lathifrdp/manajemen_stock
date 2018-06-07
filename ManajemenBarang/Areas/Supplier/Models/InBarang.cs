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
        public List<GetBarang_Result> GetBarang_Results()
        {
            return dbe.GetBarang().ToList<GetBarang_Result>();
        }
        /*public List<GetBarangWhereDist_Result> GetBarangWhereDist_Results(string id_supplier)
        {
            return dbe.GetBarangWhereDist(id_supplier).ToList<GetBarangWhereDist_Result>();
        }*/
        public List<GetBarangnya_Result> GetBarangnya_Results(string id_supplier)
        {
            return dbe.GetBarangnya(id_supplier).ToList<GetBarangnya_Result>();
        }

    }
}