using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 遊戲紀錄表
/// </summary>
public partial class GameRecord
{
    /// <summary>
    /// 紀錄編號
    /// </summary>
    public int RecordId { get; set; }

    /// <summary>
    /// 會員編號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 遊戲類型
    /// </summary>
    public string GameType { get; set; } = null!;

    /// <summary>
    /// 得分
    /// </summary>
    public int Score { get; set; }

    /// <summary>
    /// 遊戲日期
    /// </summary>
    public DateTime GameDate { get; set; }

    /// <summary>
    /// 取得點數
    /// </summary>
    public int GetPoints { get; set; }

    public virtual Member Member { get; set; } = null!;
}
