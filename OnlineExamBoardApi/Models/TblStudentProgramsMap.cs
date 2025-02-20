using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblStudentProgramsMap
{
    public int IntId { get; set; }

    public int? IntStudentId { get; set; }

    public int? IntOfferedProgramId { get; set; }

    public virtual TblOfferedProgram? IntOfferedProgram { get; set; }

    public virtual TblStudentDetail? IntStudent { get; set; }
}
