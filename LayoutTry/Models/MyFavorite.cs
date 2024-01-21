using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 我的收藏
/// </summary>
public partial class MyFavorite
{
    /// <summary>
    /// 我的收藏編號
    /// </summary>
    public int MyFaveritesId { get; set; }

    /// <summary>
    /// 會員編號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 活動編號
    /// </summary>
    public int EventId { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
