﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace K2_Generate_Package_Code_15_Digit.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C5PackageCode> C5PackageCode { get; set; }
        public virtual DbSet<AnotherDecimal> AnotherDecimals { get; set; }
        public virtual DbSet<BallHeight> BallHeights { get; set; }
        public virtual DbSet<Control> Controls { get; set; }
        public virtual DbSet<FrameFlowType> FrameFlowTypes { get; set; }
        public virtual DbSet<IntDecimal> IntDecimals { get; set; }
        public virtual DbSet<LeadBallPitch> LeadBallPitches { get; set; }
        public virtual DbSet<M2DA> M2DA { get; set; }
        public virtual DbSet<M2DAMandFillarea> M2DAMandFillarea { get; set; }
        public virtual DbSet<M2DepopulatePin> M2DepopulatePin { get; set; }
        public virtual DbSet<M2LeadframeType> M2LeadframeType { get; set; }
        public virtual DbSet<M2pkgsize> M2pkgsize { get; set; }
        public virtual DbSet<M2pkgthickness> M2pkgthickness { get; set; }
        public virtual DbSet<M2PlatingType> M2PlatingType { get; set; }
        public virtual DbSet<M2SpecialMoldFeature> M2SpecialMoldFeature { get; set; }
        public virtual DbSet<M2WB> M2WB { get; set; }
        public virtual DbSet<MoldThickness> MoldThicknesses { get; set; }
        public virtual DbSet<PackageHeight> PackageHeights { get; set; }
        public virtual DbSet<PackageSpecialCode> PackageSpecialCodes { get; set; }
        public virtual DbSet<PackageThicknessAfterMold> PackageThicknessAfterMolds { get; set; }
        public virtual DbSet<PackageType> PackageTypes { get; set; }
        public virtual DbSet<PinBallCount> PinBallCounts { get; set; }
    }
}
