using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 退款表
/// </summary>
public partial class Refund
{
    /// <summary>
    /// 退票編號
    /// </summary>
    public int RefundId { get; set; }

    /// <summary>
    /// 訂單編號
    /// </summary>
    public int OrderId { get; set; }

    /// <summary>
    /// 退款金流ID
    /// </summary>
    public int PaymentFlowId { get; set; }

    /// <summary>
    /// 退款金額
    /// </summary>
    public decimal RefundAmount { get; set; }

    /// <summary>
    /// 退款日期
    /// </summary>
    public DateTime RefundDate { get; set; }

    /// <summary>
    /// 退款原因
    /// </summary>
    public string RefundReason { get; set; } = null!;

    /// <summary>
    /// 處理狀態 例如「處理中」、「已完成」
    /// </summary>
    public string ProcessingStatus { get; set; } = null!;

    /// <summary>
    /// 處理人員
    /// </summary>
    public string ProcessedBy { get; set; } = null!;

    /// <summary>
    /// 註解
    /// </summary>
    public string Comments { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual PaymentFlow PaymentFlow { get; set; } = null!;
}
