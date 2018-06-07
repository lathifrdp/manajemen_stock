using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManajemenBarang.Areas.Admin.Models
{
    public class BarangClass
    {
        dbStokEntities entities = new dbStokEntities();
        public List<spGetBarangJoin_Result> getBarang()
        {
            return entities.spGetBarangJoin().ToList();
        }
        public List<spGetBarangMasukJoin_Result> getBarangMasuk()
        {
            return entities.spGetBarangMasukJoin().ToList();
        }
        public List<spGetBarangKeluarJoin_Result> getBarangKeluar()
        {
            return entities.spGetBarangKeluarJoin().ToList();
        }
        public List<spGetBarangReturnJoin_Result> getBarangReturn()
        {
            return entities.spGetBarangReturnJoin().ToList();
        }

        public List<spGetBarang_Result> getBrg()
        {
            return entities.spGetBarang().ToList();
        }
        public List<spGetBarangList_Result> getBarangList()
        {
            return entities.spGetBarangList().ToList();
        }
        public List<spGetKategori_Result> getKategori()
        {
            return entities.spGetKategori().ToList();
        }
        public List<spGetUser_Result> getUser()
        {
            return entities.spGetUser().ToList();
        }
        public List<spGetSupplier_Result> getSupplier()
        {
            return entities.spGetSupplier().ToList();
        }
        public List<spGetBarangWhere_Result> getEditResult(int id)
        {
            return entities.spGetBarangWhere(id).ToList();
        }
        public List<spGetSupplierWhere_Result> getSupplierWhere(int id)
        {
            return entities.spGetSupplierWhere(id).ToList();
        }
        
        public List<spGetBarangJoinID_Result> getBarangID()
        {
            return entities.spGetBarangJoinID().ToList();
        }
    }
}