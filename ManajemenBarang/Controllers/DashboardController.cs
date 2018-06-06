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
        RegModel rm = new RegModel();
        LogModel lm = new LogModel();
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
        /*
        public ActionResult LoginData(string username, string password)
        {
            List<LoginUser_Result> log = lm.GetLoginUser_Results(username,password);
            int user = 0;
            int? sup=0;
            foreach (var e in log)
            {
                user = e.id_user;
                sup = e.id_supplier;
            }
                //var session = Session;
                //session["lognya"] = log;
                return RedirectToAction("Index", "Supplier/Suppliersite",log);
            //return View("Index", "~Supplier/Suppliersite",log);
        }
        */
        [HttpPost]        
        public ActionResult LoginData(GetUsup2_Result objUser)
        {
            if (ModelState.IsValid)
            {
                using (dbStokEntities db = new dbStokEntities())
                {
                    var obj = db.tbUsers.Where(a => a.username.Equals(objUser.username) && a.password.Equals(objUser.password)).FirstOrDefault();
                    if (obj==null) { return View("ErrorLogin"); }
                    var supobj = db.Suppliers.Where(b => b.id_user.Equals(obj.id_user)).FirstOrDefault();
                                        
                    if (obj != null && obj.status_user == 1)
                    {
                        Session["UserID"] = obj.id_user.ToString();
                        Session["UserName"] = obj.username.ToString();
                        Session["SupID"] = supobj.id_supplier.ToString();
                        Session["SupName"] = supobj.nama_supplier.ToString();
                        return RedirectToAction("SupplierDashBoard");
                    }
                    else if (obj.status_user == 0)
                    {
                        Session["UserID"] = obj.id_user.ToString();
                        Session["UserName"] = obj.username.ToString();
                        return RedirectToAction("AdminDashBoard");
                    }
                    
                }
            }
            
            return View(objUser);
        }
        BarangSupModel bsm = new BarangSupModel();
        public ActionResult SupplierDashBoard()
        {
            if (Session["UserID"] != null)
            {

                //id_supplier = Convert.ToInt32(Session["SupID"]);
                //List<GetBarangSup_Result> bsup = bsm.GetBarangSup_Results(id_supplier);

                //using (dbStokEntities db = new dbStokEntities())
                //{
                    //var tes = db.Barangs.Where(a => a.id_supplier.Equals(Session["SupID"])).FirstOrDefault();
                    return RedirectToAction("Index", "Supplier/Suppliersite");
                //}
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult AdminDashBoard()
        {
            if (Session["UserID"] != null)
            {

                return RedirectToAction("Index", "Admin/Adminsite");
            }
            else
            {
                return View("Login");
            }
        }


        public ActionResult RegisterData(GetUsup2_Result usup)
        {
            string cekUsername = "";            
            string[] cekUsernameAr = new string[100];
            
            int i = 0;
            int j = 0;
            List<GetUsup2_Result> result = rm.GetUsers();
            foreach (var e in result)
            {
                cekUsername = e.username; cekUsernameAr[i] = cekUsername;                
                i++;
            }
            while (j <= i)
            {
                if (usup.username == cekUsernameAr[j])
                {
                    return View("Error");
                }
                j++;
            }

            dbe.AddUser(usup.id_user, usup.username, usup.password, usup.status_user, usup.nama_supplier, usup.alamat_supplier, usup.telp_supplier);
            return View("RegisterData");            
        }
    }
}