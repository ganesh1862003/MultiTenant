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
    public class LanguageMapsController : Controller
    {
        private readonly _DBMISSIONContext _context;

        public LanguageMapsController(_DBMISSIONContext context)
        {
            _context = context;
        }

        // GET: LanguageMaps
        public async Task<IActionResult> Index()
        {
            var _DBMISSIONContext = _context.LanguageMap.Include(l => l.CountryOps).Include(l => l.Language).Include(l => l.Mission).Include(l => l.UnitOps);
            return View(await _DBMISSIONContext.ToListAsync());
        }

        // GET: LanguageMaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languageMap = await _context.LanguageMap
                .Include(l => l.CountryOps)
                .Include(l => l.Language)
                .Include(l => l.Mission)
                .Include(l => l.UnitOps)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (languageMap == null)
            {
                return NotFound();
            }

            return View(languageMap);
        }

        // GET: LanguageMaps/Create
        public IActionResult Create()
        {
            ViewData["CountryOpsId"] = new SelectList(_context.CountryOfOperation, "Id", "Code");
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Name");
            ViewData["MissionId"] = new SelectList(_context.Mission, "Id", "Code");
            ViewData["UnitOpsId"] = new SelectList(_context.UnitOps, "Id", "Code");
            return View();
        }

        // POST: LanguageMaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LanguageId,MissionId,CountryOpsId,UnitOpsId")] LanguageMap languageMap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(languageMap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryOpsId"] = new SelectList(_context.CountryOfOperation, "Id", "Code", languageMap.CountryOpsId);
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Name", languageMap.LanguageId);
            ViewData["MissionId"] = new SelectList(_context.Mission, "Id", "Code", languageMap.MissionId);
            ViewData["UnitOpsId"] = new SelectList(_context.UnitOps, "Id", "Code", languageMap.UnitOpsId);
            return View(languageMap);
        }

        // GET: LanguageMaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languageMap = await _context.LanguageMap.FindAsync(id);
            if (languageMap == null)
            {
                return NotFound();
            }
            ViewData["CountryOpsId"] = new SelectList(_context.CountryOfOperation, "Id", "Code", languageMap.CountryOpsId);
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Name", languageMap.LanguageId);
            ViewData["MissionId"] = new SelectList(_context.Mission, "Id", "Code", languageMap.MissionId);
            ViewData["UnitOpsId"] = new SelectList(_context.UnitOps, "Id", "Code", languageMap.UnitOpsId);
            return View(languageMap);
        }

        // POST: LanguageMaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LanguageId,MissionId,CountryOpsId,UnitOpsId")] LanguageMap languageMap)
        {
            if (id != languageMap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(languageMap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LanguageMapExists(languageMap.Id))
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
            ViewData["CountryOpsId"] = new SelectList(_context.CountryOfOperation, "Id", "Code", languageMap.CountryOpsId);
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Name", languageMap.LanguageId);
            ViewData["MissionId"] = new SelectList(_context.Mission, "Id", "Code", languageMap.MissionId);
            ViewData["UnitOpsId"] = new SelectList(_context.UnitOps, "Id", "Code", languageMap.UnitOpsId);
            return View(languageMap);
        }

        // GET: LanguageMaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languageMap = await _context.LanguageMap
                .Include(l => l.CountryOps)
                .Include(l => l.Language)
                .Include(l => l.Mission)
                .Include(l => l.UnitOps)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (languageMap == null)
            {
                return NotFound();
            }

            return View(languageMap);
        }

        // POST: LanguageMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var languageMap = await _context.LanguageMap.FindAsync(id);
            _context.LanguageMap.Remove(languageMap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LanguageMapExists(int id)
        {
            return _context.LanguageMap.Any(e => e.Id == id);
        }
    }
}
