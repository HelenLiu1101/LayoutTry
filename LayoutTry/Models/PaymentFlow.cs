using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 第3方金流表
/// </summary>
public partial class PaymentFlow
{
    /// <summary>
    /// 支付金流ID
    /// </summary>
    public int PaymentId { get; set; }

    /// <summary>
    /// 支付方式ID
    /// </summary>
    public int PaymentTypeId { get; set; }

    /// <summary>
    /// 訂單編號
    /// </summary>
    public int OrdersId { get; set; }

    /// <summary>
    /// 交易金額
    /// </summary>
    public decimal TransactionAmount { get; set; }

    /// <summary>
    /// 記錄交易的當前狀態，例如待付款、已支付、支付失敗等。
    /// </summary>
    public string TransactionStatus { get; set; } = null!;

    /// <summary>
    /// 交易時間
    /// </summary>
    public DateTime TransactionTime { get; set; }

    /// <summary>
    /// 支付機構返回的代碼，用於判斷交易是否成功
    /// </summary>
    public string PayResponseCode { get; set; } = null!;

    /// <summary>
    /// 支付回應訊息
    /// </summary>
    public string PayResponseMessage { get; set; } = null!;

    /// <summary>
    /// 交易驗證碼
    /// </summary>
    public string TransactionVerificationCode { get; set; } = null!;

    /// <summary>
    /// 安全金鑰
    /// </summary>
    public string SecurityKey { get; set; } = null!;

    /// <summary>
    /// 支付通知URL
    /// </summary>
    public string PayNotificationUrl { get; set; } = null!;

    /// <summary>
    /// 交易描述
    /// </summary>
    public string TransactionDescription { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual Order Orders { get; set; } = null!;

    public virtual PaymentFlowType PaymentType { get; set; } = null!;

    public virtual ICollection<Refund> Refunds { get; set; } = new List<Refund>();
}
