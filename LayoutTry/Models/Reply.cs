using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 回覆資料表
/// </summary>
public partial class Reply
{
    public int ReplyId { get; set; }

    /// <summary>
    /// [evaluate].[EvaluateID] 連接至評論資料庫查詢回覆的評論是哪則
    /// </summary>
    public int EvaluateId { get; set; }

    /// <summary>
    /// [Member].[MemberID]  紀錄回覆使用者編號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 紀錄回覆時間
    /// </summary>
    public DateTime ReplyTime { get; set; }

    /// <summary>
    /// 對於評價的回覆
    /// </summary>
    public string Reply1 { get; set; } = null!;

    /// <summary>
    /// 讓回覆者表示是否同意評論者可用於評論可信度
    /// </summary>
    public int CommentScore { get; set; }

    public string? StatusFlag { get; set; }

    public string? UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public virtual Evaluate Evaluate { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
