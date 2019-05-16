namespace SKR_User.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SKRDB : DbContext
    {
        public SKRDB()
            : base("name=SKRDataBase")
        {
        }

        public virtual DbSet<FeedBack> FeedBacks { get; set; }
        public virtual DbSet<LiuYan> LiuYans { get; set; }
        public virtual DbSet<UserBasic> UserBasics { get; set; }
        public virtual DbSet<AdminBasic> AdminBasics { get; set; }
        public virtual DbSet<BuildingInfo> BuildingInfoes { get; set; }
        public virtual DbSet<LogInfo> LogInfoes { get; set; }
        public virtual DbSet<PileInfo> PileInfoes { get; set; }
        public virtual DbSet<RFIDInfo> RFIDInfoes { get; set; }
        public virtual DbSet<UserBalance> UserBalances { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeedBack>()
                .Property(e => e.EngineerReback)
                .IsUnicode(false);

            modelBuilder.Entity<LiuYan>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<UserBasic>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<UserBasic>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserBasic>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<UserBasic>()
                .Property(e => e.UserImage)
                .IsUnicode(false);

            modelBuilder.Entity<AdminBasic>()
                .Property(e => e.AdminName)
                .IsUnicode(false);

            modelBuilder.Entity<AdminBasic>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<AdminBasic>()
                .Property(e => e.AdminImage)
                .IsUnicode(false);
        }
    }
}
