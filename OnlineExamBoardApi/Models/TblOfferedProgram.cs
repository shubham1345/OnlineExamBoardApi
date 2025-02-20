using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblOfferedProgram
{
    public int IntId { get; set; }

    public string? StrOfferedProgramName { get; set; }

    public string? StrOfferedBy { get; set; }

    public string? StrDuration { get; set; }

    public bool? IsActive { get; set; }

    public int? IntCreatedBy { get; set; }

    public DateTime? DteCreatedDate { get; set; }

    public int? IntModifiedBy { get; set; }

    public DateTime? DteModifiedDate { get; set; }

    public virtual TblUser? IntCreatedByNavigation { get; set; }

    public virtual TblUser? IntModifiedByNavigation { get; set; }

    public virtual ICollection<TblExamResult> TblExamResults { get; set; } = new List<TblExamResult>();

    public virtual ICollection<TblProgramLanguagesMap> TblProgramLanguagesMaps { get; set; } = new List<TblProgramLanguagesMap>();

    public virtual ICollection<TblStudentProgramsMap> TblStudentProgramsMaps { get; set; } = new List<TblStudentProgramsMap>();
}
