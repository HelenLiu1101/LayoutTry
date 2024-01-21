using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 驗證
/// </summary>
public partial class Validation
{
    /// <summary>
    /// 驗證編號
    /// </summary>
    public int ValidationId { get; set; }

    /// <summary>
    /// 會員編號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 票券編號
    /// </summary>
    public int TicketId { get; set; }

    /// <summary>
    /// 驗證碼
    /// </summary>
    public string ValidationCode { get; set; } = null!;

    public DateTime CodeTime { get; set; }

    public DateTime UseTime { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual Ticket ValidationNavigation { get; set; } = null!;
}
