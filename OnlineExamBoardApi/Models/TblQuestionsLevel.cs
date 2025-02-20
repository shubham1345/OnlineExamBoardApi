using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblQuestionsLevel
{
    public int IntId { get; set; }

    public string? StrQuestionLevel { get; set; }

    public virtual ICollection<TblQuestionsBank> TblQuestionsBanks { get; set; } = new List<TblQuestionsBank>();
}
