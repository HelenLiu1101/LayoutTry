using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 訂購表
/// </summary>
public partial class Order
{
    /// <summary>
    /// 訂單編號
    /// </summary>
    public int OrdersId { get; set; }

    /// <summary>
    /// 會員編號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 訂購時間
    /// </summary>
    public DateTime OrderDate { get; set; }

    /// <summary>
    /// 付款狀態 記錄交易的當前狀態，例如待付款、已支付、支付失敗
    /// </summary>
    public string PaymentStatus { get; set; } = null!;

    /// <summary>
    /// 支付方式 標識使用的支付方式，如Line PAY、藍新、綠界等
    /// </summary>
    public string PaymentFlow { get; set; } = null!;

    /// <summary>
    /// 交易類型 1:1手 2:2手
    /// </summary>
    public string OrderType { get; set; } = null!;

    /// <summary>
    /// 縣市
    /// </summary>
    public string Province { get; set; } = null!;

    /// <summary>
    /// 地址
    /// </summary>
    public string ShippingAddress { get; set; } = null!;

    /// <summary>
    /// 總計金額
    /// </summary>
    public decimal Total { get; set; }

    /// <summary>
    /// 交易完成時間
    /// </summary>
    public DateTime TransactionTime { get; set; }

    /// <summary>
    /// IP地址
    /// </summary>
    public string IpAddress { get; set; } = null!;

    /// <summary>
    /// 設備信息
    /// </summary>
    public string DeviceInformaton { get; set; } = null!;

    /// <summary>
    /// 備註
    /// </summary>
    public string Remark { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual ICollection<NegotiationHistory> NegotiationHistories { get; set; } = new List<NegotiationHistory>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<PaymentFlow> PaymentFlows { get; set; } = new List<PaymentFlow>();

    public virtual ICollection<Refund> Refunds { get; set; } = new List<Refund>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
