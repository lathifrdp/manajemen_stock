using ManajemenBarang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManajemenBarang.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        dbStokEntities dbe = new dbStokEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult LoginData()
        {
            return View();
        }
        public ActionResult RegisterData(GetUsup_Result usup)
        {
            dbe.AddUser(usup.id_user, usup.username, usup.password, usup.status_user, usup.nama_supplier, usup.alamat_supplier, usup.telp_supplier);
            return View("RegisterData");            
        }
    }
}