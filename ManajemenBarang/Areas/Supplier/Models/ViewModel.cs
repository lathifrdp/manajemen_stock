using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManajemenBarang.Models;

namespace ManajemenBarang.Areas.Supplier.Models
{
    public class ViewModel
    {
        public List<GetKategori_Result> allKategori { get; set; }
        public List<GetBarangWhere3_Result> allBar { get; set; }
        public List<GetCreatedSupplier3_Result> allSup { get; set; }
        public List<GetBarang_Result> allBarang { get; set; }
        public List<GetBarangnya_Result> allNya { get; set; }
    }
}