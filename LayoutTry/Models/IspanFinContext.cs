using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LayoutTry.Models;

public partial class IspanFinContext : DbContext
{
    public IspanFinContext()
    {
    }

    public IspanFinContext(DbContextOptions<IspanFinContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<ActorSchedule> ActorSchedules { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Complain> Complains { get; set; }

    public virtual DbSet<Coupon> Coupons { get; set; }

    public virtual DbSet<Evaluate> Evaluates { get; set; }

    public virtual DbSet<EvaluatePhoto> EvaluatePhotos { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventImg> EventImgs { get; set; }

    public virtual DbSet<Example> Examples { get; set; }

    public virtual DbSet<GameRecord> GameRecords { get; set; }

    public virtual DbSet<HallPhoto> HallPhotos { get; set; }

    public virtual DbSet<LoginHistory> LoginHistories { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<MemberRole> MemberRoles { get; set; }

    public virtual DbSet<MyFavorite> MyFavorites { get; set; }

    public virtual DbSet<MyFollowing> MyFollowings { get; set; }

    public virtual DbSet<MyTicket> MyTickets { get; set; }

    public virtual DbSet<NegotiationDetail> NegotiationDetails { get; set; }

    public virtual DbSet<NegotiationHistory> NegotiationHistories { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationEvent> NotificationEvents { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<PaymentFlow> PaymentFlows { get; set; }

    public virtual DbSet<PaymentFlowType> PaymentFlowTypes { get; set; }

    public virtual DbSet<PointHistory> PointHistories { get; set; }

    public virtual DbSet<Refund> Refunds { get; set; }

    public virtual DbSet<Reply> Replies { get; set; }

    public virtual DbSet<Seat> Seats { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }

    public virtual DbSet<Show> Shows { get; set; }

    public virtual DbSet<SysAnnounceInfo> SysAnnounceInfos { get; set; }

    public virtual DbSet<SysCodeInfo> SysCodeInfos { get; set; }

    public virtual DbSet<SysGroup> SysGroups { get; set; }

    public virtual DbSet<SysGroupProgram> SysGroupPrograms { get; set; }

    public virtual DbSet<SysNlogLog> SysNlogLogs { get; set; }

    public virtual DbSet<SysNotify> SysNotifies { get; set; }

    public virtual DbSet<SysNotifyTemplate> SysNotifyTemplates { get; set; }

    public virtual DbSet<SysProgram> SysPrograms { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<TicketRequest> TicketRequests { get; set; }

    public virtual DbSet<TicketsTransfer> TicketsTransfers { get; set; }

    public virtual DbSet<Validation> Validations { get; set; }

    public virtual DbSet<Venue> Venues { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=.;TrustServerCertificate=true;Initial Catalog=ISpanFin;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("演員資料表"));

            entity.Property(e => e.ActorId)
                .HasComment("演員編號")
                .HasColumnName("ActorID");
            entity.Property(e => e.ActorBirth)
                .HasComment("演員生日")
                .HasColumnType("datetime");
            entity.Property(e => e.ActorGender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("演員性別");
            entity.Property(e => e.ActorImg)
                .HasMaxLength(50)
                .HasComment("演員照片");
            entity.Property(e => e.ActorName)
                .HasMaxLength(10)
                .HasComment("演員名字");
            entity.Property(e => e.CateId)
                .HasComment("類別編號")
                .HasColumnName("CateID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasComment("演員簡介");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Cate).WithMany(p => p.Actors)
                .HasForeignKey(d => d.CateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Actors_Category");
        });

        modelBuilder.Entity<ActorSchedule>(entity =>
        {
            entity.HasKey(e => e.SchId);

            entity.ToTable("ActorSchedule", tb => tb.HasComment("演員時程表"));

            entity.Property(e => e.SchId)
                .HasComment("時程表編號")
                .HasColumnName("SchID");
            entity.Property(e => e.ActorId)
                .HasComment("演員編號")
                .HasColumnName("ActorID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EventId)
                .HasComment("活動編號")
                .HasColumnName("EventID");
            entity.Property(e => e.ShowId)
                .HasComment("場次編號")
                .HasColumnName("ShowID");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Actor).WithMany(p => p.ActorSchedules)
                .HasForeignKey(d => d.ActorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActorSchedule_Actors");

            entity.HasOne(d => d.Event).WithMany(p => p.ActorSchedules)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActorSchedule_Events");

            entity.HasOne(d => d.Show).WithMany(p => p.ActorSchedules)
                .HasForeignKey(d => d.ShowId)
                .HasConstraintName("FK_ActorSchedule_Shows");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CateId);

            entity.ToTable("Category", tb => tb.HasComment("類別資料表"));

            entity.Property(e => e.CateId)
                .HasComment("類別編號")
                .HasColumnName("CateID");
            entity.Property(e => e.CateName)
                .HasMaxLength(10)
                .HasComment("類別名稱 音樂劇、舞台劇、喜劇演出");
        });

        modelBuilder.Entity<Complain>(entity =>
        {
            entity.ToTable("Complain", tb => tb.HasComment("申訴資料表"));

            entity.Property(e => e.ComplainId).HasColumnName("ComplainID");
            entity.Property(e => e.ContentOfComplaint).HasMaxLength(1000);
            entity.Property(e => e.CreatedBy).HasComment("外鍵Member-MemberID");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TitleOfComplaint).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Complains)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Complain_Member");
        });

        modelBuilder.Entity<Coupon>(entity =>
        {
            entity.HasKey(e => e.CouponId).HasName("PK_Coupons_1");

            entity.ToTable(tb => tb.HasComment("折扣優惠表"));

            entity.Property(e => e.CouponId)
                .ValueGeneratedNever()
                .HasComment("優惠券編號")
                .HasColumnName("CouponID");
            entity.Property(e => e.CouponCode)
                .HasMaxLength(10)
                .HasComment("優惠碼");
            entity.Property(e => e.CouponType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("優惠券類型");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DiscountPercentage).HasComment("折扣率 記錄折扣的金額或百分比");
            entity.Property(e => e.ExpirationDate)
                .HasComment("有效時間")
                .HasColumnType("datetime");
            entity.Property(e => e.StartDate)
                .HasComment("起始時間")
                .HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("資料狀態");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Evaluate>(entity =>
        {
            entity.HasKey(e => e.EvaluateId).HasName("PK__evaluate__2092E4DA9602E653");

            entity.ToTable("Evaluate", tb => tb.HasComment("位子評價資料表"));

            entity.Property(e => e.EvaluateId).HasColumnName("EvaluateID");
            entity.Property(e => e.AudioScore).HasComment("記錄使用者對於該項的評分,1-5分");
            entity.Property(e => e.Evaluate1)
                .HasMaxLength(1000)
                .HasComment("使用者對於該座位文字評價")
                .HasColumnName("Evaluate");
            entity.Property(e => e.EvaluateTime)
                .HasComment("紀錄評論時間")
                .HasColumnType("datetime");
            entity.Property(e => e.EventId)
                .HasComment("[Events].[EventID]  記錄使用者評價看的作品名稱")
                .HasColumnName("EventID");
            entity.Property(e => e.LightsScore).HasComment("記錄使用者對於該項的評分,1-5分");
            entity.Property(e => e.MemberId)
                .HasComment("[Member].[MemberID] 評價者ID,連接至會員資料表")
                .HasColumnName("MemberID");
            entity.Property(e => e.PositionScore).HasComment("位置分數");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.ViewScore).HasComment("記錄使用者對於該項的評分,1-5分");

            entity.HasOne(d => d.Event).WithMany(p => p.Evaluates)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Evaluate_Events");

            entity.HasOne(d => d.Member).WithMany(p => p.Evaluates)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Evaluate_Member");
        });

        modelBuilder.Entity<EvaluatePhoto>(entity =>
        {
            entity.HasKey(e => e.PhotoId).HasName("PK__evaluate__21B7B582B2AA67B6");

            entity.ToTable("EvaluatePhoto", tb => tb.HasComment("位子評價照片資料表"));

            entity.Property(e => e.PhotoId).HasColumnName("PhotoID");
            entity.Property(e => e.EvaluateId)
                .HasComment("[evaluate].[EvaluateID] 紀錄表演地點編號")
                .HasColumnName("EvaluateID");
            entity.Property(e => e.Photopath)
                .HasMaxLength(500)
                .HasComment("用以記錄表演廳照片在伺服器端路徑")
                .HasColumnName("photopath");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EvaluatePhotos)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EvaluatePhoto_Member");

            entity.HasOne(d => d.Evaluate).WithMany(p => p.EvaluatePhotos)
                .HasForeignKey(d => d.EvaluateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__evaluatep__Evalu__7E37BEF6");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("演出資料表"));

            entity.Property(e => e.EventId)
                .HasComment("活動編號")
                .HasColumnName("EventID");
            entity.Property(e => e.CateId)
                .HasComment("類別編號")
                .HasColumnName("CateID");
            entity.Property(e => e.CreatedDate)
                .HasComment("建立日期")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .HasComment("描述");
            entity.Property(e => e.EventImg)
                .HasMaxLength(40)
                .HasComment("活動圖片");
            entity.Property(e => e.EventName)
                .HasMaxLength(40)
                .HasComment("活動名稱");
            entity.Property(e => e.EventNumber).HasComment("活動幾演");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Cate).WithMany(p => p.Events)
                .HasForeignKey(d => d.CateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Events_Category");
        });

        modelBuilder.Entity<EventImg>(entity =>
        {
            entity.HasKey(e => e.ImgId);

            entity.ToTable("EventImg", tb => tb.HasComment("活動圖片表"));

            entity.Property(e => e.ImgId)
                .HasComment("圖片編碼")
                .HasColumnName("imgID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EventId)
                .HasComment("活動編號")
                .HasColumnName("EventID");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(20)
                .HasComment("圖片路徑")
                .HasColumnName("imgPath");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Event).WithMany(p => p.EventImgs)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventImg_Events");
        });

        modelBuilder.Entity<Example>(entity =>
        {
            entity.ToTable("Example", tb => tb.HasComment("通知範本"));

            entity.Property(e => e.ExampleId).HasColumnName("ExampleID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Example1)
                .HasMaxLength(100)
                .HasColumnName("Example");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GameRecord>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable(tb => tb.HasComment("遊戲紀錄表"));

            entity.Property(e => e.RecordId)
                .ValueGeneratedNever()
                .HasComment("紀錄編號")
                .HasColumnName("RecordID");
            entity.Property(e => e.GameDate)
                .HasComment("遊戲日期")
                .HasColumnType("datetime");
            entity.Property(e => e.GameType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("遊戲類型");
            entity.Property(e => e.GetPoints).HasComment("取得點數");
            entity.Property(e => e.MemberId)
                .HasComment("會員編號")
                .HasColumnName("MemberID");
            entity.Property(e => e.Score).HasComment("得分");

            entity.HasOne(d => d.Member).WithMany(p => p.GameRecords)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GameRecords_Member");
        });

        modelBuilder.Entity<HallPhoto>(entity =>
        {
            entity.HasKey(e => e.PhotoId).HasName("PK__hallphot__21B7B5827C6C8186");

            entity.ToTable("HallPhoto", tb => tb.HasComment("表演廳照片資料表"));

            entity.Property(e => e.PhotoId).HasColumnName("PhotoID");
            entity.Property(e => e.CreatedBy).HasMaxLength(10);
            entity.Property(e => e.Photodescription)
                .HasMaxLength(1000)
                .HasComment("以文字記錄該照片敘述")
                .HasColumnName("photodescription");
            entity.Property(e => e.Photopath)
                .HasMaxLength(500)
                .HasComment("用以記錄表演廳照片在伺服器端路徑")
                .HasColumnName("photopath");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.VenueId)
                .HasComment("[Venues].[VenueID]  紀錄表演地點編號")
                .HasColumnName("VenueID");

            entity.HasOne(d => d.Venue).WithMany(p => p.HallPhotos)
                .HasForeignKey(d => d.VenueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HallPhoto_Venues");
        });

        modelBuilder.Entity<LoginHistory>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("LoginHistory", tb => tb.HasComment("登入歷史資料表"));

            entity.Property(e => e.RecordId)
                .HasComment("紀錄編號")
                .HasColumnName("RecordID");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasComment("IP地址")
                .HasColumnName("IPAddress");
            entity.Property(e => e.LoginTime)
                .HasComment("登入時間")
                .HasColumnType("datetime");
            entity.Property(e => e.MemberId)
                .HasComment("會員編號")
                .HasColumnName("MemberID");

            entity.HasOne(d => d.Member).WithMany(p => p.LoginHistories)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoginHistory_Member");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.ToTable("Member", tb => tb.HasComment("會員表"));

            entity.Property(e => e.MemberId)
                .HasComment("會員編號")
                .HasColumnName("MemberID");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasComment("住址");
            entity.Property(e => e.Birthday).HasComment("生日");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasComment("電子郵件");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("性別");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("姓名");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasComment("密碼");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasComment("電話");
            entity.Property(e => e.RegistrationDate)
                .HasComment("註冊日期")
                .HasColumnType("datetime")
                .HasColumnName("Registration date");
            entity.Property(e => e.RoleId)
                .HasComment("會員等級")
                .HasColumnName("RoleID");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("狀態旗標");
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasComment("使用者名稱");

            entity.HasOne(d => d.Role).WithMany(p => p.Members)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Member_MemberRoles");
        });

        modelBuilder.Entity<MemberRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable(tb => tb.HasComment("會員權限"));

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasComment("會員等級編號")
                .HasColumnName("RoleID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.RoleName)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasComment("會員等級名稱");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MyFavorite>(entity =>
        {
            entity.HasKey(e => e.MyFaveritesId);

            entity.ToTable(tb => tb.HasComment("我的收藏"));

            entity.Property(e => e.MyFaveritesId)
                .HasComment("我的收藏編號")
                .HasColumnName("MyFaveritesID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EventId)
                .HasComment("活動編號")
                .HasColumnName("EventID");
            entity.Property(e => e.MemberId)
                .HasComment("會員編號")
                .HasColumnName("MemberID");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Event).WithMany(p => p.MyFavorites)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MyFavorites_Events");

            entity.HasOne(d => d.Member).WithMany(p => p.MyFavorites)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MyFavorites_Member");
        });

        modelBuilder.Entity<MyFollowing>(entity =>
        {
            entity.ToTable("MyFollowing", tb => tb.HasComment("我的關注"));

            entity.Property(e => e.MyFollowingId)
                .HasComment("我的關注編號")
                .HasColumnName("MyFollowingID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasComment("通知狀態");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EventId)
                .HasComment("活動編號")
                .HasColumnName("EventID");
            entity.Property(e => e.MemberId)
                .HasComment("會員編號")
                .HasColumnName("MemberID");
            entity.Property(e => e.NotificationId)
                .HasComment("場地編號")
                .HasColumnName("NotificationID");
            entity.Property(e => e.ShowId)
                .HasComment("場次編號")
                .HasColumnName("ShowID");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("票券編號");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Event).WithMany(p => p.MyFollowings)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MyFollowing_Events");

            entity.HasOne(d => d.Member).WithMany(p => p.MyFollowings)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MyFollowing_Member");

            entity.HasOne(d => d.Notification).WithMany(p => p.MyFollowings)
                .HasForeignKey(d => d.NotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MyFollowing_Notification");

            entity.HasOne(d => d.Show).WithMany(p => p.MyFollowings)
                .HasForeignKey(d => d.ShowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MyFollowing_Shows");
        });

        modelBuilder.Entity<MyTicket>(entity =>
        {
            entity.HasKey(e => e.MyTicketsId);

            entity.ToTable(tb => tb.HasComment("我的票卷資料表"));

            entity.Property(e => e.MyTicketsId)
                .HasComment("持有票券編號")
                .HasColumnName("MyTicketsID");
            entity.Property(e => e.MemberId)
                .HasComment("會員編號")
                .HasColumnName("MemberID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasComment("票券狀態");
            entity.Property(e => e.TicketId)
                .HasComment("票卷ID")
                .HasColumnName("TicketID");

            entity.HasOne(d => d.Member).WithMany(p => p.MyTickets)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MyTickets_Member");

            entity.HasOne(d => d.Ticket).WithMany(p => p.MyTickets)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MyTickets_Tickets");
        });

        modelBuilder.Entity<NegotiationDetail>(entity =>
        {
            entity.HasKey(e => e.NegotiationDetailId).HasName("PK__Negotiat__45A31998B6E09C5E");

            entity.ToTable("NegotiationDetail", tb => tb.HasComment("議價細節資料表"));

            entity.Property(e => e.NegotiationDetailId).HasColumnName("NegotiationDetailID");
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
            entity.Property(e => e.TransactionId)
                .HasComment("[NegotiationHistory].[TransactionID]")
                .HasColumnName("TransactionID");

            entity.HasOne(d => d.Transaction).WithMany(p => p.NegotiationDetails)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Negotiati__Trans__68487DD7");
        });

        modelBuilder.Entity<NegotiationHistory>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Negotiat__55433A4B195A8785");

            entity.ToTable("NegotiationHistory", tb => tb.HasComment("議價歷史資料表"));

            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.BuyerMemberId)
                .HasComment("[Member].[MemberID]")
                .HasColumnName("BuyerMemberID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Fee).HasComment("交易成立，抽成該筆交易的5%");
            entity.Property(e => e.OrderId)
                .HasComment("[Orders].[OrdersID]")
                .HasColumnName("OrderID");
            entity.Property(e => e.SellerMemberId)
                .HasComment("[Member].[MemberID]")
                .HasColumnName("SellerMemberID");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.TicketRequestId)
                .HasComment("TicketRequest.TicketRequestID")
                .HasColumnName("TicketRequestID");
            entity.Property(e => e.TicketSellingStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("預設值為 0。進行中：0，已完成：1，已取消：2");
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.BuyerMember).WithMany(p => p.NegotiationHistoryBuyerMembers)
                .HasForeignKey(d => d.BuyerMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NegotiationHistory_MemberBuyer");

            entity.HasOne(d => d.Order).WithMany(p => p.NegotiationHistories)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_NegotiationHistory_Orders");

            entity.HasOne(d => d.SellerMember).WithMany(p => p.NegotiationHistorySellerMembers)
                .HasForeignKey(d => d.SellerMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NegotiationHistory_MemberSeller");

            entity.HasOne(d => d.TicketRequest).WithMany(p => p.NegotiationHistories)
                .HasForeignKey(d => d.TicketRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NegotiationHistory_TicketRequest");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.ToTable("Notification", tb => tb.HasComment("通知"));

            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExampleId).HasColumnName("ExampleID");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Example).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.ExampleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notification_Example");
        });

        modelBuilder.Entity<NotificationEvent>(entity =>
        {
            entity.ToTable("NotificationEvent");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FinalContent).HasMaxLength(100);
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.SendTime).HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.NotificationEvent)
                .HasForeignKey<NotificationEvent>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotificationEvent_Member");

            entity.HasOne(d => d.Id1).WithOne(p => p.NotificationEvent)
                .HasForeignKey<NotificationEvent>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotificationEvent_Notification");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrdersId);

            entity.ToTable(tb => tb.HasComment("訂購表"));

            entity.Property(e => e.OrdersId)
                .ValueGeneratedNever()
                .HasComment("訂單編號")
                .HasColumnName("OrdersID");
            entity.Property(e => e.CreatedBy).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeviceInformaton)
                .HasMaxLength(50)
                .HasComment("設備信息")
                .HasColumnName("Device_Informaton");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .HasComment("IP地址")
                .HasColumnName("IP_Address");
            entity.Property(e => e.MemberId)
                .HasComment("會員編號")
                .HasColumnName("MemberID");
            entity.Property(e => e.OrderDate)
                .HasComment("訂購時間")
                .HasColumnType("datetime");
            entity.Property(e => e.OrderType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("交易類型 1:1手 2:2手");
            entity.Property(e => e.PaymentFlow)
                .HasMaxLength(50)
                .HasComment("支付方式 標識使用的支付方式，如Line PAY、藍新、綠界等");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(50)
                .HasComment("付款狀態 記錄交易的當前狀態，例如待付款、已支付、支付失敗");
            entity.Property(e => e.Province)
                .HasMaxLength(20)
                .HasComment("縣市");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasComment("備註");
            entity.Property(e => e.ShippingAddress)
                .HasMaxLength(100)
                .HasComment("地址");
            entity.Property(e => e.Total)
                .HasComment("總計金額")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TransactionTime)
                .HasComment("交易完成時間")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Member).WithMany(p => p.Orders)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Member");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.ToTable("OrderDetail", tb => tb.HasComment("訂購明細表"));

            entity.Property(e => e.OrderDetailId)
                .HasComment("訂單明細編號")
                .HasColumnName("OrderDetailID");
            entity.Property(e => e.CouponId)
                .HasComment("優惠碼")
                .HasColumnName("CouponID");
            entity.Property(e => e.CreatedBy).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasComment("訂單編號")
                .HasColumnName("OrderID");
            entity.Property(e => e.Quantity).HasComment("數量");
            entity.Property(e => e.SubTotal)
                .HasComment("小計")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TicketId)
                .HasComment("票券編號")
                .HasColumnName("TicketID");
            entity.Property(e => e.UnitPrice)
                .HasComment("單價")
                .HasColumnType("money");
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Coupon).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.CouponId)
                .HasConstraintName("FK_OrderDetail_OrderDetail");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetail_Orders");

            entity.HasOne(d => d.Ticket).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetail_Tickets");
        });

