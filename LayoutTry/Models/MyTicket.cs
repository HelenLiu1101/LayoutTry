using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 我的票卷資料表
/// </summary>
public partial class MyTicket
{
    /// <summary>
    /// 持有票券編號
    /// </summary>
    public int MyTicketsId { get; set; }

    /// <summary>
    /// 會員編號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 票券狀態
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// 票卷ID
    /// </summary>
    public int TicketId { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual Ticket Ticket { get; set; } = null!;
}
