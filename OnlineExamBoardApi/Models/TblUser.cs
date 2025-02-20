using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblUser
{
    public int IntId { get; set; }

    public string? StrFirstName { get; set; }

    public string? StrMiddleName { get; set; }

    public string? StrLastName { get; set; }

    public string? StrPhoneNo { get; set; }

    public string? StrEmail { get; set; }

    public int? IntGenderId { get; set; }

    public string? StrUserName { get; set; }

    public string? StrPassword { get; set; }

    public string? StrHashpassword { get; set; }

    public int? IntRoleId { get; set; }

    public bool? IsActive { get; set; }

    public int? IntCreatedBy { get; set; }

    public DateTime? DteCreatedDate { get; set; }

    public int? IntModifiedBy { get; set; }

    public DateTime? DteModifiedDate { get; set; }

    public virtual TblGender? IntGender { get; set; }

    public virtual TblRole? IntRole { get; set; }

    public virtual ICollection<TblCollegeDetail> TblCollegeDetailIntCreatedByNavigations { get; set; } = new List<TblCollegeDetail>();

    public virtual ICollection<TblCollegeDetail> TblCollegeDetailIntModifiedByNavigations { get; set; } = new List<TblCollegeDetail>();

    public virtual ICollection<TblContactU> TblContactUIntCreatedByNavigations { get; set; } = new List<TblContactU>();

    public virtual ICollection<TblContactU> TblContactUIntModifiedByNavigations { get; set; } = new List<TblContactU>();

    public virtual ICollection<TblContributor> TblContributorIntCreatedByNavigations { get; set; } = new List<TblContributor>();

    public virtual ICollection<TblContributor> TblContributorIntModifiedByNavigations { get; set; } = new List<TblContributor>();

    public virtual ICollection<TblContributor> TblContributorIntUsers { get; set; } = new List<TblContributor>();

    public virtual ICollection<TblExamResult> TblExamResultIntCreatedByNavigations { get; set; } = new List<TblExamResult>();

    public virtual ICollection<TblExamResult> TblExamResultIntModifiedByNavigations { get; set; } = new List<TblExamResult>();

    public virtual ICollection<TblLanguage> TblLanguageIntCreatedByNavigations { get; set; } = new List<TblLanguage>();

    public virtual ICollection<TblLanguage> TblLanguageIntModifiedByNavigations { get; set; } = new List<TblLanguage>();

    public virtual ICollection<TblOfferedProgram> TblOfferedProgramIntCreatedByNavigations { get; set; } = new List<TblOfferedProgram>();

    public virtual ICollection<TblOfferedProgram> TblOfferedProgramIntModifiedByNavigations { get; set; } = new List<TblOfferedProgram>();

    public virtual ICollection<TblQuestionsBank> TblQuestionsBankIntCreatedByNavigations { get; set; } = new List<TblQuestionsBank>();

    public virtual ICollection<TblQuestionsBank> TblQuestionsBankIntModifiedByNavigations { get; set; } = new List<TblQuestionsBank>();

    public virtual ICollection<TblStudentDetail> TblStudentDetailIntCreatedByNavigations { get; set; } = new List<TblStudentDetail>();

    public virtual ICollection<TblStudentDetail> TblStudentDetailIntModifiedByNavigations { get; set; } = new List<TblStudentDetail>();

    public virtual ICollection<TblStudentDetail> TblStudentDetailIntUsers { get; set; } = new List<TblStudentDetail>();
}
