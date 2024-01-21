using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 系統參數表
/// </summary>
public partial class SysCodeInfo
{
    public Guid CodeUuid { get; set; }

    public string CodeId { get; set; } = null!;

    public string CodeName { get; set; } = null!;

    public string Cate { get; set; } = null!;

    public Guid SuperUuid { get; set; }

    public int Seq { get; set; }

    public string ModifyStatus { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string VarChar01 { get; set; } = null!;

    public string VarChar02 { get; set; } = null!;

    public string VarChar03 { get; set; } = null!;

    public string VarChar04 { get; set; } = null!;

    public string VarChar05 { get; set; } = null!;

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
    /// UpdatedBy
    /// </summary>
    public string UpdatedBy { get; set; } = null!;

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime UpdatedDate { get; set; }
}
