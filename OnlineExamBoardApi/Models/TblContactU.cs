using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblContactU
{
    public int IntId { get; set; }

    public string? StrName { get; set; }

    public string? StrEmail { get; set; }

    public string? StrSubject { get; set; }

    public string? StrMessage { get; set; }

    public int? IntCreatedBy { get; set; }

    public DateTime? DteCreatedDate { get; set; }

    public int? IntModifiedBy { get; set; }

    public DateTime? DteModifiedDate { get; set; }

    public virtual TblUser? IntCreatedByNavigation { get; set; }

    public virtual TblUser? IntModifiedByNavigation { get; set; }
}
