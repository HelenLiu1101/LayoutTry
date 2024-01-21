using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 公告資料表
/// </summary>
public partial class SysAnnounceInfo
{
    /// <summary>
    /// 公告ID
    /// </summary>
    public int AnnounceId { get; set; }

    /// <summary>
    /// 使用者ID
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 公告種類
    /// </summary>
    public string? AnnounceKind { get; set; }

    /// <summary>
    /// 標題
    /// </summary>
    public string? AnnounceTitle { get; set; }

    /// <summary>
    /// 內文種類(保留)
    /// </summary>
    public string AnnounceContentType { get; set; } = null!;

    /// <summary>
    /// 內容
    /// </summary>
    public string? AnnounceText { get; set; }

    /// <summary>
    /// 起始日期
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// 結束日期
    /// </summary>
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public string StatusFlag { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }
}