        modelBuilder.Entity<PaymentFlow>(entity =>
        {
            entity.HasKey(e => e.PaymentId);

            entity.ToTable("PaymentFlow", tb => tb.HasComment("第3方金流表"));

            entity.Property(e => e.PaymentId)
                .ValueGeneratedNever()
                .HasComment("支付金流ID")
                .HasColumnName("PaymentID");
            entity.Property(e => e.CreatedBy).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.OrdersId)
                .HasComment("訂單編號")
                .HasColumnName("OrdersID");
            entity.Property(e => e.PayNotificationUrl)
                .HasMaxLength(10)
                .HasComment("支付通知URL")
                .HasColumnName("PayNotificationURL");
            entity.Property(e => e.PayResponseCode)
                .HasMaxLength(10)
                .HasComment("支付機構返回的代碼，用於判斷交易是否成功");
            entity.Property(e => e.PayResponseMessage)
                .HasMaxLength(10)
                .HasComment("支付回應訊息");
            entity.Property(e => e.PaymentTypeId)
                .HasComment("支付方式ID")
                .HasColumnName("PaymentTypeID");
            entity.Property(e => e.SecurityKey)
                .HasMaxLength(10)
                .HasComment("安全金鑰");
            entity.Property(e => e.TransactionAmount)
                .HasComment("交易金額")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TransactionDescription)
                .HasMaxLength(10)
                .HasComment("交易描述");
            entity.Property(e => e.TransactionStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("記錄交易的當前狀態，例如待付款、已支付、支付失敗等。");
            entity.Property(e => e.TransactionTime)
                .HasComment("交易時間")
                .HasColumnType("datetime");
            entity.Property(e => e.TransactionVerificationCode)
                .HasMaxLength(10)
                .HasComment("交易驗證碼");
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Orders).WithMany(p => p.PaymentFlows)
                .HasForeignKey(d => d.OrdersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentFlow_Orders");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.PaymentFlows)
                .HasForeignKey(d => d.PaymentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentFlow_PaymentFlowType");
        });

