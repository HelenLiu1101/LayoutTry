﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LayoutTry.Models;
using LayoutTry.DTO;
using LayoutTry.ViewModel;

namespace LayoutTry.Controllers
{
    public class TicketRequestsController : Controller
    {
        private readonly IspanFinContext _context;

        public TicketRequestsController(IspanFinContext context)
        {
            _context = context;
        }


        // GET: TicketRequests
        //    public async Task<IActionResult> List(CKeywordViewModel keyWvm)
        //    {
        //        List<TRListViewModel> list = new List<TRListViewModel>();

        //        var datas = await _context.TicketRequests
        //            .Include(t => t.Event)
        //            .Include(t => t.Member)
        //            .Include(t => t.Section)
        //            .Include(t => t.Show)
        //            .Include(t => t.Ticket).ToListAsync();

        //        if (string.IsNullOrEmpty(keyWvm.txtKeyword))
        //        {
        //            foreach (TicketRequest tr in datas)
        //            {
        //                TRListViewModel vm = new TRListViewModel();
        //                vm.TicketRequestId = tr.TicketRequestId;
        //                vm.eventName = tr.Event.EventName;
        //                vm.TRStatus = tr.RequestStatus;
        //                vm.ReleaseDate = tr.ReleaseDate;
        //                list.Add(vm);

        //            }
        //        }
        //        else
        //        {


        //            datas = await _context.TicketRequests
        //.Where(p => p.Event.EventName.Contains(keyWvm.txtKeyword))
        //.ToListAsync();


        //            foreach (TicketRequest tr in datas)
        //            {
        //                TRListViewModel vm = new TRListViewModel();

        //                vm.TicketRequestId = tr.TicketRequestId;
        //                vm.eventName = tr.Event.EventName;
        //                vm.TRStatus = tr.RequestStatus;
        //                vm.ReleaseDate = tr.ReleaseDate;
        //                list.Add(vm);
        //            }
        //        }


        //        return View(list);
        //    }
        public async Task<IActionResult> List(CKeywordViewModel keyWvm)
        {
            List<TRListViewModel> list = new List<TRListViewModel>();

            var datas = await _context.TicketRequests
                .Include(t => t.Event)
                .Include(t => t.Member)
                .Include(t => t.Section)
                .Include(t => t.Show)
                .Include(t => t.Ticket).ToListAsync();
            if (string.IsNullOrEmpty(keyWvm.txtKeyword))
            {
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
            }
            else
            {

                datas = await _context.TicketRequests
    .Where(p => p.Event.EventName.Contains(keyWvm.txtKeyword))
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
            }

            return View(list);


        }


        private bool TicketRequestExists(int id)
        {
            return _context.TicketRequests.Any(e => e.TicketRequestId == id);
        }

        [HttpPost]
        // GET: TicketRequests
        public async Task<IActionResult> kwList(CKeywordViewModel keyWvm)
        {
            List<TRListViewModel> list = new List<TRListViewModel>();

            var datas = await _context.TicketRequests
                .Include(t => t.Event)
                .Include(t => t.Member)
                .Include(t => t.Section)
                .Include(t => t.Show)
                .Include(t => t.Ticket).ToListAsync();
            if (string.IsNullOrEmpty(keyWvm.txtKeyword))
            {
                foreach (TicketRequest tr in datas)
                {
                    TRListViewModel vm = new TRListViewModel();
                    vm.TicketRequestId = tr.TicketRequestId;
                    vm.eventName = tr.Event.EventName;
                    vm.TRStatus = tr.RequestStatus;
                    vm.ReleaseDate = tr.ReleaseDate;
                    list.Add(vm);

                }
            }
            else
            {
                Console.WriteLine("|| tr.Event.EventName.Contains(keyWvm.txtKeyword)");

            }
            //foreach (TicketRequest tr in datas)
            //{
            //    TRListViewModel vm = new TRListViewModel();

            //    // 如果有輸入關鍵字，檢查 EventName 是否包含該關鍵字
            //    if (string.IsNullOrEmpty(keyWvm.txtKeyword))
            //    {
            //        vm.TicketRequestId = tr.TicketRequestId;
            //        vm.eventName = tr.Event.EventName;
            //        vm.TRStatus = tr.RequestStatus;
            //        vm.ReleaseDate = tr.ReleaseDate;
            //        list.Add(vm);
            //    }
            //    else
            //    {
            //        // tr.Event.EventName.Contains(keyWvm.txtKeyword)
            //        Console.WriteLine("|| tr.Event.EventName.Contains(keyWvm.txtKeyword)");
            //    }
            //}


            return View(list);


        }

