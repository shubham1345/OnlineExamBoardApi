using System;
using System.Collections.Generic;

namespace OnlineExamBoardApi.Models;

public partial class TblContributor
{
    public int IntId { get; set; }

    public int? IntUserId { get; set; }

    public string? StrName { get; set; }

    public string? StrProfilePhoto { get; set; }

    public int? IntCreatedBy { get; set; }

    public DateTime? DteCreatedDate { get; set; }

    public int? IntModifiedBy { get; set; }

    public DateTime? DteModifiedDate { get; set; }

    public virtual TblUser? IntCreatedByNavigation { get; set; }

    public virtual TblUser? IntModifiedByNavigation { get; set; }

    public virtual TblUser? IntUser { get; set; }
}
