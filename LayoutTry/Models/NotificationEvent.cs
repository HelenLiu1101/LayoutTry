using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

public partial class NotificationEvent
{
    public int Id { get; set; }

    public string FinalContent { get; set; } = null!;

    public DateTime SendTime { get; set; }

    public bool IsRead { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int MemberId { get; set; }

    public int NotificationId { get; set; }

    public virtual Notification Id1 { get; set; } = null!;

    public virtual Member IdNavigation { get; set; } = null!;
}
