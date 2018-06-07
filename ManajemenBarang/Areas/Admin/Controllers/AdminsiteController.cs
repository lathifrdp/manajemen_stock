using ManajemenBarang.Areas.Admin.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ManajemenBarang.Areas.Admin.Controllers
{
    public class AdminsiteController : Controller
    {
        BarangClass mod = new BarangClass();
        private dbStokEntities db = new dbStokEntities();
        ListOptions list = new ListOptions();
        // GET: Admin/Adminsite
        public ActionResult Index()
        {
            List<spGetBarangJoin_Result> result = mod.getBarang();
            return View(result);
        }
        //public ActionResult Index()
        //{
        //    list.getBarangID = mod.getBarangID();
        //    list.getKategori = mod.getKategori();
        //    list.getSupplier = mod.getSupplier();
        //    return View(list);
        //}


        public ActionResult Edit(int id)
        {
            list.getEdit = mod.getEditResult(id);
            list.getSupplier = mod.getSupplier();
            list.getKategori = mod.getKategori();
            return View(list);
        }

        public ActionResult EditAction(spGetBarang_Result brg)
        {
            db.spEditBarang(brg.id_brg, brg.nama_brg, brg.kode_brg, brg.jumlah_brg, brg.id_kat, brg.id_sup, brg.deskripsi_brg);
            return RedirectToAction("Index", new { Area = "Admin" });
        }
        
        public ActionResult Delete(int? id)
        {
            Barang result = db.Barang.Find(id);
            return View(result);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAction(int id)
        {
            Barang result = db.Barang.Find(id);
            db.Barang.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index", "Adminsite", new { Area = "Admin" });
        }

        public ActionResult ProfileSupplier(int id)
        {
            List < spGetSupplierWhere_Result > result = mod.getSupplierWhere(id);
            return View(result);
        }

    }
}