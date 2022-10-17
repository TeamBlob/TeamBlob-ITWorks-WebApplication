using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ITWorks_Application.DBModels;

#nullable disable

namespace ITWorks_Application.Data
{
    public partial class itworkxdevdatabaseContext : DbContext
    {
        public itworkxdevdatabaseContext()
        {
        }

        public itworkxdevdatabaseContext(DbContextOptions<itworkxdevdatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountDatum> AccountData { get; set; }
        public virtual DbSet<AccountTypeAssignmentDatum> AccountTypeAssignmentData { get; set; }
        public virtual DbSet<AccountTypeDatum> AccountTypeData { get; set; }
        public virtual DbSet<BrandDeviceDatum> BrandDeviceData { get; set; }
        public virtual DbSet<BrandDeviceFixCategoryDatum> BrandDeviceFixCategoryData { get; set; }
        public virtual DbSet<BrandModelDatum> BrandModelData { get; set; }
        public virtual DbSet<FaqdeviceCategoryDatum> FaqdeviceCategoryData { get; set; }
        public virtual DbSet<FixCategoryDatum> FixCategoryData { get; set; }
        public virtual DbSet<FixDatum> FixData { get; set; }
        public virtual DbSet<FixInstructionDatum> FixInstructionData { get; set; }
        public virtual DbSet<ForumAnswerDatum> ForumAnswerData { get; set; }
        public virtual DbSet<ForumBrandDatum> ForumBrandData { get; set; }
        public virtual DbSet<ForumCommentDatum> ForumCommentData { get; set; }
        public virtual DbSet<ForumDeviceCategoryDatum> ForumDeviceCategoryData { get; set; }
        public virtual DbSet<ForumIssueDatum> ForumIssueData { get; set; }
        public virtual DbSet<ForumQuestionDatum> ForumQuestionData { get; set; }
        public virtual DbSet<ForumQuestionVotesDatum> ForumQuestionVotesData { get; set; }
        public virtual DbSet<ForumSubIssueDatum> ForumSubIssueData { get; set; }
        public virtual DbSet<InstructionDatum> InstructionData { get; set; }
        public virtual DbSet<TechnicalAccountDatum> TechnicalAccountData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=itworkxdev-server.database.windows.net; initial catalog=itworkxdev-database; User Id=itworkxdev-server-admin; password=R3SB67ZZFO5RS6DY$;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountDatum>(entity =>
            {
                entity.Property(e => e.AccountId).ValueGeneratedNever();

                entity.Property(e => e.AccountName).IsFixedLength(true);

                entity.Property(e => e.AccountPassword).IsFixedLength(true);
            });

            modelBuilder.Entity<AccountTypeDatum>(entity =>
            {
                entity.Property(e => e.TypeName).IsFixedLength(true);
            });

            modelBuilder.Entity<BrandDeviceDatum>(entity =>
            {
                entity.Property(e => e.BrandDeviceId).ValueGeneratedNever();
            });

            modelBuilder.Entity<BrandModelDatum>(entity =>
            {
                entity.Property(e => e.BrandId).ValueGeneratedNever();

                entity.Property(e => e.BrandImage).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);
            });

            modelBuilder.Entity<FaqdeviceCategoryDatum>(entity =>
            {
                entity.Property(e => e.FaqdeviceCategoryId).ValueGeneratedNever();

                entity.Property(e => e.FaqdeviceCategoryImage).IsUnicode(false);

                entity.Property(e => e.FaqdeviceCategoryImgalt).IsUnicode(false);

                entity.Property(e => e.FaqdeviceCategoryImgcss).IsUnicode(false);

                entity.Property(e => e.FaqdeviceCategoryName).IsUnicode(false);

                entity.Property(e => e.FaqdeviceCategoryTxtcss).IsUnicode(false);
            });

            modelBuilder.Entity<FixCategoryDatum>(entity =>
            {
                entity.Property(e => e.FixCateogryId).ValueGeneratedNever();

                entity.Property(e => e.FixCategoryName).IsUnicode(false);
            });

            modelBuilder.Entity<FixDatum>(entity =>
            {
                entity.Property(e => e.FixId).ValueGeneratedNever();

                entity.Property(e => e.FixDescription).IsUnicode(false);

                entity.Property(e => e.FixTitle).IsUnicode(false);
            });

            modelBuilder.Entity<ForumBrandDatum>(entity =>
            {
                entity.Property(e => e.ForumBrandId).ValueGeneratedNever();

                entity.Property(e => e.ForumBrandName).IsUnicode(false);
            });

            modelBuilder.Entity<ForumDeviceCategoryDatum>(entity =>
            {
                entity.Property(e => e.DeviceCategoryId).ValueGeneratedNever();

                entity.Property(e => e.DeviceCategoryName).IsUnicode(false);
            });

            modelBuilder.Entity<ForumIssueDatum>(entity =>
            {
                entity.Property(e => e.IssueId).ValueGeneratedNever();

                entity.Property(e => e.IssueName).IsUnicode(false);
            });

            modelBuilder.Entity<ForumQuestionVotesDatum>(entity =>
            {
                entity.Property(e => e.QuestionId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ForumSubIssueDatum>(entity =>
            {
                entity.Property(e => e.SubIssueId).ValueGeneratedNever();

                entity.Property(e => e.SubIssueName).IsUnicode(false);
            });

            modelBuilder.Entity<InstructionDatum>(entity =>
            {
                entity.Property(e => e.InstructionId).ValueGeneratedNever();

                entity.Property(e => e.InstructionContent).IsUnicode(false);

                entity.Property(e => e.InstructionTitle).IsUnicode(false);
            });

            modelBuilder.Entity<TechnicalAccountDatum>(entity =>
            {
                entity.Property(e => e.AccountId).ValueGeneratedNever();

                entity.Property(e => e.AccountName).IsFixedLength(true);

                entity.Property(e => e.AccountPassword).IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
