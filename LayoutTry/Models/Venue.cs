using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 場地資料表
/// </summary>
public partial class Venue
{
    /// <summary>
    /// 地點編號
    /// </summary>
    public int VenueId { get; set; }

    /// <summary>
    /// 地點名稱
    /// </summary>
    public string VenueName { get; set; } = null!;

    /// <summary>
    /// 縣市
    /// </summary>
    public string? Province { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    public string? VenueAddress { get; set; }

    /// <summary>
    /// 容納人數
    /// </summary>
    public int? Capacity { get; set; }

    public string? StatusFlag { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<HallPhoto> HallPhotos { get; set; } = new List<HallPhoto>();

    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();

    public virtual ICollection<Show> Shows { get; set; } = new List<Show>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
