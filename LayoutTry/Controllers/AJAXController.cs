using LayoutTry.Models;
using LayoutTry.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace LayoutTry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AJAXController : ControllerBase
    {
        private readonly IspanFinContext _context;

        public AJAXController(IspanFinContext context)
        {
            _context = context;
        }

        // GET: api/Employees/5
        [HttpGet("strStatus")]
        public async Task<IEnumerable<TRListViewModel>> handleItemClick(TRListViewModel strStatus)
        {
            List<TRListViewModel> list = new List<TRListViewModel>();
            string str = "";
            if(strStatus != null)
            {
                if (strStatus.ToString() == "進行中")
                {
                    str = "0";
                }
                else if (strStatus.ToString() == "已滿足")
                {
                    str = "1";
                }
                else { str = "2"; }
            }    

            var datas = await _context.TicketRequests
                .Include(t => t.Event)
                .Include(t => t.Member)
                .Include(t => t.Section)
                .Include(t => t.Show)
                .Include(t => t.Ticket).ToListAsync();
            datas = await _context.TicketRequests
   .Where(p => p.RequestStatus.Contains(str))
   .ToListAsync();
            foreach (TicketRequest tr in datas)
            {
                TRListViewModel vm = new TRListViewModel
                {
                    TicketRequestId = (int)tr.TicketRequestId,
                    eventName = tr.Event.EventName,
                    TRStatus = tr.RequestStatus,
                    MemberID = (int)tr.Member.MemberId,
                    ReleaseDate = tr.ReleaseDate
                };
                list.Add(vm);
            }
        

            return list;

       
        }
    }
}
