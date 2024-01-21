using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 演員資料表
/// </summary>
public partial class Actor
{
    /// <summary>
    /// 演員編號
    /// </summary>
    public int ActorId { get; set; }

    /// <summary>
    /// 類別編號
    /// </summary>
    public int CateId { get; set; }

    /// <summary>
    /// 演員名字
    /// </summary>
    public string? ActorName { get; set; }

    /// <summary>
    /// 演員性別
    /// </summary>
    public string? ActorGender { get; set; }

    /// <summary>
    /// 演員生日
    /// </summary>
    public DateTime? ActorBirth { get; set; }

    /// <summary>
    /// 演員簡介
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 演員照片
    /// </summary>
    public string? ActorImg { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<ActorSchedule> ActorSchedules { get; set; } = new List<ActorSchedule>();

    public virtual Category Cate { get; set; } = null!;
}
