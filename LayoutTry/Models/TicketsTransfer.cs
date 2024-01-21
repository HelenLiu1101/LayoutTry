using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 分票紀錄
/// </summary>
public partial class TicketsTransfer
{
    public int TicketsTransferId { get; set; }

    /// <summary>
    /// 會員編號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 票券編號
    /// </summary>
    public int TicketId { get; set; }

    /// <summary>
    /// 收票者編號
    /// </summary>
    public int? TransferredToId { get; set; }

    /// <summary>
    /// 分票日期
    /// </summary>
    public DateTime TransferDate { get; set; }

    /// <summary>
    /// 收票日期
    /// </summary>
    public DateTime? ReceiveDate { get; set; }

    /// <summary>
    /// 分票連結
    /// </summary>
    public string Link { get; set; } = null!;

    /// <summary>
    /// 分票狀態
    /// </summary>
    public bool Status { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual Ticket Ticket { get; set; } = null!;

    public virtual Member? TransferredTo { get; set; }
}
