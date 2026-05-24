
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KargoTakipSistemi.Models;
using KargoTakipSistemi.Data;

public class SubeController : Controller
{
    private readonly ApplicationDbContext _context;

    public SubeController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: SUBES
    public async Task<IActionResult> Index()
    {
        var subeler = _context.Subeler.Include(s => s.Kargolar);
        return View(await subeler.ToListAsync());
    }

    // GET: SUBES/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var sube = await _context.Subeler
            .FirstOrDefaultAsync(m => m.Id == id);
        if (sube == null)
        {
            return NotFound();
        }

        return View(sube);
    }

    // GET: SUBES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: SUBES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,SubeAdi,Sehir,Adres,Telefon,Kargolar")] Sube sube)
    {
        if (ModelState.IsValid)
        {
            _context.Add(sube);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(sube);
    }

    // GET: SUBES/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var sube = await _context.Subeler.FindAsync(id);
        if (sube == null)
        {
            return NotFound();
        }
        return View(sube);
    }

    // POST: SUBES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,SubeAdi,Sehir,Adres,Telefon,Kargolar")] Sube sube)
    {
        if (id != sube.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(sube);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubeExists(sube.Id))
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
        return View(sube);
    }

    // GET: SUBES/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var sube = await _context.Subeler
            .FirstOrDefaultAsync(m => m.Id == id);
        if (sube == null)
        {
            return NotFound();
        }

        return View(sube);
    }

    // POST: SUBES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var sube = await _context.Subeler.FindAsync(id);
        if (sube != null)
        {
            _context.Subeler.Remove(sube);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool SubeExists(int? id)
    {
        return _context.Subeler.Any(e => e.Id == id);
    }
}
