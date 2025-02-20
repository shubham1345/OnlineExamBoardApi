using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblExamResult
{
    public int IntId { get; set; }

    public int? IntStudentId { get; set; }

    public DateTime? DteDateOfExam { get; set; }

    public int? IntOfferedProgramId { get; set; }

    public int? IntCollegeId { get; set; }

    public int? IntTotalNoOfQuestion { get; set; }

    public int? IntTotalNoOfQuestionAttempt { get; set; }

    public int? IntTotalNoOfQuestionSkip { get; set; }

    public int? IntTotalNoOfCorrectAnswer { get; set; }

    public int? IntCreatedBy { get; set; }

    public DateTime? DteCreatedDate { get; set; }

    public int? IntModifiedBy { get; set; }

    public DateTime? DteModifiedDate { get; set; }

    public virtual TblCollegeDetail? IntCollege { get; set; }

    public virtual TblUser? IntCreatedByNavigation { get; set; }

    public virtual TblUser? IntModifiedByNavigation { get; set; }

    public virtual TblOfferedProgram? IntOfferedProgram { get; set; }

    public virtual TblStudentDetail? IntStudent { get; set; }

    public virtual ICollection<TblStudentTestQuestion> TblStudentTestQuestions { get; set; } = new List<TblStudentTestQuestion>();
}
