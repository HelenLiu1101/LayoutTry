using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 議價歷史資料表
/// </summary>
public partial class NegotiationHistory
{
    public int TransactionId { get; set; }

    /// <summary>
    /// TicketRequest.TicketRequestID
    /// </summary>
    public int TicketRequestId { get; set; }

    /// <summary>
    /// [Member].[MemberID]
    /// </summary>
    public int BuyerMemberId { get; set; }

    /// <summary>
    /// [Member].[MemberID]
    /// </summary>
    public int SellerMemberId { get; set; }

    public DateTime Timestamp { get; set; }

    /// <summary>
    /// [Orders].[OrdersID]
    /// </summary>
    public int? OrderId { get; set; }

    /// <summary>
    /// 交易成立，抽成該筆交易的5%
    /// </summary>
    public int? Fee { get; set; }

    /// <summary>
    /// 預設值為 0。進行中：0，已完成：1，已取消：2
    /// </summary>
    public string TicketSellingStatus { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public string StatusFlag { get; set; } = null!;

    public virtual Member BuyerMember { get; set; } = null!;

    public virtual ICollection<NegotiationDetail> NegotiationDetails { get; set; } = new List<NegotiationDetail>();

    public virtual Order? Order { get; set; }

    public virtual Member SellerMember { get; set; } = null!;

    public virtual TicketRequest TicketRequest { get; set; } = null!;
}
