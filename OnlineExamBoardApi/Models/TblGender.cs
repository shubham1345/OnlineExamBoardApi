using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblGender
{
    public int IntId { get; set; }

    public string? StrGender { get; set; }

    public virtual ICollection<TblUser> TblUsers { get; set; } = new List<TblUser>();
}
