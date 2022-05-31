using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using pending_webAPI.Domains;

#nullable disable

namespace pending_webAPI.Contexts
{
    public partial class pendingContext : DbContext
    {
        public pendingContext()
        {
        }

        public pendingContext(DbContextOptions<pendingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BAddress> BAddresses { get; set; }
        public virtual DbSet<Business> Businesses { get; set; }
        public virtual DbSet<CAccount> CAccounts { get; set; }
        public virtual DbSet<CashFlow> CashFlows { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Situation> Situations { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TypeTransaction> TypeTransactions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=NOTE0113B2\\SQLEXPRESS; initial catalog=pending; user Id=sa; pwd=Senai@132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<BAddress>(entity =>
            {
                entity.HasKey(e => e.IdBAddress)
                    .HasName("PK__B_Addres__C4A4F73E337AE3F5");

                entity.ToTable("B_Address");

                entity.HasIndex(e => e.IdUser, "UQ__B_Addres__981CF29CB239E6FA")
                    .IsUnique();

                entity.Property(e => e.IdBAddress).HasColumnName("idB_Address");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.IdUser).HasColumnName("idUser_");

                entity.Property(e => e.Neighborhood)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("neighborhood");

                entity.Property(e => e.Number)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.Street)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("street");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("zipcode");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithOne(p => p.BAddress)
                    .HasForeignKey<BAddress>(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__B_Address__idUse__76969D2E");
            });

            modelBuilder.Entity<Business>(entity =>
            {
                entity.HasKey(e => e.IdBusiness)
                    .HasName("PK__Business__79BC445D121F5BED");

                entity.ToTable("Business");

                entity.HasIndex(e => e.IdUser, "UQ__Business__981CF29C532DCDC8")
                    .IsUnique();

                entity.HasIndex(e => e.IdBAddress, "UQ__Business__C4A4F73F4422B895")
                    .IsUnique();

                entity.Property(e => e.IdBusiness).HasColumnName("idBusiness");

                entity.Property(e => e.ExpenseBusiness)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("expenseBusiness");

                entity.Property(e => e.IdBAddress).HasColumnName("idB_Address");

                entity.Property(e => e.IdUser).HasColumnName("idUser_");

                entity.Property(e => e.NameBusiness)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nameBusiness");

                entity.Property(e => e.ProfitBusiness)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("profitBusiness");

                entity.HasOne(d => d.IdBAddressNavigation)
                    .WithOne(p => p.Business)
                    .HasForeignKey<Business>(d => d.IdBAddress)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Business__idB_Ad__02084FDA");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithOne(p => p.Business)
                    .HasForeignKey<Business>(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Business__idUser__01142BA1");
            });

            modelBuilder.Entity<CAccount>(entity =>
            {
                entity.HasKey(e => e.IdCAccount)
                    .HasName("PK__C_Accoun__7C3053E8B175062A");

                entity.ToTable("C_Account");

                entity.HasIndex(e => e.IdClient, "UQ__C_Accoun__A6A610D50621BA62")
                    .IsUnique();

                entity.Property(e => e.IdCAccount).HasColumnName("idC_Account");

                entity.Property(e => e.Balance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("balance");

                entity.Property(e => e.IdClient).HasColumnName("idClient");

                entity.Property(e => e.IdSituation).HasColumnName("idSituation");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithOne(p => p.CAccount)
                    .HasForeignKey<CAccount>(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__C_Account__idCli__6D0D32F4");

                entity.HasOne(d => d.IdSituationNavigation)
                    .WithMany(p => p.CAccounts)
                    .HasForeignKey(d => d.IdSituation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__C_Account__idSit__6E01572D");
            });

            modelBuilder.Entity<CashFlow>(entity =>
            {
                entity.HasKey(e => e.IdCashFlow)
                    .HasName("PK__CashFlow__69744B5E005BBEA4");

                entity.ToTable("CashFlow");

                entity.HasIndex(e => e.IdSituation, "UQ__CashFlow__35C763021242DC3F")
                    .IsUnique();

                entity.HasIndex(e => e.IdBusiness, "UQ__CashFlow__79BC445C0A70A7D3")
                    .IsUnique();

                entity.Property(e => e.IdCashFlow).HasColumnName("idCashFlow");

                entity.Property(e => e.EstimatedBalance)
                    .HasColumnType("money")
                    .HasColumnName("estimatedBalance");

                entity.Property(e => e.ExpensesClients)
                    .HasColumnType("money")
                    .HasColumnName("expensesClients");

                entity.Property(e => e.IdBusiness).HasColumnName("idBusiness");

                entity.Property(e => e.IdSituation).HasColumnName("idSituation");

                entity.Property(e => e.MonthBalance)
                    .HasColumnType("money")
                    .HasColumnName("monthBalance");

                entity.Property(e => e.MonthExpenses)
                    .HasColumnType("money")
                    .HasColumnName("monthExpenses");

                entity.Property(e => e.MonthProfits)
                    .HasColumnType("money")
                    .HasColumnName("monthProfits");

                entity.Property(e => e.OweClients)
                    .HasColumnType("money")
                    .HasColumnName("oweClients");

                entity.Property(e => e.ProfitsClients)
                    .HasColumnType("money")
                    .HasColumnName("profitsClients");

                entity.Property(e => e.RealBalance)
                    .HasColumnType("money")
                    .HasColumnName("realBalance");

                entity.Property(e => e.TotalExpenses)
                    .HasColumnType("money")
                    .HasColumnName("totalExpenses");

                entity.Property(e => e.TotalProfits)
                    .HasColumnType("money")
                    .HasColumnName("totalProfits");

                entity.HasOne(d => d.IdBusinessNavigation)
                    .WithOne(p => p.CashFlow)
                    .HasForeignKey<CashFlow>(d => d.IdBusiness)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CashFlow__idBusi__06CD04F7");

                entity.HasOne(d => d.IdSituationNavigation)
                    .WithOne(p => p.CashFlow)
                    .HasForeignKey<CashFlow>(d => d.IdSituation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CashFlow__idSitu__07C12930");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("PK__Client__A6A610D4C8AE0E0C");

                entity.ToTable("Client");

                entity.Property(e => e.IdClient).HasColumnName("idClient");

                entity.Property(e => e.NameClient)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nameClient");

                entity.Property(e => e.PhoneClient)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phoneClient");
            });

            modelBuilder.Entity<Situation>(entity =>
            {
                entity.HasKey(e => e.IdSituation)
                    .HasName("PK__Situatio__35C7630353C0D171");

                entity.ToTable("Situation");

                entity.Property(e => e.IdSituation).HasColumnName("idSituation");

                entity.Property(e => e.TypeSituation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typeSituation");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.IdTransaction)
                    .HasName("PK__Transact__BF330CF11D573BA6");

                entity.ToTable("Transaction_");

                entity.Property(e => e.IdTransaction).HasColumnName("idTransaction_");

                entity.Property(e => e.DateTransaction)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dateTransaction_");

                entity.Property(e => e.IdClient).HasColumnName("idClient");

                entity.Property(e => e.IdTypeTransaction).HasColumnName("idTypeTransaction");

                entity.Property(e => e.ValueTransaction)
                    .HasColumnType("money")
                    .HasColumnName("valueTransaction_");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Transacti__idCli__3F466844");

                entity.HasOne(d => d.IdTypeTransactionNavigation)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.IdTypeTransaction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Transacti__idTyp__403A8C7D");
            });

            modelBuilder.Entity<TypeTransaction>(entity =>
            {
                entity.HasKey(e => e.IdTypeTransaction)
                    .HasName("PK__TypeTran__A3DC5629A9236A56");

                entity.ToTable("TypeTransaction_");

                entity.Property(e => e.IdTypeTransaction).HasColumnName("idTypeTransaction");

                entity.Property(e => e.NameTypeTransaction)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nameTypeTransaction");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__User___981CF29DF7C42885");

                entity.ToTable("User_");

                entity.HasIndex(e => e.EmailUser, "UQ__User___9BCF40BE9ED775D9")
                    .IsUnique();

                entity.Property(e => e.IdUser).HasColumnName("idUser_");

                entity.Property(e => e.EmailUser)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("emailUser_");

                entity.Property(e => e.PasswordUser)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("passwordUser_");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
