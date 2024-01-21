using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 我的關注
/// </summary>
public partial class MyFollowing
{
    /// <summary>
    /// 我的關注編號
    /// </summary>
    public int MyFollowingId { get; set; }

    /// <summary>
    /// 會員編號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 活動編號
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// 場次編號
    /// </summary>
    public int ShowId { get; set; }

    /// <summary>
    /// 場地編號
    /// </summary>
    public int NotificationId { get; set; }

    /// <summary>
    /// 票券編號
    /// </summary>
    public string? StatusFlag { get; set; }

    /// <summary>
    /// 通知狀態
    /// </summary>
    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;

    public virtual Notification Notification { get; set; } = null!;

    public virtual Show Show { get; set; } = null!;
}
