using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 點數歷程資料表
/// </summary>
public partial class PointHistory
{
    /// <summary>
    /// 點數歷程ID
    /// </summary>
    public int PointHistoryId { get; set; }

    /// <summary>
    /// 會員編號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 點數類型 包括「1:得到/增加」、「2:使用/減少」、「3:提現」、「贈送」等 
    /// </summary>
    public string PointType { get; set; } = null!;

    /// <summary>
    /// 點數變動數量
    /// </summary>
    public double PointAmount { get; set; }

    /// <summary>
    /// 點數餘額
    /// </summary>
    public double Balance { get; set; }

    /// <summary>
    /// 交易時間戳
    /// </summary>
    public byte[] TradingTime { get; set; } = null!;

    /// <summary>
    /// 點數來源者
    /// </summary>
    public string DividerBy { get; set; } = null!;

    /// <summary>
    /// 交易描述
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// IP地址
    /// </summary>
    public string? IpAddress { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public string StatusFlag { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual Member Member { get; set; } = null!;
}