        modelBuilder.Entity<PaymentFlowType>(entity =>
        {
            entity.HasKey(e => e.PaymentTypeId);

            entity.ToTable("PaymentFlowType", tb => tb.HasComment("第3方金流種類表"));

            entity.Property(e => e.PaymentTypeId)
                .ValueGeneratedNever()
                .HasComment("支付方式ID，如Line PAY、藍新、綠界")
                .HasColumnName("PaymentTypeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentTypeName)
                .HasMaxLength(50)
                .HasComment("支付方式Name，如Line PAY、藍新、綠界");
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PointHistory>(entity =>
        {
            entity.ToTable("PointHistory", tb => tb.HasComment("點數歷程資料表"));

            entity.Property(e => e.PointHistoryId)
                .HasComment("點數歷程ID")
                .HasColumnName("PointHistoryID");
            entity.Property(e => e.Balance).HasComment("點數餘額");
            entity.Property(e => e.CreatedBy).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasComment("交易描述");
            entity.Property(e => e.DividerBy)
                .HasMaxLength(50)
                .HasComment("點數來源者")
                .HasColumnName("DividerBY");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .HasComment("IP地址")
                .HasColumnName("IP_Address");
            entity.Property(e => e.MemberId)
                .HasComment("會員編號")
                .HasColumnName("MemberID");
            entity.Property(e => e.PointAmount).HasComment("點數變動數量");
            entity.Property(e => e.PointType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("點數類型 包括「1:得到/增加」、「2:使用/減少」、「3:提現」、「贈送」等 ");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasComment("備註");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.TradingTime)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasComment("交易時間戳");
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Member).WithMany(p => p.PointHistories)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PointHistory_Member");
        });

        modelBuilder.Entity<Refund>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("退款表"));

            entity.Property(e => e.RefundId)
                .ValueGeneratedNever()
                .HasComment("退票編號")
                .HasColumnName("RefundID");
            entity.Property(e => e.Comments)
                .HasMaxLength(50)
                .HasComment("註解");
            entity.Property(e => e.CreatedBy).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasComment("訂單編號")
                .HasColumnName("OrderID");
            entity.Property(e => e.PaymentFlowId)
                .HasComment("退款金流ID")
                .HasColumnName("PaymentFlowID");
            entity.Property(e => e.ProcessedBy)
                .HasMaxLength(50)
                .HasComment("處理人員");
            entity.Property(e => e.ProcessingStatus)
                .HasMaxLength(50)
                .HasComment("處理狀態 例如「處理中」、「已完成」");
            entity.Property(e => e.RefundAmount)
                .HasComment("退款金額")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RefundDate)
                .HasComment("退款日期")
                .HasColumnType("datetime");
            entity.Property(e => e.RefundReason)
                .HasMaxLength(100)
                .HasComment("退款原因");
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Order).WithMany(p => p.Refunds)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Refunds_Orders");

            entity.HasOne(d => d.PaymentFlow).WithMany(p => p.Refunds)
                .HasForeignKey(d => d.PaymentFlowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Refunds_PaymentFlow");
        });

        modelBuilder.Entity<Reply>(entity =>
        {
            entity.HasKey(e => e.ReplyId).HasName("PK__Reply__C25E46292905E846");

            entity.ToTable("Reply", tb => tb.HasComment("回覆資料表"));

            entity.Property(e => e.ReplyId).HasColumnName("ReplyID");
            entity.Property(e => e.CommentScore).HasComment("讓回覆者表示是否同意評論者可用於評論可信度");
            entity.Property(e => e.EvaluateId)
                .HasComment("[evaluate].[EvaluateID] 連接至評論資料庫查詢回覆的評論是哪則")
                .HasColumnName("EvaluateID");
            entity.Property(e => e.MemberId)
                .HasComment("[Member].[MemberID]  紀錄回覆使用者編號")
                .HasColumnName("MemberID");
            entity.Property(e => e.Reply1)
                .HasMaxLength(1000)
                .HasComment("對於評價的回覆")
                .HasColumnName("Reply");
            entity.Property(e => e.ReplyTime)
                .HasComment("紀錄回覆時間")
                .HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);

            entity.HasOne(d => d.Evaluate).WithMany(p => p.Replies)
                .HasForeignKey(d => d.EvaluateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reply__EvaluateI__74AE54BC");

            entity.HasOne(d => d.Member).WithMany(p => p.Replies)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reply_Member");
        });

        modelBuilder.Entity<Seat>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("座位資料表"));

            entity.Property(e => e.SeatId)
                .HasComment("座位編號")
                .HasColumnName("SeatID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsAvailable).HasComment("是否可用");
            entity.Property(e => e.Price)
                .HasComment("票價定價")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SeatClass)
                .HasMaxLength(10)
                .HasComment("座位等級 一般，輪椅");
            entity.Property(e => e.SeatNum).HasComment("座位號碼");
            entity.Property(e => e.SeatRow)
                .HasMaxLength(5)
                .HasComment("座位排");
            entity.Property(e => e.SectionId)
                .HasComment("票區編碼")
                .HasColumnName("SectionID");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VenueId)
                .HasComment("地點編號")
                .HasColumnName("VenueID");

            entity.HasOne(d => d.Section).WithMany(p => p.Seats)
                .HasForeignKey(d => d.SectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Seats_Sections");

            entity.HasOne(d => d.Venue).WithMany(p => p.Seats)
                .HasForeignKey(d => d.VenueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Seats_Venues");
        });

        modelBuilder.Entity<Section>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("票區資料表"));

            entity.Property(e => e.SectionId)
                .HasComment("票區編號")
                .HasColumnName("SectionID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.SectionName)
                .HasMaxLength(20)
                .HasComment("場地編號");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VenueId)
                .HasComment("票區名稱")
                .HasColumnName("VenueID");

            entity.HasOne(d => d.Venue).WithMany(p => p.Sections)
                .HasForeignKey(d => d.VenueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sections_Venues");
        });

        modelBuilder.Entity<ShoppingCart>(entity =>
        {
            entity.HasKey(e => e.CartId);

            entity.ToTable("ShoppingCart", tb => tb.HasComment("購物車表"));

            entity.Property(e => e.CartId)
                .ValueGeneratedNever()
                .HasComment("購物車編號")
                .HasColumnName("CartID");
            entity.Property(e => e.CartType).HasComment("購物車種類 1:1手 2:2手");
            entity.Property(e => e.CouponId)
                .HasComment("優惠券編號")
                .HasColumnName("CouponID");
            entity.Property(e => e.CreatedBy).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MemberId)
                .HasComment("會員ID")
                .HasColumnName("MemberID");
            entity.Property(e => e.TicketId)
                .HasComment("票卷ID")
                .HasColumnName("TicketID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Coupon).WithMany(p => p.ShoppingCarts)
                .HasForeignKey(d => d.CouponId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShoppingCart_Coupons");

            entity.HasOne(d => d.Member).WithMany(p => p.ShoppingCarts)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShoppingCart_Member");

            entity.HasOne(d => d.Ticket).WithMany(p => p.ShoppingCarts)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShoppingCart_Tickets");
        });

        modelBuilder.Entity<Show>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("演出場次資料表"));

            entity.Property(e => e.ShowId)
                .HasComment("場次編號")
                .HasColumnName("ShowID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate)
                .HasComment("建立日期")
                .HasColumnType("datetime");
            entity.Property(e => e.EventId)
                .HasComment("活動編號")
                .HasColumnName("EventID");
            entity.Property(e => e.Runtime).HasComment("演出執行時間");
            entity.Property(e => e.SeatId)
                .HasComment("座位編號")
                .HasColumnName("SeatID");
            entity.Property(e => e.ShowDate).HasComment("日期");
            entity.Property(e => e.ShowTime)
                .HasComment("時間")
                .HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VenueId)
                .HasComment("地點編號")
                .HasColumnName("VenueID");

            entity.HasOne(d => d.Event).WithMany(p => p.Shows)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shows_Events");

            entity.HasOne(d => d.Seat).WithMany(p => p.Shows)
                .HasForeignKey(d => d.SeatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shows_Seats");

            entity.HasOne(d => d.Venue).WithMany(p => p.Shows)
                .HasForeignKey(d => d.VenueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shows_Venues");
        });

        modelBuilder.Entity<SysAnnounceInfo>(entity =>
        {
            entity.HasKey(e => e.AnnounceId).HasName("PK_AnnounceInfo");

            entity.ToTable("SysAnnounceInfo", tb => tb.HasComment("公告資料表"));

            entity.Property(e => e.AnnounceId)
                .HasComment("公告ID")
                .HasColumnName("AnnounceID");
            entity.Property(e => e.AnnounceContentType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("內文種類(保留)");
            entity.Property(e => e.AnnounceKind)
                .HasMaxLength(50)
                .HasComment("公告種類");
            entity.Property(e => e.AnnounceText).HasComment("內容");
            entity.Property(e => e.AnnounceTitle)
                .HasMaxLength(100)
                .HasComment("標題");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpirationDate)
                .HasComment("結束日期")
                .HasColumnType("datetime");
            entity.Property(e => e.StartDate)
                .HasComment("起始日期")
                .HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasComment("使用者ID")
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<SysCodeInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SysCodeInfo", tb => tb.HasComment("系統參數表"));

            entity.Property(e => e.Cate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cate");
            entity.Property(e => e.CodeId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("code_id");
            entity.Property(e => e.CodeName)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("code_name");
            entity.Property(e => e.CodeUuid).HasColumnName("code_uuid");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasComment("建立者");
            entity.Property(e => e.CreatedDate)
                .HasComment("建立時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(400)
                .HasColumnName("description");
            entity.Property(e => e.ModifyStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("modify_status");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.SuperUuid).HasColumnName("super_uuid");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasComment("UpdatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasComment("修改時間")
                .HasColumnType("datetime");
            entity.Property(e => e.VarChar01)
                .HasMaxLength(150)
                .HasColumnName("var_char01");
            entity.Property(e => e.VarChar02)
                .HasMaxLength(150)
                .HasColumnName("var_char02");
            entity.Property(e => e.VarChar03)
                .HasMaxLength(150)
                .HasColumnName("var_char03");
            entity.Property(e => e.VarChar04)
                .HasMaxLength(150)
                .HasColumnName("var_char04");
            entity.Property(e => e.VarChar05)
                .HasMaxLength(150)
                .HasColumnName("var_char05");
        });

        modelBuilder.Entity<SysGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SysGroup");

            entity.Property(e => e.AdminGroup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("admin_group");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GroupId)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("group_id");
            entity.Property(e => e.GroupName)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("group_name");
            entity.Property(e => e.GroupUuid).HasColumnName("group_uuid");
            entity.Property(e => e.OrgId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("org_id");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SystemId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("system_id");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SysGroupProgram>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SysGroupProgram");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FuncUuid).HasColumnName("func_uuid");
            entity.Property(e => e.GroupUuid).HasColumnName("group_uuid");
            entity.Property(e => e.PermissionUuid).HasColumnName("permission_uuid");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SysNlogLog>(entity =>
        {
            entity.HasKey(e => e.NlogId).HasName("PK_NLogLogs");

            entity.ToTable("SysNLogLogs", tb => tb.HasComment("Log資料表"));

            entity.Property(e => e.NlogId)
                .HasComment("NLogID")
                .HasColumnName("NLogID");
            entity.Property(e => e.Application).HasMaxLength(50);
            entity.Property(e => e.CallSite).HasComment("呼叫站台");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasComment("建立者");
            entity.Property(e => e.CreatedDate)
                .HasComment("建立時間")
                .HasColumnType("datetime");
            entity.Property(e => e.EventLevel)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasComment("記錄該日誌信息的級別（例如，Info、Warn、Error等）");
            entity.Property(e => e.EventTime)
                .HasComment("日誌信息時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Exception).HasComment("異常信息");
            entity.Property(e => e.IsHttps)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasComment("是否HTTPS T:是 F:否");
            entity.Property(e => e.Logger)
                .HasMaxLength(50)
                .HasComment("日誌器名稱");
            entity.Property(e => e.Message).HasComment("日誌消息內容");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasComment("修改者");
            entity.Property(e => e.UpdatedDate)
                .HasComment("修改時間")
                .HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<SysNotify>(entity =>
        {
            entity.HasKey(e => e.NotifyId).HasName("PK_SmsDetail");

            entity.ToTable("SysNotify", tb => tb.HasComment("通知資料表"));

            entity.Property(e => e.NotifyId)
                .HasComment("通知ID")
                .HasColumnName("NotifyID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasComment("建立者");
            entity.Property(e => e.CreatedDate)
                .HasComment("建立時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasComment("電子郵件")
                .HasColumnName("email");
            entity.Property(e => e.FileUrl)
                .HasMaxLength(50)
                .HasComment("檔案URL")
                .HasColumnName("File_Url");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .HasComment("手機門號")
                .HasColumnName("mobile");
            entity.Property(e => e.PdfUrl)
                .HasMaxLength(50)
                .HasComment("pdf存放路徑;for EMAIL 用 (保留)")
                .HasColumnName("pdf_url");
            entity.Property(e => e.SentBody)
                .HasMaxLength(500)
                .HasComment("內文")
                .HasColumnName("sent_body");
            entity.Property(e => e.SentDate)
                .HasComment("傳送日期")
                .HasColumnType("datetime")
                .HasColumnName("sent_date");
            entity.Property(e => e.SentStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment(" 狀態;0:未寄送、1:已寄送結案、8:異常、9:終止")
                .HasColumnName("sent_status");
            entity.Property(e => e.SentTitle)
                .HasMaxLength(50)
                .HasComment("標題")
                .HasColumnName("sent_title");
            entity.Property(e => e.SmsKind)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("發送類型;2:手機、1:EMAIL")
                .HasColumnName("sms_kind");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasComment("修改者");
            entity.Property(e => e.UpdatedDate)
                .HasComment("修改時間")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasComment("會員代碼")
                .HasColumnName("UserID");
            entity.Property(e => e.WordCnt)
                .HasComment("字數(保留)")
                .HasColumnName("word_cnt");
            entity.Property(e => e.XmlUrl)
                .HasMaxLength(50)
                .HasComment("xml存放路徑;for EMAIL 用 (保留)")
                .HasColumnName("xml_url");
        });

        modelBuilder.Entity<SysNotifyTemplate>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PK_NotifyTemplate");

            entity.ToTable("SysNotifyTemplate", tb => tb.HasComment("通知範本資料表"));

            entity.Property(e => e.TemplateId)
                .HasComment("範本ID")
                .HasColumnName("TemplateID");
            entity.Property(e => e.Channel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("通道(保留)")
                .HasColumnName("channel");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.NotifyId)
                .HasComment("通知ID")
                .HasColumnName("NotifyID");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TemplateName)
                .HasMaxLength(20)
                .HasComment("範本名稱");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Notify).WithMany(p => p.SysNotifyTemplates)
                .HasForeignKey(d => d.NotifyId)
                .HasConstraintName("FK_SysNotifyTemplate_SysNotify");
        });

        modelBuilder.Entity<SysProgram>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SysProgram");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Descriptions)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descriptions");
            entity.Property(e => e.FlowUuid).HasColumnName("flow_uuid");
            entity.Property(e => e.FuncClass)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("func_class");
            entity.Property(e => e.FuncEntity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("func_entity");
            entity.Property(e => e.FuncId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("func_id");
            entity.Property(e => e.FuncName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("func_name");
            entity.Property(e => e.FuncSid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("func_sid");
            entity.Property(e => e.FuncType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("func_type");
            entity.Property(e => e.FuncUrl)
                .HasMaxLength(200)
                .HasColumnName("func_url");
            entity.Property(e => e.FuncUuid).HasColumnName("func_uuid");
            entity.Property(e => e.KeyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("key_name");
            entity.Property(e => e.NewTab)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("new_tab");
            entity.Property(e => e.SeqNo).HasColumnName("seq_no");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SuperUuid).HasColumnName("super_uuid");
            entity.Property(e => e.SystemId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("system_id");
            entity.Property(e => e.TableName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("table_name");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("售票資料表"));

            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsSold).HasColumnName("isSold");
            entity.Property(e => e.OrderId)
                .HasComment("訂單編號")
                .HasColumnName("OrderID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SeatId)
                .HasComment("座位編號")
                .HasColumnName("SeatID");
            entity.Property(e => e.ShowId)
                .HasComment("場次編號")
                .HasColumnName("ShowID");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TicketName)
                .HasMaxLength(50)
                .HasComment("票券名稱");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Order).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_Tickets_Orders");

            entity.HasOne(d => d.Seat).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.SeatId)
                .HasConstraintName("FK_Tickets_Seats");

            entity.HasOne(d => d.Show).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.ShowId)
                .HasConstraintName("FK_Tickets_Venues");
        });

        modelBuilder.Entity<TicketRequest>(entity =>
        {
            entity.HasKey(e => e.TicketRequestId).HasName("PK__TicketRe__904A44286183B777");

            entity.ToTable("TicketRequest", tb => tb.HasComment("徵票/出票需求資料表"));

            entity.Property(e => e.TicketRequestId).HasColumnName("TicketRequestID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EventId)
                .HasComment("[Events].[EventID]  從活動編號讀取該活動票區，讓使用者選擇可接受的票價範圍")
                .HasColumnName("EventID");
            entity.Property(e => e.MemberId)
                .HasComment("[Member].[MemberID]")
                .HasColumnName("MemberID");
            entity.Property(e => e.QuantityRequest)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("預設值為 1");
            entity.Property(e => e.ReleaseDate).HasColumnType("datetime");
            entity.Property(e => e.RequestPrice).HasComment("單張票券的價格，預設值為票區原價");
            entity.Property(e => e.RequestStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("預設值為 0。進行中：0，已滿足：1，已取消：2");
            entity.Property(e => e.SeatRangeE)
                .HasComment("儲存被選取的座位ID")
                .HasColumnName("SeatRange_e");
            entity.Property(e => e.SeatRangeS)
                .HasComment("儲存被選取的座位ID")
                .HasColumnName("SeatRange_s");
            entity.Property(e => e.SectionId)
                .HasComment("[Sections].[SectionID]")
                .HasColumnName("SectionID");
            entity.Property(e => e.ShowId)
                .HasComment("[Shows].[ShowID]")
                .HasColumnName("ShowID");
            entity.Property(e => e.TicketCategoryId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("預設值為 1。出票：0，徵票：1")
                .HasColumnName("TicketCategoryID");
            entity.Property(e => e.TicketId)
                .HasComment("[Tickets].[TicketID] ")
                .HasColumnName("TicketID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Event).WithMany(p => p.TicketRequests)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketRequest_Events");

            entity.HasOne(d => d.Member).WithMany(p => p.TicketRequests)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketRequest_Member");

            entity.HasOne(d => d.Section).WithMany(p => p.TicketRequests)
                .HasForeignKey(d => d.SectionId)
                .HasConstraintName("FK_TicketRequest_Sections");

            entity.HasOne(d => d.Show).WithMany(p => p.TicketRequests)
                .HasForeignKey(d => d.ShowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketRequest_Shows");

            entity.HasOne(d => d.Ticket).WithMany(p => p.TicketRequests)
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK_TicketRequest_Tickets");
        });

        modelBuilder.Entity<TicketsTransfer>(entity =>
        {
            entity.ToTable("TicketsTransfer", tb => tb.HasComment("分票紀錄"));

            entity.Property(e => e.TicketsTransferId)
                .ValueGeneratedNever()
                .HasColumnName("TicketsTransferID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Link)
                .HasMaxLength(50)
                .HasComment("分票連結");
            entity.Property(e => e.MemberId)
                .HasComment("會員編號")
                .HasColumnName("MemberID");
            entity.Property(e => e.ReceiveDate)
                .HasComment("收票日期")
                .HasColumnType("datetime");
            entity.Property(e => e.Status).HasComment("分票狀態");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TicketId)
                .HasComment("票券編號")
                .HasColumnName("TicketID");
            entity.Property(e => e.TransferDate)
                .HasComment("分票日期")
                .HasColumnType("datetime");
            entity.Property(e => e.TransferredToId)
                .HasComment("收票者編號")
                .HasColumnName("TransferredToID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Member).WithMany(p => p.TicketsTransferMembers)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketsTransfer_Member");

            entity.HasOne(d => d.Ticket).WithMany(p => p.TicketsTransfers)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketsTransfer_Tickets");

            entity.HasOne(d => d.TransferredTo).WithMany(p => p.TicketsTransferTransferredTos)
                .HasForeignKey(d => d.TransferredToId)
                .HasConstraintName("FK_TicketsTransfer_MemberTransID");
        });

        modelBuilder.Entity<Validation>(entity =>
        {
            entity.ToTable("Validation", tb => tb.HasComment("驗證"));

            entity.Property(e => e.ValidationId)
                .ValueGeneratedOnAdd()
                .HasComment("驗證編號")
                .HasColumnName("ValidationID");
            entity.Property(e => e.CodeTime).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MemberId)
                .HasComment("會員編號")
                .HasColumnName("MemberID");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.TicketId)
                .HasComment("票券編號")
                .HasColumnName("TicketID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UseTime).HasColumnType("datetime");
            entity.Property(e => e.ValidationCode)
                .HasMaxLength(50)
                .HasComment("驗證碼");

            entity.HasOne(d => d.Member).WithMany(p => p.Validations)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Validation_Member");

            entity.HasOne(d => d.ValidationNavigation).WithOne(p => p.Validation)
                .HasForeignKey<Validation>(d => d.ValidationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Validation_Tickets");
        });

        modelBuilder.Entity<Venue>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("場地資料表"));

            entity.Property(e => e.VenueId)
                .HasComment("地點編號")
                .HasColumnName("VenueID");
            entity.Property(e => e.Capacity).HasComment("容納人數");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Province)
                .HasMaxLength(20)
                .HasComment("縣市");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VenueAddress)
                .HasMaxLength(20)
                .HasComment("地址");
            entity.Property(e => e.VenueName)
                .HasMaxLength(20)
                .HasComment("地點名稱");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
