using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblStudentDetail
{
    public int IntId { get; set; }

    public int? IntUserId { get; set; }

    public int? IntCollegeId { get; set; }

    public string? StrBranchName { get; set; }

    public string? StrProfilePhoto { get; set; }

    public int? IntCreatedBy { get; set; }

    public DateTime? DteCreatedDate { get; set; }

    public int? IntModifiedBy { get; set; }

    public DateTime? DteModifiedDate { get; set; }

    public virtual TblCollegeDetail? IntCollege { get; set; }

    public virtual TblUser? IntCreatedByNavigation { get; set; }

    public virtual TblUser? IntModifiedByNavigation { get; set; }

    public virtual TblUser? IntUser { get; set; }

    public virtual ICollection<TblExamResult> TblExamResults { get; set; } = new List<TblExamResult>();

    public virtual ICollection<TblStudentProgramsMap> TblStudentProgramsMaps { get; set; } = new List<TblStudentProgramsMap>();

    public virtual ICollection<TblStudentTestQuestion> TblStudentTestQuestions { get; set; } = new List<TblStudentTestQuestion>();
}
