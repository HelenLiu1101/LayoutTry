using System.ComponentModel;

namespace LayoutTry.ViewModel
{
    public class TRListViewModel
    {

        [DisplayName("演出名稱")]
        public string? eventName { get; set; }

        // Additional property to store the processing state
        public string? strStatus { get; set; }
        [DisplayName("需求狀態")]

        public string TRStatus
        {
            get
            {
                return strStatus = "等待中";
            }
            set
            {
                // Custom logic to set the status based on the provided value
                if (value == "0")
                {
                    strStatus = "進行中";
                }
                else if (value == "1")
                {
                    strStatus = "已滿足";

                }
                else if (value == "2")
                {
                    strStatus = "已取消";
                }
            }
        }





        [DisplayName("上架日期")]
        public DateTime? ReleaseDate { get; set; }



        public int TicketRequestId { get; set; }

        [DisplayName("會員ID")]
        public int? MemberID { get; set; }
    }
}
