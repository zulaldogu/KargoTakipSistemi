using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KargoTakipSistemi.Models;
using KargoTakipSistemi.Data;

public class KargoController : Controller
{
    private readonly ApplicationDbContext _context;

    public KargoController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: KARGOS
    public async Task<IActionResult> Index()
    {
        var kargolar = _context.Kargolar.Include(k => k.Sube);
        return View(await kargolar.ToListAsync());
    }

    // GET: KARGOS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var kargo = await _context.Kargolar
            .Include(k => k.Sube)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (kargo == null)
        {
            return NotFound();
        }

        return View(kargo);
    }

    // GET: KARGOS/Create
    public IActionResult Create()
    {
        ViewData["SubeId"] = new SelectList(_context.Subeler, "Id", "SubeAdi");
        return View();
    }

    // POST: KARGOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,TakipNo,GondericiAd,AliciAd,AliciAdres,GonderimTarihi,TeslimTarihi,SubeId")] Kargo kargo)
    {
        if (ModelState.IsValid)
        {
            _context.Add(kargo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        ViewData["SubeId"] = new SelectList(_context.Subeler, "Id", "SubeAdi", kargo.SubeId);
        return View(kargo);
    }

    // GET: KARGOS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var kargo = await _context.Kargolar.FindAsync(id);
        if (kargo == null)
        {
            return NotFound();
        }

        ViewData["SubeId"] = new SelectList(_context.Subeler, "Id", "SubeAdi", kargo.SubeId);
        return View(kargo);
    }

    // POST: KARGOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,TakipNo,GondericiAd,AliciAd,AliciAdres,GonderimTarihi,TeslimTarihi,SubeId,Sube,DurumKayitlari")] Kargo kargo)
    {
        if (id != kargo.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(kargo);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KargoExists(kargo.Id))
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
        ViewData["SubeId"] = new SelectList(_context.Subeler, "Id", "SubeAdi", kargo.SubeId);
        return View(kargo);
    }

    // GET: KARGOS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var kargo = await _context.Kargolar
            .Include(k => k.Sube)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (kargo == null)
        {
            return NotFound();
        }

        return View(kargo);
    }

    // POST: KARGOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var kargo = await _context.Kargolar.FindAsync(id);
        if (kargo != null)
        {
            _context.Kargolar.Remove(kargo);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool KargoExists(int? id)
    {
        return _context.Kargolar.Any(e => e.Id == id);
    }
    public async Task<IActionResult> Sorgula(string takipNo)
    {
        if (string.IsNullOrWhiteSpace(takipNo))
        {
            return View();
        }

        var kargo = await _context.Kargolar
            .Include(k => k.Sube)
            .Include(k => k.DurumKayitlari)
            .FirstOrDefaultAsync(k => k.TakipNo == takipNo);

        if (kargo == null)
        {
            ViewBag.Mesaj = "Bu takip numarasına ait kargo bulunamadı.";
            return View();
        }

        return View(kargo);
    }
}
