using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblLanguage
{
    public int IntId { get; set; }

    public string? StrLanguage { get; set; }

    public bool? IsActive { get; set; }

    public int? IntCreatedBy { get; set; }

    public DateTime? DteCreatedDate { get; set; }

    public int? IntModifiedBy { get; set; }

    public DateTime? DteModifiedDate { get; set; }

    public virtual TblUser? IntCreatedByNavigation { get; set; }

    public virtual TblUser? IntModifiedByNavigation { get; set; }

    public virtual ICollection<TblProgramLanguagesMap> TblProgramLanguagesMaps { get; set; } = new List<TblProgramLanguagesMap>();

    public virtual ICollection<TblQuestionsBank> TblQuestionsBanks { get; set; } = new List<TblQuestionsBank>();
}
