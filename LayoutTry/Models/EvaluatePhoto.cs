using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 位子評價照片資料表
/// </summary>
public partial class EvaluatePhoto
{
    public int PhotoId { get; set; }

    /// <summary>
    /// [evaluate].[EvaluateID] 紀錄表演地點編號
    /// </summary>
    public int EvaluateId { get; set; }

    /// <summary>
    /// 用以記錄表演廳照片在伺服器端路徑
    /// </summary>
    public string Photopath { get; set; } = null!;

    public string? StatusFlag { get; set; }

    public int CreatedBy { get; set; }

    public DateOnly CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public virtual Member CreatedByNavigation { get; set; } = null!;

    public virtual Evaluate Evaluate { get; set; } = null!;
}
