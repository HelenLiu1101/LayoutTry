using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 議價細節資料表
/// </summary>
public partial class NegotiationDetail
{
    public int NegotiationDetailId { get; set; }

    /// <summary>
    /// [NegotiationHistory].[TransactionID]
    /// </summary>
    public int TransactionId { get; set; }

    public int ProposedPrice { get; set; }

    public int ResponsePrice { get; set; }

    public DateTime Timestamp { get; set; }

    public virtual NegotiationHistory Transaction { get; set; } = null!;
}
