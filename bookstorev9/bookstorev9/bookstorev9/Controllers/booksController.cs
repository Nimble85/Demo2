using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using bookstorev9;
using bookstorev9.Models;

namespace bookstorev9.Controllers
{
    public class booksController : Controller
    {
        private readonly bookstorev9Context _context;

        public booksController(bookstorev9Context context)
        {
            _context = context;
        }

        // GET: books
        public async Task<IActionResult> Index()
        {
            return View(await _context.books.ToListAsync());
        }

        // GET: books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var books = await _context.books
                .FirstOrDefaultAsync(m => m.id == id);
            if (books == null)
            {
                return NotFound();
            }

            return View(books);
        }

        // GET: books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Author,Price")] books books)
        {
            if (ModelState.IsValid)
            {
                _context.Add(books);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(books);
        }

        // GET: books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var books = await _context.books.FindAsync(id);
            if (books == null)
            {
                return NotFound();
            }
            return View(books);
        }

        // POST: books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Author,Price")] books books)
        {
            if (id != books.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(books);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!booksExists(books.id))
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
            return View(books);
        }

        // GET: books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var books = await _context.books
                .FirstOrDefaultAsync(m => m.id == id);
            if (books == null)
            {
                return NotFound();
            }

            return View(books);
        }

        // POST: books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var books = await _context.books.FindAsync(id);
            _context.books.Remove(books);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool booksExists(int id)
        {
            return _context.books.Any(e => e.id == id);
        }
    }
}
