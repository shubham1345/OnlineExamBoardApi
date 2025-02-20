using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblQuestionsType
{
    public int IntId { get; set; }

    public string? StrQuestionType { get; set; }

    public virtual ICollection<TblQuestionsBank> TblQuestionsBanks { get; set; } = new List<TblQuestionsBank>();
}
