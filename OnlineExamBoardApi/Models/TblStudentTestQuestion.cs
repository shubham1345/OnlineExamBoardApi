using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblStudentTestQuestion
{
    public int IntId { get; set; }

    public int? IntStudentExamId { get; set; }

    public int? IntStudentId { get; set; }

    public int? IntQuestionBankId { get; set; }

    public virtual TblQuestionsBank? IntQuestionBank { get; set; }

    public virtual TblStudentDetail? IntStudent { get; set; }

    public virtual TblExamResult? IntStudentExam { get; set; }
}
