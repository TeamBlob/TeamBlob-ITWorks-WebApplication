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
                optionsBuilder.UseSqlServer("Data Source=itworkxdev-server.database.windows.net; Initial Catalog=itworkxdev-database; User id=itworkxdev-server-admin; Password=R3SB67ZZFO5RS6DY$;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountDatum>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.Property(e => e.AccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("AccountID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsFixedLength(true);

                entity.Property(e => e.AccountPassword)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsFixedLength(true);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");
            });

            modelBuilder.Entity<AccountTypeAssignmentDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<AccountTypeDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<BrandDeviceDatum>(entity =>
            {
                entity.HasKey(e => e.BrandDeviceId);

                entity.Property(e => e.BrandDeviceId)
                    .ValueGeneratedNever()
                    .HasColumnName("BrandDeviceID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.FaqdeviceCategoryId).HasColumnName("FAQDeviceCategoryID");
            });

            modelBuilder.Entity<BrandDeviceFixCategoryDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BrandDeviceId).HasColumnName("BrandDeviceID");

                entity.Property(e => e.FixCateogryId).HasColumnName("FixCateogryID");
            });

            modelBuilder.Entity<BrandModelDatum>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.Property(e => e.BrandId)
                    .ValueGeneratedNever()
                    .HasColumnName("BrandID");

                entity.Property(e => e.BrandImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FaqdeviceCategoryDatum>(entity =>
            {
                entity.HasKey(e => e.FaqdeviceCategoryId);

                entity.ToTable("FAQDeviceCategoryData");

                entity.Property(e => e.FaqdeviceCategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("FAQDeviceCategoryID");

                entity.Property(e => e.FaqdeviceCategoryImage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAQDeviceCategoryImage");

                entity.Property(e => e.FaqdeviceCategoryImgalt)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FAQDeviceCategoryIMGALT");

                entity.Property(e => e.FaqdeviceCategoryImgcss)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FAQDeviceCategoryIMGCSS");

                entity.Property(e => e.FaqdeviceCategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAQDeviceCategoryName");

                entity.Property(e => e.FaqdeviceCategoryTxtcss)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FAQDeviceCategoryTXTCSS");
            });

            modelBuilder.Entity<FixCategoryDatum>(entity =>
            {
                entity.HasKey(e => e.FixCateogryId);

                entity.Property(e => e.FixCateogryId)
                    .ValueGeneratedNever()
                    .HasColumnName("FixCateogryID");

                entity.Property(e => e.FixCategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FixDatum>(entity =>
            {
                entity.HasKey(e => e.FixId);

                entity.Property(e => e.FixId)
                    .ValueGeneratedNever()
                    .HasColumnName("FixID");

                entity.Property(e => e.BrandDeviceId).HasColumnName("BrandDeviceID");

                entity.Property(e => e.FixCateogryId).HasColumnName("FixCateogryID");

                entity.Property(e => e.FixDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FixTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FixInstructionDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FixId).HasColumnName("FixID");

                entity.Property(e => e.InstructionId).HasColumnName("InstructionID");
            });

            modelBuilder.Entity<ForumAnswerDatum>(entity =>
            {
                entity.HasKey(e => e.AnswerId);

                entity.Property(e => e.AnswerId)
                    .ValueGeneratedNever()
                    .HasColumnName("AnswerID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AnswerContent).HasMaxLength(200);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.UploadDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("UploadDateTIme");
            });

            modelBuilder.Entity<ForumBrandDatum>(entity =>
            {
                entity.HasKey(e => e.ForumBrandId);

                entity.Property(e => e.ForumBrandId)
                    .ValueGeneratedNever()
                    .HasColumnName("ForumBrandID");

                entity.Property(e => e.ForumBrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ForumCommentDatum>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.Property(e => e.CommentId)
                    .ValueGeneratedNever()
                    .HasColumnName("CommentID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.CommentContent).HasMaxLength(200);

                entity.Property(e => e.UploadDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("UploadDateTIme");
            });

            modelBuilder.Entity<ForumDeviceCategoryDatum>(entity =>
            {
                entity.HasKey(e => e.DeviceCategoryId);

                entity.Property(e => e.DeviceCategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("DeviceCategoryID");

                entity.Property(e => e.DeviceCategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ForumIssueDatum>(entity =>
            {
                entity.HasKey(e => e.IssueId);

                entity.Property(e => e.IssueId)
                    .ValueGeneratedNever()
                    .HasColumnName("IssueID");

                entity.Property(e => e.IssueName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ForumQuestionDatum>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.DeviceCategoryId).HasColumnName("DeviceCategoryID");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.QuestionContent).HasMaxLength(200);

                entity.Property(e => e.QuestionTitle).HasMaxLength(200);

                entity.Property(e => e.SubIssueId).HasColumnName("SubIssueID");

                entity.Property(e => e.UploadDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("UploadDateTIme");
            });

            modelBuilder.Entity<ForumQuestionVotesDatum>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.Property(e => e.QuestionId)
                    .ValueGeneratedNever()
                    .HasColumnName("QuestionID");
            });

            modelBuilder.Entity<ForumSubIssueDatum>(entity =>
            {
                entity.HasKey(e => e.SubIssueId);

                entity.Property(e => e.SubIssueId)
                    .ValueGeneratedNever()
                    .HasColumnName("SubIssueID");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.SubIssueName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InstructionDatum>(entity =>
            {
                entity.HasKey(e => e.InstructionId);

                entity.Property(e => e.InstructionId)
                    .ValueGeneratedNever()
                    .HasColumnName("InstructionID");

                entity.Property(e => e.InstructionContent)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstructionTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechnicalAccountDatum>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.Property(e => e.AccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("AccountID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsFixedLength(true);

                entity.Property(e => e.AccountPassword)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsFixedLength(true);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
