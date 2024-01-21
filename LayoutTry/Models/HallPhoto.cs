using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 表演廳照片資料表
/// </summary>
public partial class HallPhoto
{
    public int PhotoId { get; set; }

    /// <summary>
    /// [Venues].[VenueID]  紀錄表演地點編號
    /// </summary>
    public int VenueId { get; set; }

    /// <summary>
    /// 用以記錄表演廳照片在伺服器端路徑
    /// </summary>
    public string Photopath { get; set; } = null!;

    /// <summary>
    /// 以文字記錄該照片敘述
    /// </summary>
    public string? Photodescription { get; set; }

    public string? StatusFlag { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateOnly CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public virtual Venue Venue { get; set; } = null!;
}
