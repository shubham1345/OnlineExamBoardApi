using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblRole
{
    public int IntId { get; set; }

    public string? StrRole { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<TblUser> TblUsers { get; set; } = new List<TblUser>();
}
