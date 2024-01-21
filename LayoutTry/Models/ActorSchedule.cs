using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 演員時程表
/// </summary>
public partial class ActorSchedule
{
    /// <summary>
    /// 時程表編號
    /// </summary>
    public int SchId { get; set; }

    /// <summary>
    /// 活動編號
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// 場次編號
    /// </summary>
    public int? ShowId { get; set; }

    /// <summary>
    /// 演員編號
    /// </summary>
    public int ActorId { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Actor Actor { get; set; } = null!;

    public virtual Event Event { get; set; } = null!;

    public virtual Show? Show { get; set; }
}
