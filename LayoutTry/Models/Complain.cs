using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 申訴資料表
/// </summary>
public partial class Complain
{
    public int ComplainId { get; set; }

    public string TitleOfComplaint { get; set; } = null!;

    public string ContentOfComplaint { get; set; } = null!;

    public bool ComplaintStatus { get; set; }

    public string? StatusFlag { get; set; }

    /// <summary>
    /// 外鍵Member-MemberID
    /// </summary>
    public int CreatedBy { get; set; }

    public DateOnly CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public virtual Member CreatedByNavigation { get; set; } = null!;
}
