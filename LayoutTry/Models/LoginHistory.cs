using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 登入歷史資料表
/// </summary>
public partial class LoginHistory
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
    /// 登入時間
    /// </summary>
    public DateTime LoginTime { get; set; }

    /// <summary>
    /// IP地址
    /// </summary>
    public string Ipaddress { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
