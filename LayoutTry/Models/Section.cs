using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 票區資料表
/// </summary>
public partial class Section
{
    /// <summary>
    /// 票區編號
    /// </summary>
    public int SectionId { get; set; }

    /// <summary>
    /// 票區名稱
    /// </summary>
    public int VenueId { get; set; }

    /// <summary>
    /// 場地編號
    /// </summary>
    public string SectionName { get; set; } = null!;

    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();

    public virtual ICollection<TicketRequest> TicketRequests { get; set; } = new List<TicketRequest>();

    public virtual Venue Venue { get; set; } = null!;
}
