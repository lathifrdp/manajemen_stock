//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManajemenBarang.Areas.Admin.Models
{
    using System;
    
    public partial class spGetBarang_Result
    {
        public int id_brg { get; set; }
        public string kode_brg { get; set; }
        public string nama_brg { get; set; }
        public Nullable<int> jumlah_brg { get; set; }
        public Nullable<int> id_kat { get; set; }
        public string deskripsi_brg { get; set; }
        public Nullable<int> id_sup { get; set; }
        public Nullable<System.DateTime> tanggal_msk { get; set; }
        public Nullable<int> id_pj { get; set; }
    }
}
