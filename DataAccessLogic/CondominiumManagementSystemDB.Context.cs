﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLogic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CondominiumManagementSystemDBEntities : DbContext
    {
        public CondominiumManagementSystemDBEntities()
            : base("name=CondominiumManagementSystemDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblExpense> tblExpenses { get; set; }
        public virtual DbSet<tblExpenseReason> tblExpenseReasons { get; set; }
        public virtual DbSet<tblGender> tblGenders { get; set; }
        public virtual DbSet<tblHouse> tblHouses { get; set; }
        public virtual DbSet<tblHouseOwner> tblHouseOwners { get; set; }
        public virtual DbSet<tblHousePayment> tblHousePayments { get; set; }
        public virtual DbSet<tblMaritalStatu> tblMaritalStatus { get; set; }
        public virtual DbSet<tblOwner> tblOwners { get; set; }
        public virtual DbSet<tblPaymentReason> tblPaymentReasons { get; set; }
        public virtual DbSet<tblRegion> tblRegions { get; set; }
        public virtual DbSet<tblRole> tblRoles { get; set; }
        public virtual DbSet<tblSubCity> tblSubCities { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUserRole> tblUserRoles { get; set; }
        public virtual DbSet<tblWoreda> tblWoredas { get; set; }
    }
}
