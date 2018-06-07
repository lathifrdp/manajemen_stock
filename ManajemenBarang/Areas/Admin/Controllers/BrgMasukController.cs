using ManajemenBarang.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManajemenBarang.Areas.Admin.Controllers
{
    public class BrgMasukController : Controller
    {
        BarangClass mod = new BarangClass();
        private dbStokEntities db = new dbStokEntities();
        ListOptions list = new ListOptions();
        // GET: Admin/BrgMasuk
        public ActionResult Index()
        {
            List<spGetBarangMasukJoin_Result> result = mod.getBarangMasuk();
            return View(result);
        }

        public ActionResult InsertExist()
        {
            list.getBarang = mod.getBarangList();
            list.getUser = mod.getUser();
            return View(list);
        }

        public ActionResult InsertExistAction(spGetBarang_Result brg)
        {
            db.spBarangMasukExist(brg.id_brg, brg.tanggal_msk, brg.jumlah_brg, brg.deskripsi_brg, brg.id_pj);
            return RedirectToAction("Index", new { Area = "Admin" });
        }

        public ActionResult InsertNew()
        {
            list.getKategori = mod.getKategori();
            list.getUser = mod.getUser();
            list.getSupplier = mod.getSupplier();
            return View(list);
        }

        public ActionResult InsertNewAction(spGetBarang_Result brg)
        {
            //db.spBarangMasukNew(brg.id_brg, brg.id_brg, brg.nama_brg, brg.tanggal_msk, brg.deskripsi_brg, brg.kode_brg);
            db.spBarangMasukNew(brg.id_brg, brg.id_sup, brg.id_kat, brg.nama_brg, brg.tanggal_msk, brg.jumlah_brg, brg.deskripsi_brg, brg.id_pj, brg.kode_brg);
            return RedirectToAction("Index", "BrgMasuk", new { Area = "Admin" });
        }

        public ActionResult Delete(int? id)
        {
            BarangMasuk result = db.BarangMasuk.Find(id);
            return View(result);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAction(int id)
        {
            BarangMasuk result = db.BarangMasuk.Find(id);
            db.BarangMasuk.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index", "BrgMasuk", new { Area = "Admin" });
        }

    }
}