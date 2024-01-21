using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 售票資料表
/// </summary>
public partial class Ticket
{
    public int TicketId { get; set; }

    /// <summary>
    /// 票券名稱
    /// </summary>
    public string? TicketName { get; set; }

    public bool IsSold { get; set; }

    public decimal? Price { get; set; }

    /// <summary>
    /// 座位編號
    /// </summary>
    public int? SeatId { get; set; }

    /// <summary>
    /// 場次編號
    /// </summary>
    public int? ShowId { get; set; }

    /// <summary>
    /// 訂單編號
    /// </summary>
    public int? OrderId { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<MyTicket> MyTickets { get; set; } = new List<MyTicket>();

    public virtual Order? Order { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Seat? Seat { get; set; }

    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();

    public virtual Venue? Show { get; set; }

    public virtual ICollection<TicketRequest> TicketRequests { get; set; } = new List<TicketRequest>();

    public virtual ICollection<TicketsTransfer> TicketsTransfers { get; set; } = new List<TicketsTransfer>();

    public virtual Validation? Validation { get; set; }
}
