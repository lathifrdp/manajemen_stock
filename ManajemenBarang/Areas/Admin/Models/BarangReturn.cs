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
    using System.Collections.Generic;
    
    public partial class BarangReturn
    {
        public int id_barang_return { get; set; }
        public Nullable<int> id_barang { get; set; }
        public Nullable<int> id_supplier { get; set; }
        public Nullable<System.DateTime> tanggal_return { get; set; }
        public Nullable<int> jum_barang_return { get; set; }
        public string deskripsi { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<int> updated_by { get; set; }
    }
}
