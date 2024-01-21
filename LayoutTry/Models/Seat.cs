using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 座位資料表
/// </summary>
public partial class Seat
{
    /// <summary>
    /// 座位編號
    /// </summary>
    public int SeatId { get; set; }

    /// <summary>
    /// 地點編號
    /// </summary>
    public int VenueId { get; set; }

    /// <summary>
    /// 票區編碼
    /// </summary>
    public int SectionId { get; set; }

    /// <summary>
    /// 座位排
    /// </summary>
    public string? SeatRow { get; set; }

    /// <summary>
    /// 座位號碼
    /// </summary>
    public int? SeatNum { get; set; }

    /// <summary>
    /// 座位等級 一般，輪椅
    /// </summary>
    public string? SeatClass { get; set; }

    /// <summary>
    /// 是否可用
    /// </summary>
    public bool? IsAvailable { get; set; }

    /// <summary>
    /// 票價定價
    /// </summary>
    public decimal? Price { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Section Section { get; set; } = null!;

    public virtual ICollection<Show> Shows { get; set; } = new List<Show>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual Venue Venue { get; set; } = null!;
}
