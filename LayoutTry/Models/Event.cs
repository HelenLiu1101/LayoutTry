using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 演出資料表
/// </summary>
public partial class Event
{
    /// <summary>
    /// 活動編號
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// 類別編號
    /// </summary>
    public int CateId { get; set; }

    /// <summary>
    /// 活動名稱
    /// </summary>
    public string EventName { get; set; } = null!;

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 活動圖片
    /// </summary>
    public string? EventImg { get; set; }

    /// <summary>
    /// 活動幾演
    /// </summary>
    public int? EventNumber { get; set; }

    public string? StatusFlag { get; set; }

    public int CreatedBy { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<ActorSchedule> ActorSchedules { get; set; } = new List<ActorSchedule>();

    public virtual Category Cate { get; set; } = null!;

    public virtual ICollection<Evaluate> Evaluates { get; set; } = new List<Evaluate>();

    public virtual ICollection<EventImg> EventImgs { get; set; } = new List<EventImg>();

    public virtual ICollection<MyFavorite> MyFavorites { get; set; } = new List<MyFavorite>();

    public virtual ICollection<MyFollowing> MyFollowings { get; set; } = new List<MyFollowing>();

    public virtual ICollection<Show> Shows { get; set; } = new List<Show>();

    public virtual ICollection<TicketRequest> TicketRequests { get; set; } = new List<TicketRequest>();
}
