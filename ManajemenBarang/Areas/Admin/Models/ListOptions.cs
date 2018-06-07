using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManajemenBarang.Areas.Admin.Models
{
    public class ListOptions
    {
        public List<spGetBarangKeluar_Result> getKeluar { get; set; }
        public List<spGetBarangJoinID_Result> getBarangID { get; set; }
        public List<spGetUser_Result> getUser { get; set; }
        public List<spGetBarangList_Result> getBarang { get; set; }
        public List<spGetKategori_Result> getKategori { get; set; }
        public List<spGetSupplier_Result> getSupplier { get; set; }
        public List<spGetBarangWhere_Result> getEdit { get; set; }
    }
}