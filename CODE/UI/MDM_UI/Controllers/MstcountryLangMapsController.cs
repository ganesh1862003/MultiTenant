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
    public class MstcountryLangMapsController : Controller
    {
        private readonly _DBMISSIONContext _context;

        public MstcountryLangMapsController(_DBMISSIONContext context)
        {
            _context = context;
        }

        // GET: MstcountryLangMaps
        public async Task<IActionResult> Index()
        {
            var _DBMISSIONContext = _context.MstcountryLangMap.Include(m => m.Country).Include(m => m.Language);
            return View(await _DBMISSIONContext.ToListAsync());
        }

        // GET: MstcountryLangMaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mstcountryLangMap = await _context.MstcountryLangMap
                .Include(m => m.Country)
                .Include(m => m.Language)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mstcountryLangMap == null)
            {
                return NotFound();
            }

            return View(mstcountryLangMap);
        }

        // GET: MstcountryLangMaps/Create
        public IActionResult Create()
        {
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Code");
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Name");
            return View();
        }

        // POST: MstcountryLangMaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CountryId,LanguageId,Name")] MstcountryLangMap mstcountryLangMap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mstcountryLangMap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Code", mstcountryLangMap.CountryId);
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Name", mstcountryLangMap.LanguageId);
            return View(mstcountryLangMap);
        }

        // GET: MstcountryLangMaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mstcountryLangMap = await _context.MstcountryLangMap.FindAsync(id);
            if (mstcountryLangMap == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Code", mstcountryLangMap.CountryId);
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Name", mstcountryLangMap.LanguageId);
            return View(mstcountryLangMap);
        }

        // POST: MstcountryLangMaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CountryId,LanguageId,Name")] MstcountryLangMap mstcountryLangMap)
        {
            if (id != mstcountryLangMap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mstcountryLangMap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MstcountryLangMapExists(mstcountryLangMap.Id))
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
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Code", mstcountryLangMap.CountryId);
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Name", mstcountryLangMap.LanguageId);
            return View(mstcountryLangMap);
        }

        // GET: MstcountryLangMaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mstcountryLangMap = await _context.MstcountryLangMap
                .Include(m => m.Country)
                .Include(m => m.Language)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mstcountryLangMap == null)
            {
                return NotFound();
            }

            return View(mstcountryLangMap);
        }

        // POST: MstcountryLangMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mstcountryLangMap = await _context.MstcountryLangMap.FindAsync(id);
            _context.MstcountryLangMap.Remove(mstcountryLangMap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MstcountryLangMapExists(int id)
        {
            return _context.MstcountryLangMap.Any(e => e.Id == id);
        }
    }
}
