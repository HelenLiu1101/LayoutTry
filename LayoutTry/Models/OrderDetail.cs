using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 訂購明細表
/// </summary>
public partial class OrderDetail
{
    /// <summary>
    /// 訂單明細編號
    /// </summary>
    public int OrderDetailId { get; set; }

    /// <summary>
    /// 訂單編號
    /// </summary>
    public int OrderId { get; set; }

    /// <summary>
    /// 票券編號
    /// </summary>
    public int TicketId { get; set; }

    /// <summary>
    /// 優惠碼
    /// </summary>
    public int? CouponId { get; set; }

    /// <summary>
    /// 單價
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// 數量
    /// </summary>
    public short Quantity { get; set; }

    /// <summary>
    /// 小計
    /// </summary>
    public decimal SubTotal { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual Coupon? Coupon { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Ticket Ticket { get; set; } = null!;
}
