using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 通知範本資料表
/// </summary>
public partial class SysNotifyTemplate
{
    /// <summary>
    /// 範本ID
    /// </summary>
    public int TemplateId { get; set; }

    /// <summary>
    /// 通知ID
    /// </summary>
    public int? NotifyId { get; set; }

    /// <summary>
    /// 範本名稱
    /// </summary>
    public string? TemplateName { get; set; }

    public string TemplateText { get; set; } = null!;

    /// <summary>
    /// 通道(保留)
    /// </summary>
    public string Channel { get; set; } = null!;

    public string StatusFlag { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual SysNotify? Notify { get; set; }
}
