using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// Log資料表
/// </summary>
public partial class SysNlogLog
{
    /// <summary>
    /// NLogID
    /// </summary>
    public int NlogId { get; set; }

    public string? Application { get; set; }

    /// <summary>
    /// 日誌信息時間
    /// </summary>
    public DateTime EventTime { get; set; }

    /// <summary>
    /// 日誌器名稱
    /// </summary>
    public string? Logger { get; set; }

    /// <summary>
    /// 記錄該日誌信息的級別（例如，Info、Warn、Error等）
    /// </summary>
    public string? EventLevel { get; set; }

    /// <summary>
    /// 日誌消息內容
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// 異常信息
    /// </summary>
    public string? Exception { get; set; }

    public string? UserName { get; set; }

    /// <summary>
    /// 呼叫站台
    /// </summary>
    public string CallSite { get; set; } = null!;

    /// <summary>
    /// 是否HTTPS T:是 F:否
    /// </summary>
    public string? IsHttps { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public string StatusFlag { get; set; } = null!;

    /// <summary>
    /// 建立者
    /// </summary>
    public string CreatedBy { get; set; } = null!;

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// 修改者
    /// </summary>
    public string UpdatedBy { get; set; } = null!;

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime UpdatedDate { get; set; }
}
