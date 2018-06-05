using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManajemenBarang.Models
{
    public class LogModel
    {
        dbStokEntities dbe = new dbStokEntities();
        public List<LoginUser_Result> GetLoginUser_Results(string username, string password)
        {
            return dbe.LoginUser(username,password).ToList<LoginUser_Result>();
        }
    }
}