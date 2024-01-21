using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 位子評價資料表
/// </summary>
public partial class Evaluate
{
    public int EvaluateId { get; set; }

    /// <summary>
    /// [Member].[MemberID] 評價者ID,連接至會員資料表
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// [Events].[EventID]  記錄使用者評價看的作品名稱
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// 紀錄評論時間
    /// </summary>
    public DateTime EvaluateTime { get; set; }

    /// <summary>
    /// 記錄使用者對於該項的評分,1-5分
    /// </summary>
    public int ViewScore { get; set; }

    /// <summary>
    /// 記錄使用者對於該項的評分,1-5分
    /// </summary>
    public int LightsScore { get; set; }

    /// <summary>
    /// 位置分數
    /// </summary>
    public int PositionScore { get; set; }

    /// <summary>
    /// 記錄使用者對於該項的評分,1-5分
    /// </summary>
    public int AudioScore { get; set; }

    /// <summary>
    /// 使用者對於該座位文字評價
    /// </summary>
    public string? Evaluate1 { get; set; }

    public string? StatusFlag { get; set; }

    public string? UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public virtual ICollection<EvaluatePhoto> EvaluatePhotos { get; set; } = new List<EvaluatePhoto>();

    public virtual Event Event { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;

    public virtual ICollection<Reply> Replies { get; set; } = new List<Reply>();
}
