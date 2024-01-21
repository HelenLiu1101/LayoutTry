using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 演出場次資料表
/// </summary>
public partial class Show
{
    /// <summary>
    /// 場次編號
    /// </summary>
    public int ShowId { get; set; }

    /// <summary>
    /// 活動編號
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// 地點編號
    /// </summary>
    public int VenueId { get; set; }

    /// <summary>
    /// 座位編號
    /// </summary>
    public int SeatId { get; set; }

    /// <summary>
    /// 日期
    /// </summary>
    public DateOnly ShowDate { get; set; }

    /// <summary>
    /// 時間
    /// </summary>
    public DateTime ShowTime { get; set; }

    /// <summary>
    /// 演出執行時間
    /// </summary>
    public int? Runtime { get; set; }

    public string? StatusFlag { get; set; }

    public string CreatedBy { get; set; } = null!;

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<ActorSchedule> ActorSchedules { get; set; } = new List<ActorSchedule>();

    public virtual Event Event { get; set; } = null!;

    public virtual ICollection<MyFollowing> MyFollowings { get; set; } = new List<MyFollowing>();

    public virtual Seat Seat { get; set; } = null!;

    public virtual ICollection<TicketRequest> TicketRequests { get; set; } = new List<TicketRequest>();

    public virtual Venue Venue { get; set; } = null!;
}
