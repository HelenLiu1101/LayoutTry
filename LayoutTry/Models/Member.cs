using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

/// <summary>
/// 會員表
/// </summary>
public partial class Member
{
    /// <summary>
    /// 會員編號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 會員等級
    /// </summary>
    public int RoleId { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 使用者名稱
    /// </summary>
    public string UserName { get; set; } = null!;

    /// <summary>
    /// 生日
    /// </summary>
    public DateOnly Birthday { get; set; }

    /// <summary>
    /// 性別
    /// </summary>
    public string Gender { get; set; } = null!;

    /// <summary>
    /// 電話
    /// </summary>
    public string PhoneNumber { get; set; } = null!;

    /// <summary>
    /// 電子郵件
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// 住址
    /// </summary>
    public string Address { get; set; } = null!;

    /// <summary>
    /// 密碼
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// 註冊日期
    /// </summary>
    public DateTime RegistrationDate { get; set; }

    /// <summary>
    /// 狀態旗標
    /// </summary>
    public string StatusFlag { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Complain> Complains { get; set; } = new List<Complain>();

    public virtual ICollection<EvaluatePhoto> EvaluatePhotos { get; set; } = new List<EvaluatePhoto>();

    public virtual ICollection<Evaluate> Evaluates { get; set; } = new List<Evaluate>();

    public virtual ICollection<GameRecord> GameRecords { get; set; } = new List<GameRecord>();

    public virtual ICollection<LoginHistory> LoginHistories { get; set; } = new List<LoginHistory>();

    public virtual ICollection<MyFavorite> MyFavorites { get; set; } = new List<MyFavorite>();

    public virtual ICollection<MyFollowing> MyFollowings { get; set; } = new List<MyFollowing>();

    public virtual ICollection<MyTicket> MyTickets { get; set; } = new List<MyTicket>();

    public virtual ICollection<NegotiationHistory> NegotiationHistoryBuyerMembers { get; set; } = new List<NegotiationHistory>();

    public virtual ICollection<NegotiationHistory> NegotiationHistorySellerMembers { get; set; } = new List<NegotiationHistory>();

    public virtual NotificationEvent? NotificationEvent { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<PointHistory> PointHistories { get; set; } = new List<PointHistory>();

    public virtual ICollection<Reply> Replies { get; set; } = new List<Reply>();

    public virtual MemberRole Role { get; set; } = null!;

    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();

    public virtual ICollection<TicketRequest> TicketRequests { get; set; } = new List<TicketRequest>();

    public virtual ICollection<TicketsTransfer> TicketsTransferMembers { get; set; } = new List<TicketsTransfer>();

    public virtual ICollection<TicketsTransfer> TicketsTransferTransferredTos { get; set; } = new List<TicketsTransfer>();

    public virtual ICollection<Validation> Validations { get; set; } = new List<Validation>();
}
