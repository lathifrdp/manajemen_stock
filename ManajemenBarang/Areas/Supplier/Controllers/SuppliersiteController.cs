using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManajemenBarang.Models;
using ManajemenBarang.Areas.Supplier.Models;

namespace ManajemenBarang.Areas.Supplier.Controllers
{
    public class SuppliersiteController : Controller
    {
        // GET: Supplier/Suppliersite
        SupBar sb = new SupBar();
        BarangWhere bw = new BarangWhere();
        public ActionResult Index(string id_supplier)
        {
            //string str = Session["SupID"].ToString();
            id_supplier = Session["SupID"].ToString();            
            List<GetBarangWhere2_Result> bwh = bw.GetBarangWhere2_Results(id_supplier);
            return View(bwh);
            
            //List<GetSupplay_Result> tess = sb.GetSupplay_Results();
            //tess.Where(a => a.id_supplier.Equals(Session["SupID"]));
            //return View(tess);
            
        }
        InBarang ib = new InBarang();
        public ActionResult Insert()
        {
            ViewModel vm = new ViewModel();
            vm.allKategori = ib.GetKategori_Results();
            return View("Create",vm);
        }
        public ActionResult InsertData(GetBarangSup2_Result br)
        {
            dbStokEntities dbe = new dbStokEntities();
            dbe.CreateData(br.id_kategori, br.id_supplier, br.kode_barang, br.nama_barang, br.id_barang, br.jumlah_barang, br.tanggal_masuk, br.jum_barang_masuk, br.created_masuk, br.deskripsi, br.updated_masuk);
            return View("InsertData");
        }
    }
}