using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 會員權限
/// </summary>
public partial class MemberRole
{
    /// <summary>
    /// 會員等級編號
    /// </summary>
    public int RoleId { get; set; }

    /// <summary>
    /// 會員等級名稱
    /// </summary>
    public string RoleName { get; set; } = null!;

    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();
}
