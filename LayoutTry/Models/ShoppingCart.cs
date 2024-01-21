using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 購物車表
/// </summary>
public partial class ShoppingCart
{
    /// <summary>
    /// 購物車編號
    /// </summary>
    public int CartId { get; set; }

    /// <summary>
    /// 會員ID
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 優惠券編號
    /// </summary>
    public int CouponId { get; set; }

    /// <summary>
    /// 票卷ID
    /// </summary>
    public int TicketId { get; set; }

    /// <summary>
    /// 購物車種類 1:1手 2:2手
    /// </summary>
    public int CartType { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual Coupon Coupon { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;

    public virtual Ticket Ticket { get; set; } = null!;
}
