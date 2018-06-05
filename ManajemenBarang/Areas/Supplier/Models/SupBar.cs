using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManajemenBarang.Models;

namespace ManajemenBarang.Areas.Supplier.Models
{
    public class SupBar
    {
        dbStokEntities dbe = new dbStokEntities();
        public List<GetSupplay_Result> GetSupplay_Results()
        {
            return dbe.GetSupplay().ToList<GetSupplay_Result>();
        }
    }
}