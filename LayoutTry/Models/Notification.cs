using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 通知
/// </summary>
public partial class Notification
{
    public int NotificationId { get; set; }

    public int ExampleId { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Example Example { get; set; } = null!;

    public virtual ICollection<MyFollowing> MyFollowings { get; set; } = new List<MyFollowing>();

    public virtual NotificationEvent? NotificationEvent { get; set; }
}
