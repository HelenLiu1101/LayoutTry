using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 類別資料表
/// </summary>
public partial class Category
{
    /// <summary>
    /// 類別編號
    /// </summary>
    public int CateId { get; set; }

    /// <summary>
    /// 類別名稱 音樂劇、舞台劇、喜劇演出
    /// </summary>
    public string? CateName { get; set; }

    public virtual ICollection<Actor> Actors { get; set; } = new List<Actor>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
