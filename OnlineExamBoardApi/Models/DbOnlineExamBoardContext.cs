using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OnlineExamBoardApi.Models;

public partial class DbOnlineExamBoardContext : DbContext
{
    public DbOnlineExamBoardContext()
    {
    }

    public DbOnlineExamBoardContext(DbContextOptions<DbOnlineExamBoardContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCollegeDetail> TblCollegeDetails { get; set; }

    public virtual DbSet<TblContactU> TblContactUs { get; set; }

    public virtual DbSet<TblContributor> TblContributors { get; set; }

    public virtual DbSet<TblExamResult> TblExamResults { get; set; }

    public virtual DbSet<TblGender> TblGenders { get; set; }

    public virtual DbSet<TblLanguage> TblLanguages { get; set; }

    public virtual DbSet<TblOfferedProgram> TblOfferedPrograms { get; set; }

    public virtual DbSet<TblProgramLanguagesMap> TblProgramLanguagesMaps { get; set; }

    public virtual DbSet<TblQuestionsBank> TblQuestionsBanks { get; set; }

    public virtual DbSet<TblQuestionsLevel> TblQuestionsLevels { get; set; }

    public virtual DbSet<TblQuestionsType> TblQuestionsTypes { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<TblStudentDetail> TblStudentDetails { get; set; }

    public virtual DbSet<TblStudentProgramsMap> TblStudentProgramsMaps { get; set; }

    public virtual DbSet<TblStudentTestQuestion> TblStudentTestQuestions { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-SRBIP0N; Database=dbOnlineExamBoard; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCollegeDetail>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblColle__9E5447B6D676B307");

            entity.ToTable("tblCollegeDetails");

            entity.Property(e => e.DteCreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedDate");
            entity.Property(e => e.DteModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteModifiedDate");
            entity.Property(e => e.IntCreatedBy).HasColumnName("intCreatedBy");
            entity.Property(e => e.IntModifiedBy).HasColumnName("intModifiedBy");
            entity.Property(e => e.StrAffiliationNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("strAffiliationNumber");
            entity.Property(e => e.StrCollegeAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("strCollegeAddress");
            entity.Property(e => e.StrCollegeName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("strCollegeName");
            entity.Property(e => e.StrContactNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("strContactNo");
            entity.Property(e => e.StrEmail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("strEmail");
            entity.Property(e => e.StrPhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("strPhoneNo");

            entity.HasOne(d => d.IntCreatedByNavigation).WithMany(p => p.TblCollegeDetailIntCreatedByNavigations)
                .HasForeignKey(d => d.IntCreatedBy)
                .HasConstraintName("FK_tblCollegeDetails_tblUsers");

            entity.HasOne(d => d.IntModifiedByNavigation).WithMany(p => p.TblCollegeDetailIntModifiedByNavigations)
                .HasForeignKey(d => d.IntModifiedBy)
                .HasConstraintName("FK_tblCollegeDetails_tblUsers1");
        });

        modelBuilder.Entity<TblContactU>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblConta__9E5447B65DF7529A");

            entity.ToTable("tblContactUs");

            entity.Property(e => e.DteCreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedDate");
            entity.Property(e => e.DteModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteModifiedDate");
            entity.Property(e => e.IntCreatedBy).HasColumnName("intCreatedBy");
            entity.Property(e => e.IntModifiedBy).HasColumnName("intModifiedBy");
            entity.Property(e => e.StrEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("strEmail");
            entity.Property(e => e.StrMessage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("strMessage");
            entity.Property(e => e.StrName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("strName");
            entity.Property(e => e.StrSubject)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("strSubject");

            entity.HasOne(d => d.IntCreatedByNavigation).WithMany(p => p.TblContactUIntCreatedByNavigations)
                .HasForeignKey(d => d.IntCreatedBy)
                .HasConstraintName("FK_tblContactUs_tblUsers");

            entity.HasOne(d => d.IntModifiedByNavigation).WithMany(p => p.TblContactUIntModifiedByNavigations)
                .HasForeignKey(d => d.IntModifiedBy)
                .HasConstraintName("FK_tblContactUs_tblUsers1");
        });

        modelBuilder.Entity<TblContributor>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblContr__9E5447B6E5B1EA23");

            entity.ToTable("tblContributor");

            entity.Property(e => e.DteCreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedDate");
            entity.Property(e => e.DteModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteModifiedDate");
            entity.Property(e => e.IntCreatedBy).HasColumnName("intCreatedBy");
            entity.Property(e => e.IntModifiedBy).HasColumnName("intModifiedBy");
            entity.Property(e => e.IntUserId).HasColumnName("intUserId");
            entity.Property(e => e.StrName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("strName");
            entity.Property(e => e.StrProfilePhoto)
                .HasMaxLength(1000)
                .HasColumnName("strProfilePhoto");

            entity.HasOne(d => d.IntCreatedByNavigation).WithMany(p => p.TblContributorIntCreatedByNavigations)
                .HasForeignKey(d => d.IntCreatedBy)
                .HasConstraintName("FK_tblContributor_tblUsers1");

            entity.HasOne(d => d.IntModifiedByNavigation).WithMany(p => p.TblContributorIntModifiedByNavigations)
                .HasForeignKey(d => d.IntModifiedBy)
                .HasConstraintName("FK_tblContributor_tblUsers2");

            entity.HasOne(d => d.IntUser).WithMany(p => p.TblContributorIntUsers)
                .HasForeignKey(d => d.IntUserId)
                .HasConstraintName("FK_tblContributor_tblUsers");
        });

        modelBuilder.Entity<TblExamResult>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblExamR__9E5447B6B4D96925");

            entity.ToTable("tblExamResults");

            entity.Property(e => e.DteCreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedDate");
            entity.Property(e => e.DteDateOfExam)
                .HasColumnType("datetime")
                .HasColumnName("dteDateOfExam");
            entity.Property(e => e.DteModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteModifiedDate");
            entity.Property(e => e.IntCollegeId).HasColumnName("intCollegeId");
            entity.Property(e => e.IntCreatedBy).HasColumnName("intCreatedBy");
            entity.Property(e => e.IntModifiedBy).HasColumnName("intModifiedBy");
            entity.Property(e => e.IntOfferedProgramId).HasColumnName("intOfferedProgramId");
            entity.Property(e => e.IntStudentId).HasColumnName("intStudentId");
            entity.Property(e => e.IntTotalNoOfCorrectAnswer).HasColumnName("intTotalNoOfCorrectAnswer");
            entity.Property(e => e.IntTotalNoOfQuestion).HasColumnName("intTotalNoOfQuestion");
            entity.Property(e => e.IntTotalNoOfQuestionAttempt).HasColumnName("intTotalNoOfQuestionAttempt");
            entity.Property(e => e.IntTotalNoOfQuestionSkip).HasColumnName("intTotalNoOfQuestionSkip");

            entity.HasOne(d => d.IntCollege).WithMany(p => p.TblExamResults)
                .HasForeignKey(d => d.IntCollegeId)
                .HasConstraintName("FK_tblExamResults_tblCollegeDetails");

            entity.HasOne(d => d.IntCreatedByNavigation).WithMany(p => p.TblExamResultIntCreatedByNavigations)
                .HasForeignKey(d => d.IntCreatedBy)
                .HasConstraintName("FK_tblExamResults_tblUsers1");

            entity.HasOne(d => d.IntModifiedByNavigation).WithMany(p => p.TblExamResultIntModifiedByNavigations)
                .HasForeignKey(d => d.IntModifiedBy)
                .HasConstraintName("FK_tblExamResults_tblUsers");

            entity.HasOne(d => d.IntOfferedProgram).WithMany(p => p.TblExamResults)
                .HasForeignKey(d => d.IntOfferedProgramId)
                .HasConstraintName("FK_tblExamResults_tblOfferedPrograms");

            entity.HasOne(d => d.IntStudent).WithMany(p => p.TblExamResults)
                .HasForeignKey(d => d.IntStudentId)
                .HasConstraintName("FK_tblExamResults_tblStudentDetails");
        });

        modelBuilder.Entity<TblGender>(entity =>
        {
            entity.HasKey(e => e.IntId);

            entity.ToTable("tblGender");

            entity.Property(e => e.StrGender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("strGender");
        });

        modelBuilder.Entity<TblLanguage>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblLangu__9E5447B666E5DDAB");

            entity.ToTable("tblLanguages");

            entity.Property(e => e.DteCreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedDate");
            entity.Property(e => e.DteModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteModifiedDate");
            entity.Property(e => e.IntCreatedBy).HasColumnName("intCreatedBy");
            entity.Property(e => e.IntModifiedBy).HasColumnName("intModifiedBy");
            entity.Property(e => e.StrLanguage)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("strLanguage");

            entity.HasOne(d => d.IntCreatedByNavigation).WithMany(p => p.TblLanguageIntCreatedByNavigations)
                .HasForeignKey(d => d.IntCreatedBy)
                .HasConstraintName("FK_tblLanguages_tblUsers");

            entity.HasOne(d => d.IntModifiedByNavigation).WithMany(p => p.TblLanguageIntModifiedByNavigations)
                .HasForeignKey(d => d.IntModifiedBy)
                .HasConstraintName("FK_tblLanguages_tblUsers1");
        });

        modelBuilder.Entity<TblOfferedProgram>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblOffer__9E5447B6DEFE7E97");

            entity.ToTable("tblOfferedPrograms");

            entity.Property(e => e.DteCreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedDate");
            entity.Property(e => e.DteModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteModifiedDate");
            entity.Property(e => e.IntCreatedBy).HasColumnName("intCreatedBy");
            entity.Property(e => e.IntModifiedBy).HasColumnName("intModifiedBy");
            entity.Property(e => e.StrDuration)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("strDuration");
            entity.Property(e => e.StrOfferedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("strOfferedBy");
            entity.Property(e => e.StrOfferedProgramName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("strOfferedProgramName");

            entity.HasOne(d => d.IntCreatedByNavigation).WithMany(p => p.TblOfferedProgramIntCreatedByNavigations)
                .HasForeignKey(d => d.IntCreatedBy)
                .HasConstraintName("FK_tblOfferedPrograms_tblUsers");

            entity.HasOne(d => d.IntModifiedByNavigation).WithMany(p => p.TblOfferedProgramIntModifiedByNavigations)
                .HasForeignKey(d => d.IntModifiedBy)
                .HasConstraintName("FK_tblOfferedPrograms_tblUsers1");
        });

        modelBuilder.Entity<TblProgramLanguagesMap>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblProgr__9E5447B6322F208B");

            entity.ToTable("tblProgramLanguagesMap");

            entity.Property(e => e.IntLanguageId).HasColumnName("intLanguageId");
            entity.Property(e => e.IntOfferedProgramId).HasColumnName("intOfferedProgramId");

            entity.HasOne(d => d.IntLanguage).WithMany(p => p.TblProgramLanguagesMaps)
                .HasForeignKey(d => d.IntLanguageId)
                .HasConstraintName("FK_tblProgramLanguagesMap_tblLanguages");

            entity.HasOne(d => d.IntOfferedProgram).WithMany(p => p.TblProgramLanguagesMaps)
                .HasForeignKey(d => d.IntOfferedProgramId)
                .HasConstraintName("FK_tblProgramLanguagesMap_tblOfferedPrograms");
        });

        modelBuilder.Entity<TblQuestionsBank>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblQuest__9E5447B62AED7B3F");

            entity.ToTable("tblQuestionsBank");

            entity.Property(e => e.DteCreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedDate");
            entity.Property(e => e.DteModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteModifiedDate");
            entity.Property(e => e.IntCreatedBy).HasColumnName("intCreatedBy");
            entity.Property(e => e.IntLanguageId).HasColumnName("intLanguageId");
            entity.Property(e => e.IntLevelId).HasColumnName("intLevelId");
            entity.Property(e => e.IntModifiedBy).HasColumnName("intModifiedBy");
            entity.Property(e => e.IntTypeId).HasColumnName("intTypeId");
            entity.Property(e => e.StrChoice1)
                .HasMaxLength(255)
                .HasColumnName("strChoice1");
            entity.Property(e => e.StrChoice2)
                .HasMaxLength(255)
                .HasColumnName("strChoice2");
            entity.Property(e => e.StrChoice3)
                .HasMaxLength(255)
                .HasColumnName("strChoice3");
            entity.Property(e => e.StrChoice4)
                .HasMaxLength(255)
                .HasColumnName("strChoice4");
            entity.Property(e => e.StrCorrectAnswer)
                .HasMaxLength(255)
                .HasColumnName("strCorrectAnswer");
            entity.Property(e => e.StrQuestion)
                .HasMaxLength(4000)
                .HasColumnName("strQuestion");

            entity.HasOne(d => d.IntCreatedByNavigation).WithMany(p => p.TblQuestionsBankIntCreatedByNavigations)
                .HasForeignKey(d => d.IntCreatedBy)
                .HasConstraintName("FK_tblQuestionsBank_tblUsers");

            entity.HasOne(d => d.IntLanguage).WithMany(p => p.TblQuestionsBanks)
                .HasForeignKey(d => d.IntLanguageId)
                .HasConstraintName("FK_tblQuestionsBank_tblLanguages");

            entity.HasOne(d => d.IntLevel).WithMany(p => p.TblQuestionsBanks)
                .HasForeignKey(d => d.IntLevelId)
                .HasConstraintName("FK_tblQuestionsBank_tblQuestionsLevel");

            entity.HasOne(d => d.IntModifiedByNavigation).WithMany(p => p.TblQuestionsBankIntModifiedByNavigations)
                .HasForeignKey(d => d.IntModifiedBy)
                .HasConstraintName("FK_tblQuestionsBank_tblUsers1");

            entity.HasOne(d => d.IntType).WithMany(p => p.TblQuestionsBanks)
                .HasForeignKey(d => d.IntTypeId)
                .HasConstraintName("FK_tblQuestionsBank_tblQuestionsType");
        });

        modelBuilder.Entity<TblQuestionsLevel>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblQuest__9E5447B66F557DDE");

            entity.ToTable("tblQuestionsLevel");

            entity.Property(e => e.StrQuestionLevel)
                .HasMaxLength(150)
                .HasColumnName("strQuestionLevel");
        });

        modelBuilder.Entity<TblQuestionsType>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblQuest__9E5447B68B53139E");

            entity.ToTable("tblQuestionsType");

            entity.Property(e => e.StrQuestionType)
                .HasMaxLength(150)
                .HasColumnName("strQuestionType");
        });

        modelBuilder.Entity<TblRole>(entity =>
        {
            entity.HasKey(e => e.IntId);

            entity.ToTable("tblRole");

            entity.Property(e => e.StrRole)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("strRole");
        });

        modelBuilder.Entity<TblStudentDetail>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblStude__9E5447B6BCEFF5BB");

            entity.ToTable("tblStudentDetails");

            entity.Property(e => e.DteCreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedDate");
            entity.Property(e => e.DteModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteModifiedDate");
            entity.Property(e => e.IntCollegeId).HasColumnName("intCollegeId");
            entity.Property(e => e.IntCreatedBy).HasColumnName("intCreatedBy");
            entity.Property(e => e.IntModifiedBy).HasColumnName("intModifiedBy");
            entity.Property(e => e.IntUserId).HasColumnName("intUserId");
            entity.Property(e => e.StrBranchName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("strBranchName");
            entity.Property(e => e.StrProfilePhoto)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("strProfilePhoto");

            entity.HasOne(d => d.IntCollege).WithMany(p => p.TblStudentDetails)
                .HasForeignKey(d => d.IntCollegeId)
                .HasConstraintName("FK_tblStudentDetails_tblCollegeDetails");

            entity.HasOne(d => d.IntCreatedByNavigation).WithMany(p => p.TblStudentDetailIntCreatedByNavigations)
                .HasForeignKey(d => d.IntCreatedBy)
                .HasConstraintName("FK_tblStudentDetails_tblUsers1");

            entity.HasOne(d => d.IntModifiedByNavigation).WithMany(p => p.TblStudentDetailIntModifiedByNavigations)
                .HasForeignKey(d => d.IntModifiedBy)
                .HasConstraintName("FK_tblStudentDetails_tblUsers2");

            entity.HasOne(d => d.IntUser).WithMany(p => p.TblStudentDetailIntUsers)
                .HasForeignKey(d => d.IntUserId)
                .HasConstraintName("FK_tblStudentDetails_tblUsers");
        });

        modelBuilder.Entity<TblStudentProgramsMap>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblStude__9E5447B6F47E616D");

            entity.ToTable("tblStudentProgramsMap");

            entity.Property(e => e.IntOfferedProgramId).HasColumnName("intOfferedProgramId");
            entity.Property(e => e.IntStudentId).HasColumnName("intStudentId");

            entity.HasOne(d => d.IntOfferedProgram).WithMany(p => p.TblStudentProgramsMaps)
                .HasForeignKey(d => d.IntOfferedProgramId)
                .HasConstraintName("FK_tblStudentProgramsMap_tblOfferedPrograms");

            entity.HasOne(d => d.IntStudent).WithMany(p => p.TblStudentProgramsMaps)
                .HasForeignKey(d => d.IntStudentId)
                .HasConstraintName("FK_tblStudentProgramsMap_tblStudentDetails");
        });

        modelBuilder.Entity<TblStudentTestQuestion>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblStude__9E5447B6F8C6DF37");

            entity.ToTable("tblStudentTestQuestions");

            entity.Property(e => e.IntQuestionBankId).HasColumnName("intQuestionBankID");
            entity.Property(e => e.IntStudentExamId).HasColumnName("intStudentExamId");
            entity.Property(e => e.IntStudentId).HasColumnName("intStudentId");

            entity.HasOne(d => d.IntQuestionBank).WithMany(p => p.TblStudentTestQuestions)
                .HasForeignKey(d => d.IntQuestionBankId)
                .HasConstraintName("FK_tblStudentTestQuestions_tblQuestionsBank");

            entity.HasOne(d => d.IntStudentExam).WithMany(p => p.TblStudentTestQuestions)
                .HasForeignKey(d => d.IntStudentExamId)
                .HasConstraintName("FK_tblStudentTestQuestions_tblExamResults");

            entity.HasOne(d => d.IntStudent).WithMany(p => p.TblStudentTestQuestions)
                .HasForeignKey(d => d.IntStudentId)
                .HasConstraintName("FK_tblStudentTestQuestions_tblStudentDetails");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.IntId).HasName("PK__tblUsers__9E5447B6DFA7312D");

            entity.ToTable("tblUsers");

            entity.Property(e => e.DteCreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedDate");
            entity.Property(e => e.DteModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteModifiedDate");
            entity.Property(e => e.IntCreatedBy).HasColumnName("intCreatedBy");
            entity.Property(e => e.IntGenderId).HasColumnName("intGenderId");
            entity.Property(e => e.IntModifiedBy).HasColumnName("intModifiedBy");
            entity.Property(e => e.IntRoleId).HasColumnName("intRoleId");
            entity.Property(e => e.StrEmail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("strEmail");
            entity.Property(e => e.StrFirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("strFirstName");
            entity.Property(e => e.StrHashpassword)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("strHashpassword");
            entity.Property(e => e.StrLastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("strLastName");
            entity.Property(e => e.StrMiddleName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("strMiddleName");
            entity.Property(e => e.StrPassword)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("strPassword");
            entity.Property(e => e.StrPhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("strPhoneNo");
            entity.Property(e => e.StrUserName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("strUserName");

            entity.HasOne(d => d.IntGender).WithMany(p => p.TblUsers)
                .HasForeignKey(d => d.IntGenderId)
                .HasConstraintName("FK_tblUsers_tblGender");

            entity.HasOne(d => d.IntRole).WithMany(p => p.TblUsers)
                .HasForeignKey(d => d.IntRoleId)
                .HasConstraintName("FK_tblUsers_tblRole");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