        // GET: TicketRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketRequest = await _context.TicketRequests
                .Include(t => t.Event)
                .Include(t => t.Member)
                .Include(t => t.Section)
                .Include(t => t.Show)
                .Include(t => t.Ticket).ToListAsync();
            string str = ticketRequest[0].Event.EventName;

            if (ticketRequest == null)
            {
                return NotFound();
            }

            return View(ticketRequest);
        }

        // GET: TicketRequests/Create
        public IActionResult Create()
        {


            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId");
            ViewData["MemberId"] = new SelectList(_context.Members, "MemberId", "MemberId");
            ViewData["SectionId"] = new SelectList(_context.Sections, "SectionId", "SectionId");
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId");
            ViewData["TicketId"] = new SelectList(_context.Tickets, "TicketId", "TicketId");
            return View();
        }

        // POST: TicketRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TicketRequestId,TicketCategoryId,MemberId,EventId,ShowId,TicketId,SectionId,QuantityRequest,SeatRangeS,SeatRangeE,RequestPrice,RequestStatus,ReleaseDate,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] TicketRequest ticketRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ticketRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", ticketRequest.EventId);
            ViewData["MemberId"] = new SelectList(_context.Members, "MemberId", "MemberId", ticketRequest.MemberId);
            ViewData["SectionId"] = new SelectList(_context.Sections, "SectionId", "SectionId", ticketRequest.SectionId);
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", ticketRequest.ShowId);
            ViewData["TicketId"] = new SelectList(_context.Tickets, "TicketId", "TicketId", ticketRequest.TicketId);
            return View(ticketRequest);
        }

        // GET: TicketRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketRequest = await _context.TicketRequests.FindAsync(id);
            if (ticketRequest == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", ticketRequest.EventId);
            ViewData["MemberId"] = new SelectList(_context.Members, "MemberId", "MemberId", ticketRequest.MemberId);
            ViewData["SectionId"] = new SelectList(_context.Sections, "SectionId", "SectionId", ticketRequest.SectionId);
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", ticketRequest.ShowId);
            ViewData["TicketId"] = new SelectList(_context.Tickets, "TicketId", "TicketId", ticketRequest.TicketId);
            return View(ticketRequest);
        }

        // POST: TicketRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicketRequestId,TicketCategoryId,MemberId,EventId,ShowId,TicketId,SectionId,QuantityRequest,SeatRangeS,SeatRangeE,RequestPrice,RequestStatus,ReleaseDate,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] TicketRequest ticketRequest)
        {
            if (id != ticketRequest.TicketRequestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticketRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketRequestExists(ticketRequest.TicketRequestId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", ticketRequest.EventId);
            ViewData["MemberId"] = new SelectList(_context.Members, "MemberId", "MemberId", ticketRequest.MemberId);
            ViewData["SectionId"] = new SelectList(_context.Sections, "SectionId", "SectionId", ticketRequest.SectionId);
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", ticketRequest.ShowId);
            ViewData["TicketId"] = new SelectList(_context.Tickets, "TicketId", "TicketId", ticketRequest.TicketId);
            return View(ticketRequest);
        }

        // GET: TicketRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketRequest = await _context.TicketRequests
                .Include(t => t.Event)
                .Include(t => t.Member)
                .Include(t => t.Section)
                .Include(t => t.Show)
                .Include(t => t.Ticket)
                .FirstOrDefaultAsync(m => m.TicketRequestId == id);
            if (ticketRequest != null)
            {
                _context.TicketRequests.Remove(ticketRequest);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("List");
        }

        // POST: TicketRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticketRequest = await _context.TicketRequests.FindAsync(id);
            if (ticketRequest != null)
            {
                _context.TicketRequests.Remove(ticketRequest);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("List");
        }


    }
}

