using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 第3方金流種類表
/// </summary>
public partial class PaymentFlowType
{
    /// <summary>
    /// 支付方式ID，如Line PAY、藍新、綠界
    /// </summary>
    public int PaymentTypeId { get; set; }

    /// <summary>
    /// 支付方式Name，如Line PAY、藍新、綠界
    /// </summary>
    public string PaymentTypeName { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<PaymentFlow> PaymentFlows { get; set; } = new List<PaymentFlow>();
}
