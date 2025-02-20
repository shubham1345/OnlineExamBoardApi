using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblQuestionsBank
{
    public int IntId { get; set; }

    public int? IntLanguageId { get; set; }

    public string? StrQuestion { get; set; }

    public int? IntTypeId { get; set; }

    public int? IntLevelId { get; set; }

    public string? StrChoice1 { get; set; }

    public string? StrChoice2 { get; set; }

    public string? StrChoice3 { get; set; }

    public string? StrChoice4 { get; set; }

    public string? StrCorrectAnswer { get; set; }

    public bool? IsActive { get; set; }

    public int? IntCreatedBy { get; set; }

    public DateTime? DteCreatedDate { get; set; }

    public int? IntModifiedBy { get; set; }

    public DateTime? DteModifiedDate { get; set; }

    public virtual TblUser? IntCreatedByNavigation { get; set; }

    public virtual TblLanguage? IntLanguage { get; set; }

    public virtual TblQuestionsLevel? IntLevel { get; set; }

    public virtual TblUser? IntModifiedByNavigation { get; set; }

    public virtual TblQuestionsType? IntType { get; set; }

    public virtual ICollection<TblStudentTestQuestion> TblStudentTestQuestions { get; set; } = new List<TblStudentTestQuestion>();
}
