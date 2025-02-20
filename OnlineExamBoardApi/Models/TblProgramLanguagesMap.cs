using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblProgramLanguagesMap
{
    public int IntId { get; set; }

    public int? IntOfferedProgramId { get; set; }

    public int? IntLanguageId { get; set; }

    public virtual TblLanguage? IntLanguage { get; set; }

    public virtual TblOfferedProgram? IntOfferedProgram { get; set; }
}
