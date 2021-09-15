using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aqua_Project.Models.WorkModels;

namespace Aqua_Project.Controllers
{
    public class BusinessActivtiysController : Controller
    {
        private readonly WorkContext _context;

        public BusinessActivtiysController(WorkContext context)
        {
            _context = context;
        }

        // GET: BusinessActivtiys
        public async Task<IActionResult> Index()
        {
            var workContext = _context.BusinessActivtiy.Include(b => b.Company);
            return View(await workContext.ToListAsync());
        }

        // GET: BusinessActivtiys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessActivtiy = await _context.BusinessActivtiy
                .Include(b => b.Company)
                .FirstOrDefaultAsync(m => m.BusinessId == id);
            if (businessActivtiy == null)
            {
                return NotFound();
            }

            return View(businessActivtiy);
        }

        // GET: BusinessActivtiys/Create
        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "CompanyName");
            return View();
        }

        // POST: BusinessActivtiys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BusinessId,ActivityName,CompanyId")] BusinessActivtiy businessActivtiy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(businessActivtiy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "Branch", businessActivtiy.CompanyId);
            return View(businessActivtiy);
        }

        // GET: BusinessActivtiys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessActivtiy = await _context.BusinessActivtiy.FindAsync(id);
            if (businessActivtiy == null)
            {
                return NotFound();
            }
            ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "Branch", businessActivtiy.CompanyId);
            return View(businessActivtiy);
        }

        // POST: BusinessActivtiys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BusinessId,ActivityName,CompanyId")] BusinessActivtiy businessActivtiy)
        {
            if (id != businessActivtiy.BusinessId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(businessActivtiy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusinessActivtiyExists(businessActivtiy.BusinessId))
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
            ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "Branch", businessActivtiy.CompanyId);
            return View(businessActivtiy);
        }

        // GET: BusinessActivtiys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessActivtiy = await _context.BusinessActivtiy
                .Include(b => b.Company)
                .FirstOrDefaultAsync(m => m.BusinessId == id);
            if (businessActivtiy == null)
            {
                return NotFound();
            }

            return View(businessActivtiy);
        }

        // POST: BusinessActivtiys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var businessActivtiy = await _context.BusinessActivtiy.FindAsync(id);
            _context.BusinessActivtiy.Remove(businessActivtiy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BusinessActivtiyExists(int id)
        {
            return _context.BusinessActivtiy.Any(e => e.BusinessId == id);
        }
    }
}
