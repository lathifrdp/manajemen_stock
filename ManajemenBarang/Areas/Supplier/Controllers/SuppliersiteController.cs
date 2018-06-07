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
        InBarang ib = new InBarang();
        BarangWhere bw = new BarangWhere();
        public ActionResult Index(string id_supplier)
        {
            if (Session["SupID"] != null)
            {
                //string str = Session["SupID"].ToString();
                ViewModel vm = new ViewModel();
                id_supplier = Session["SupID"].ToString();
                //id_user = 1;
                vm.allBar = ib.GetBarangWhere3_Results(id_supplier);
                vm.allSup = ib.GetNama(id_supplier);
                //List<GetBarangWhere3_Result> bwh = bw.GetBarangWhere3_Results(id_supplier);
                return View(vm);

                //List<GetSupplay_Result> tess = sb.GetSupplay_Results();
                //tess.Where(a => a.id_supplier.Equals(Session["SupID"]));
                //return View(tess);
            }
            return View("ErrorSession");
        }
        
        public ActionResult Insert()
        {
            if (Session["SupID"] != null)
            {
                ViewModel vm = new ViewModel();
                vm.allKategori = ib.GetKategori_Results();
                return View("Create", vm);
            }
            return View("ErrorSession");
        }
        public ActionResult InsertExist(string id_supplier)
        {
            if (Session["SupID"] != null)
            {
                ViewModel vm = new ViewModel();
                //vm.allKategori = ib.GetKategori_Results();
                id_supplier = Session["SupID"].ToString();
                vm.allNya = ib.GetBarangnya_Results(id_supplier);
                //vm.allBarang = ib.GetBarang_Results();
                return View("CreateExist", vm);
            }
            return View("ErrorSession");
        }
        public ActionResult InsertData(GetBarangSup2_Result br)
        {
            dbStokEntities dbe = new dbStokEntities();
            dbe.CreateData(br.id_kategori, br.id_supplier, br.kode_barang, br.nama_barang, br.id_barang, br.jumlah_barang, br.tanggal_masuk, br.jum_barang_masuk, br.created_masuk, br.deskripsi, br.updated_masuk);
            return View("InsertData");
        }
        public ActionResult InsertDataExist(GetBarangSup2_Result br)
        {
            dbStokEntities dbe = new dbStokEntities();
            dbe.CreateDataExist(br.id_barang, br.tanggal_masuk, br.jumlah_barang, br.deskripsi, br.created_masuk, br.id_supplier);
            return View("InsertDataExist");
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login","Dashboard",new { area=""});
        }
        ProfilMod pm = new ProfilMod();
        public ActionResult Profil(string id_supplier)
        {
            if (Session["SupID"] != null)
            {
                id_supplier = Session["SupID"].ToString();
                List<GetProfil_Result> gpr = pm.GetProfil_Results(id_supplier);
                return View(gpr);
            }
            return View("ErrorSession");
        }
    }
}