using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 活動圖片表
/// </summary>
public partial class EventImg
{
    /// <summary>
    /// 圖片編碼
    /// </summary>
    public int ImgId { get; set; }

    /// <summary>
    /// 圖片路徑
    /// </summary>
    public string ImgPath { get; set; } = null!;

    /// <summary>
    /// 活動編號
    /// </summary>
    public int EventId { get; set; }

    public string? StatusFlag { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual Event Event { get; set; } = null!;
}
