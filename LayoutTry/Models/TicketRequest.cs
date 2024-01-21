using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 徵票/出票需求資料表
/// </summary>
public partial class TicketRequest
{
    public int TicketRequestId { get; set; }

    /// <summary>
    /// 預設值為 1。出票：0，徵票：1
    /// </summary>
    public string TicketCategoryId { get; set; } = null!;

    /// <summary>
    /// [Member].[MemberID]
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// [Events].[EventID]  從活動編號讀取該活動票區，讓使用者選擇可接受的票價範圍
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// [Shows].[ShowID]
    /// </summary>
    public int ShowId { get; set; }

    /// <summary>
    /// [Tickets].[TicketID] 
    /// </summary>
    public int? TicketId { get; set; }

    /// <summary>
    /// [Sections].[SectionID]
    /// </summary>
    public int? SectionId { get; set; }

    /// <summary>
    /// 預設值為 1
    /// </summary>
    public string QuantityRequest { get; set; } = null!;

    /// <summary>
    /// 儲存被選取的座位ID
    /// </summary>
    public int? SeatRangeS { get; set; }

    /// <summary>
    /// 儲存被選取的座位ID
    /// </summary>
    public int? SeatRangeE { get; set; }

    /// <summary>
    /// 單張票券的價格，預設值為票區原價
    /// </summary>
    public int RequestPrice { get; set; }

    /// <summary>
    /// 預設值為 0。進行中：0，已滿足：1，已取消：2
    /// </summary>
    public string RequestStatus { get; set; } = null!;

    public DateTime ReleaseDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;

    public virtual ICollection<NegotiationHistory> NegotiationHistories { get; set; } = new List<NegotiationHistory>();

    public virtual Section? Section { get; set; }

    public virtual Show Show { get; set; } = null!;

    public virtual Ticket? Ticket { get; set; }
}
