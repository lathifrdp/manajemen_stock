using ManajemenBarang.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManajemenBarang.Areas.Admin.Controllers
{
    public class BrgReturnController : Controller
    {
        BarangClass mod = new BarangClass();
        private dbStokEntities db = new dbStokEntities();
        ListOptions list = new ListOptions();
        // GET: Admin/BrgReturn
        public ActionResult Index()
        {
            List<spGetBarangReturnJoin_Result> result = mod.getBarangReturn();
            return View(result);
        }

        public ActionResult Insert()
        {
            list.getBarang = mod.getBarangList();
            list.getUser = mod.getUser();
            list.getSupplier = mod.getSupplier();
            return View(list);
        }

        public ActionResult InsertAction(spGetBarangReturn_Result brg)
        {
            db.spBarangReturn(brg.id_barang, brg.tanggal_return, brg.jum_barang_return, brg.deskripsi, brg.id_supplier, brg.created_by);
            return RedirectToAction("Index","BrgReturn", new { Area = "Admin" });
        }

        public ActionResult Delete(int? id)
        {
            BarangReturn result = db.BarangReturn.Find(id);
            return View(result);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAction(int id)
        {
            BarangReturn result = db.BarangReturn.Find(id);
            db.BarangReturn.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index", new { Area = "Admin" });
        }

    }
}