using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 通知資料表
/// </summary>
public partial class SysNotify
{
    /// <summary>
    /// 通知ID
    /// </summary>
    public int NotifyId { get; set; }

    /// <summary>
    /// 會員代碼
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// 發送類型;2:手機、1:EMAIL
    /// </summary>
    public string SmsKind { get; set; } = null!;

    /// <summary>
    /// 手機門號
    /// </summary>
    public string? Mobile { get; set; }

    /// <summary>
    /// 電子郵件
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// 傳送日期
    /// </summary>
    public DateTime? SentDate { get; set; }

    /// <summary>
    ///  狀態;0:未寄送、1:已寄送結案、8:異常、9:終止
    /// </summary>
    public string SentStatus { get; set; } = null!;

    /// <summary>
    /// 標題
    /// </summary>
    public string SentTitle { get; set; } = null!;

    /// <summary>
    /// 內文
    /// </summary>
    public string SentBody { get; set; } = null!;

    /// <summary>
    /// 字數(保留)
    /// </summary>
    public int? WordCnt { get; set; }

    /// <summary>
    /// xml存放路徑;for EMAIL 用 (保留)
    /// </summary>
    public string? XmlUrl { get; set; }

    /// <summary>
    /// pdf存放路徑;for EMAIL 用 (保留)
    /// </summary>
    public string? PdfUrl { get; set; }

    /// <summary>
    /// 檔案URL
    /// </summary>
    public string? FileUrl { get; set; }

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

    public virtual ICollection<SysNotifyTemplate> SysNotifyTemplates { get; set; } = new List<SysNotifyTemplate>();
}
