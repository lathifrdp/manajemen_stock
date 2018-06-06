﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManajemenBarang.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbStokEntities : DbContext
    {
        public dbStokEntities()
            : base("name=dbStokEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Barang> Barangs { get; set; }
        public virtual DbSet<BarangKeluar> BarangKeluars { get; set; }
        public virtual DbSet<BarangMasuk> BarangMasuks { get; set; }
        public virtual DbSet<BarangReturn> BarangReturns { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<tbUser> tbUsers { get; set; }
    
        public virtual int AddUser(Nullable<int> id_user, string username, string password, Nullable<int> status_user, string nama_supplier, string alamat_supplier, string telp_supplier)
        {
            var id_userParameter = id_user.HasValue ?
                new ObjectParameter("id_user", id_user) :
                new ObjectParameter("id_user", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var status_userParameter = status_user.HasValue ?
                new ObjectParameter("status_user", status_user) :
                new ObjectParameter("status_user", typeof(int));
    
            var nama_supplierParameter = nama_supplier != null ?
                new ObjectParameter("nama_supplier", nama_supplier) :
                new ObjectParameter("nama_supplier", typeof(string));
    
            var alamat_supplierParameter = alamat_supplier != null ?
                new ObjectParameter("alamat_supplier", alamat_supplier) :
                new ObjectParameter("alamat_supplier", typeof(string));
    
            var telp_supplierParameter = telp_supplier != null ?
                new ObjectParameter("telp_supplier", telp_supplier) :
                new ObjectParameter("telp_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddUser", id_userParameter, usernameParameter, passwordParameter, status_userParameter, nama_supplierParameter, alamat_supplierParameter, telp_supplierParameter);
        }
    
        public virtual int AddSupplier(Nullable<int> id_user, string nama_supplier, string alamat_supplier, string telp_supplier)
        {
            var id_userParameter = id_user.HasValue ?
                new ObjectParameter("id_user", id_user) :
                new ObjectParameter("id_user", typeof(int));
    
            var nama_supplierParameter = nama_supplier != null ?
                new ObjectParameter("nama_supplier", nama_supplier) :
                new ObjectParameter("nama_supplier", typeof(string));
    
            var alamat_supplierParameter = alamat_supplier != null ?
                new ObjectParameter("alamat_supplier", alamat_supplier) :
                new ObjectParameter("alamat_supplier", typeof(string));
    
            var telp_supplierParameter = telp_supplier != null ?
                new ObjectParameter("telp_supplier", telp_supplier) :
                new ObjectParameter("telp_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddSupplier", id_userParameter, nama_supplierParameter, alamat_supplierParameter, telp_supplierParameter);
        }
    
        public virtual ObjectResult<GetUsup_Result> GetUsup()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUsup_Result>("GetUsup");
        }
    
        public virtual ObjectResult<LoginUser_Result> LoginUser(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LoginUser_Result>("LoginUser", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<GetUsup2_Result> GetUsup2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUsup2_Result>("GetUsup2");
        }
    
        public virtual ObjectResult<GetBarangSup_Result> GetBarangSup(Nullable<int> id_supplier)
        {
            var id_supplierParameter = id_supplier.HasValue ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangSup_Result>("GetBarangSup", id_supplierParameter);
        }
    
        public virtual ObjectResult<GetBarangSup2_Result> GetBarangSup2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangSup2_Result>("GetBarangSup2");
        }
    
        public virtual ObjectResult<GetKategori_Result> GetKategori()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetKategori_Result>("GetKategori");
        }
    
        public virtual int CreateData(Nullable<int> id_kategori, Nullable<int> id_supplier, string kode_barang, string nama_barang, Nullable<int> id_barang, Nullable<int> jumlah_barang, Nullable<System.DateTime> tanggal_masuk, Nullable<int> jum_barang_masuk, Nullable<int> created_by, string deskripsi, Nullable<int> updated_by)
        {
            var id_kategoriParameter = id_kategori.HasValue ?
                new ObjectParameter("id_kategori", id_kategori) :
                new ObjectParameter("id_kategori", typeof(int));
    
            var id_supplierParameter = id_supplier.HasValue ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(int));
    
            var kode_barangParameter = kode_barang != null ?
                new ObjectParameter("kode_barang", kode_barang) :
                new ObjectParameter("kode_barang", typeof(string));
    
            var nama_barangParameter = nama_barang != null ?
                new ObjectParameter("nama_barang", nama_barang) :
                new ObjectParameter("nama_barang", typeof(string));
    
            var id_barangParameter = id_barang.HasValue ?
                new ObjectParameter("id_barang", id_barang) :
                new ObjectParameter("id_barang", typeof(int));
    
            var jumlah_barangParameter = jumlah_barang.HasValue ?
                new ObjectParameter("jumlah_barang", jumlah_barang) :
                new ObjectParameter("jumlah_barang", typeof(int));
    
            var tanggal_masukParameter = tanggal_masuk.HasValue ?
                new ObjectParameter("tanggal_masuk", tanggal_masuk) :
                new ObjectParameter("tanggal_masuk", typeof(System.DateTime));
    
            var jum_barang_masukParameter = jum_barang_masuk.HasValue ?
                new ObjectParameter("jum_barang_masuk", jum_barang_masuk) :
                new ObjectParameter("jum_barang_masuk", typeof(int));
    
            var created_byParameter = created_by.HasValue ?
                new ObjectParameter("created_by", created_by) :
                new ObjectParameter("created_by", typeof(int));
    
            var deskripsiParameter = deskripsi != null ?
                new ObjectParameter("deskripsi", deskripsi) :
                new ObjectParameter("deskripsi", typeof(string));
    
            var updated_byParameter = updated_by.HasValue ?
                new ObjectParameter("updated_by", updated_by) :
                new ObjectParameter("updated_by", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateData", id_kategoriParameter, id_supplierParameter, kode_barangParameter, nama_barangParameter, id_barangParameter, jumlah_barangParameter, tanggal_masukParameter, jum_barang_masukParameter, created_byParameter, deskripsiParameter, updated_byParameter);
        }
    
        public virtual ObjectResult<GetBarangSup3_Result> GetBarangSup3()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangSup3_Result>("GetBarangSup3");
        }
    
        public virtual ObjectResult<GetBarangSup4_Result> GetBarangSup4()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangSup4_Result>("GetBarangSup4");
        }
    
        public virtual ObjectResult<GetSupplay_Result> GetSupplay()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSupplay_Result>("GetSupplay");
        }
    
        public virtual ObjectResult<GetBarangWhere_Result> GetBarangWhere(Nullable<int> id_supplier)
        {
            var id_supplierParameter = id_supplier.HasValue ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangWhere_Result>("GetBarangWhere", id_supplierParameter);
        }
    
        public virtual ObjectResult<GetBarangWhere2_Result> GetBarangWhere2(string id_supplier)
        {
            var id_supplierParameter = id_supplier != null ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangWhere2_Result>("GetBarangWhere2", id_supplierParameter);
        }
    
        public virtual ObjectResult<GetBarangWhere3_Result> GetBarangWhere3(string id_supplier)
        {
            var id_supplierParameter = id_supplier != null ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangWhere3_Result>("GetBarangWhere3", id_supplierParameter);
        }
    
        public virtual ObjectResult<string> GetCreatedSupplier()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetCreatedSupplier");
        }
    
        public virtual ObjectResult<string> GetCreatedSupplier2(string id_supplier)
        {
            var id_supplierParameter = id_supplier != null ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetCreatedSupplier2", id_supplierParameter);
        }
    
        public virtual ObjectResult<GetCreatedSupplier3_Result> GetCreatedSupplier3(string id_supplier)
        {
            var id_supplierParameter = id_supplier != null ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCreatedSupplier3_Result>("GetCreatedSupplier3", id_supplierParameter);
        }
    
        public virtual ObjectResult<GetProfil_Result> GetProfil(string id_supplier)
        {
            var id_supplierParameter = id_supplier != null ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProfil_Result>("GetProfil", id_supplierParameter);
        }
    }
}
