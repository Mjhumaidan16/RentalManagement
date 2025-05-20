using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AdvanceProjectObjects
{
    public partial class EquipmentRentalDBContext : DbContext
    {
        public EquipmentRentalDBContext()
        {
        }

        public EquipmentRentalDBContext(DbContextOptions<EquipmentRentalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<Equipment> Equipment { get; set; } = null!;
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<MaintenanceRecord> MaintenanceRecords { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<RentalRequest> RentalRequests { get; set; } = null!;
        public virtual DbSet<RentalTransaction> RentalTransactions { get; set; } = null!;
        public virtual DbSet<ReturnRecord> ReturnRecords { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=EquipmentRentalDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.UploadedAt).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RentalTransaction)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.RentalTransactionId)
                    .HasConstraintName("FK__Documents__Renta__4AB81AF0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Documents__UserI__4BAC3F29");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdated).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Equipment__Categ__300424B4");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Feedback__Custom__44FF419A");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Feedback__Equipm__45F365D3");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK__Feedback__Transa__46E78A0C");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.Timestamp).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Logs__UserID__5629CD9C");
            });

            modelBuilder.Entity<MaintenanceRecord>(entity =>
            {
                entity.HasKey(e => e.MaintenanceId)
                    .HasName("PK__Maintena__E60542B5E38FFE33");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.MaintenanceRecords)
                    .HasForeignKey(d => d.EquipmentId)
                    .HasConstraintName("FK__Maintenan__Equip__5FB337D6");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Notificat__UserI__5165187F");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.PaymentDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK__Payments__Transa__5BE2A6F2");
            });

            modelBuilder.Entity<RentalRequest>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PK__RentalRe__33A8519AA59F17D3");

                entity.Property(e => e.DateRequested).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RentalRequests)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__RentalReq__Custo__34C8D9D1");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.RentalRequests)
                    .HasForeignKey(d => d.EquipmentId)
                    .HasConstraintName("FK__RentalReq__Equip__35BCFE0A");
            });

            modelBuilder.Entity<RentalTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__RentalTr__55433A4BB04930D7");

                entity.Property(e => e.DateProcessed).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RentalTransactions)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RentalTra__Custo__3B75D760");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.RentalTransactions)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RentalTra__Equip__3C69FB99");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RentalTransactions)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK__RentalTra__Reque__3A81B327");
            });

            modelBuilder.Entity<ReturnRecord>(entity =>
            {
                entity.HasKey(e => e.ReturnId)
                    .HasName("PK__ReturnRe__F445E988341E98BE");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.ReturnRecords)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK__ReturnRec__Trans__403A8C7D");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
