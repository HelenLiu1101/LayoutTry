using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 折扣優惠表
/// </summary>
public partial class Coupon
{
    /// <summary>
    /// 優惠券編號
    /// </summary>
    public int CouponId { get; set; }

    /// <summary>
    /// 優惠碼
    /// </summary>
    public string CouponCode { get; set; } = null!;

    /// <summary>
    /// 優惠券類型
    /// </summary>
    public string CouponType { get; set; } = null!;

    /// <summary>
    /// 折扣率 記錄折扣的金額或百分比
    /// </summary>
    public int DiscountPercentage { get; set; }

    /// <summary>
    /// 起始時間
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// 有效時間
    /// </summary>
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// 資料狀態
    /// </summary>
    public string StatusFlag { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
}
