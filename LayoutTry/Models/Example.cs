using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 通知範本
/// </summary>
public partial class Example
{
    public int ExampleId { get; set; }

    public string Type { get; set; } = null!;

    public string Example1 { get; set; } = null!;

    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}
