using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MDM_UI.Models;

namespace MDM_UI.Controllers
{
    public class MstcountryMapsController : Controller
    {
        private readonly _DBMISSIONContext _context;

        public MstcountryMapsController(_DBMISSIONContext context)
        {
            _context = context;
        }

        // GET: MstcountryMaps
        public async Task<IActionResult> Index()
        {
            var _DBMISSIONContext = _context.MstcountryMap.Include(m => m.Country).Include(m => m.CountryOps).Include(m => m.Mission).Include(m => m.UnitOps);
            return View(await _DBMISSIONContext.ToListAsync());
        }

        // GET: MstcountryMaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mstcountryMap = await _context.MstcountryMap
                .Include(m => m.Country)
                .Include(m => m.CountryOps)
                .Include(m => m.Mission)
                .Include(m => m.UnitOps)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mstcountryMap == null)
            {
                return NotFound();
            }

            return View(mstcountryMap);
        }

        // GET: MstcountryMaps/Create
        public IActionResult Create()
        {
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Name");
            ViewData["CountryOpsId"] = new SelectList(_context.CountryOfOperation, "Id", "Name");
            ViewData["MissionId"] = new SelectList(_context.Mission, "Id", "Name");
            ViewData["UnitOpsId"] = new SelectList(_context.UnitOps, "Id", "Name");
            return View();
        }

        // POST: MstcountryMaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CountryId,MissionId,CountryOpsId,UnitOpsId")] MstcountryMap mstcountryMap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mstcountryMap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Name", mstcountryMap.CountryId);
            ViewData["CountryOpsId"] = new SelectList(_context.CountryOfOperation, "Id", "Name", mstcountryMap.CountryOpsId);
            ViewData["MissionId"] = new SelectList(_context.Mission, "Id", "Name", mstcountryMap.MissionId);
            ViewData["UnitOpsId"] = new SelectList(_context.UnitOps, "Id", "Name", mstcountryMap.UnitOpsId);
            return View(mstcountryMap);
        }

        // GET: MstcountryMaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mstcountryMap = await _context.MstcountryMap.FindAsync(id);
            if (mstcountryMap == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Name", mstcountryMap.CountryId);
            ViewData["CountryOpsId"] = new SelectList(_context.CountryOfOperation, "Id", "Name", mstcountryMap.CountryOpsId);
            ViewData["MissionId"] = new SelectList(_context.Mission, "Id", "Name", mstcountryMap.MissionId);
            ViewData["UnitOpsId"] = new SelectList(_context.UnitOps, "Id", "Name", mstcountryMap.UnitOpsId);
            return View(mstcountryMap);
        }

        // POST: MstcountryMaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CountryId,MissionId,CountryOpsId,UnitOpsId")] MstcountryMap mstcountryMap)
        {
            if (id != mstcountryMap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mstcountryMap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MstcountryMapExists(mstcountryMap.Id))
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
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Name", mstcountryMap.CountryId);
            ViewData["CountryOpsId"] = new SelectList(_context.CountryOfOperation, "Id", "Name", mstcountryMap.CountryOpsId);
            ViewData["MissionId"] = new SelectList(_context.Mission, "Id", "Name", mstcountryMap.MissionId);
            ViewData["UnitOpsId"] = new SelectList(_context.UnitOps, "Id", "Name", mstcountryMap.UnitOpsId);
            return View(mstcountryMap);
        }

        // GET: MstcountryMaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mstcountryMap = await _context.MstcountryMap
                .Include(m => m.Country)
                .Include(m => m.CountryOps)
                .Include(m => m.Mission)
                .Include(m => m.UnitOps)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mstcountryMap == null)
            {
                return NotFound();
            }

            return View(mstcountryMap);
        }

        // POST: MstcountryMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mstcountryMap = await _context.MstcountryMap.FindAsync(id);
            _context.MstcountryMap.Remove(mstcountryMap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MstcountryMapExists(int id)
        {
            return _context.MstcountryMap.Any(e => e.Id == id);
        }
    }
}
