using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KargoTakipSistemi.Models;
using KargoTakipSistemi.Data;

public class DurumKaydiController : Controller
{
    private readonly ApplicationDbContext _context;

    public DurumKaydiController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: DURUMKAYDIS
    public async Task<IActionResult> Index()
    {
        var durumKayitlari = _context.DurumKayitlari.Include(d => d.Kargo);
        return View(await durumKayitlari.ToListAsync());
    }

    // GET: DURUMKAYDIS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var durumkaydi = await _context.DurumKayitlari
            .Include(d => d.Kargo)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (durumkaydi == null)
        {
            return NotFound();
        }

        return View(durumkaydi);
    }

    // GET: DURUMKAYDIS/Create
    public IActionResult Create()
    {
        ViewData["KargoId"] = new SelectList(_context.Kargolar, "Id", "TakipNo");
        return View();
    }

    // POST: DURUMKAYDIS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Durum,Aciklama,Tarih,KargoId")] DurumKaydi durumKaydi)
    {
        if (ModelState.IsValid)
        {
            _context.Add(durumKaydi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        ViewData["KargoId"] = new SelectList(_context.Kargolar, "Id", "TakipNo", durumKaydi.KargoId);
        return View(durumKaydi);
    }

    // GET: DURUMKAYDIS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var durumKaydi = await _context.DurumKayitlari.FindAsync(id);
        if (durumKaydi == null)
        {
            return NotFound();
        }

        ViewData["KargoId"] = new SelectList(_context.Kargolar, "Id", "TakipNo", durumKaydi.KargoId);
        return View(durumKaydi);
    }

    // POST: DURUMKAYDIS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Durum,Aciklama,Tarih,KargoId,Kargo")] DurumKaydi durumkaydi)
    {
        if (id != durumkaydi.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(durumkaydi);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DurumKaydiExists(durumkaydi.Id))
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
        ViewData["KargoId"] = new SelectList(_context.Kargolar, "Id", "TakipNo", durumkaydi.KargoId);
        return View(durumkaydi);
    }

    // GET: DURUMKAYDIS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var durumkaydi = await _context.DurumKayitlari
            .Include(d => d.Kargo)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (durumkaydi == null)
        {
            return NotFound();
        }

        return View(durumkaydi);
    }

    // POST: DURUMKAYDIS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var durumkaydi = await _context.DurumKayitlari.FindAsync(id);
        if (durumkaydi != null)
        {
            _context.DurumKayitlari.Remove(durumkaydi);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool DurumKaydiExists(int? id)
    {
        return _context.DurumKayitlari.Any(e => e.Id == id);
    }
}
