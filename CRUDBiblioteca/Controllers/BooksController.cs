using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUDBiblioteca.Models;

namespace CRUDBiblioteca.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookContext _context;

        public BooksController(BookContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
              return _context.Books != null ? 
                          View(await _context.Books.ToListAsync()) :
                          Problem("Entity set 'BookContext.Books'  is null.");
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Books/CreateOrEdit
        public IActionResult CreateOrEdit(int id=0)
        {
            if (id == 0) 
                return View(new Book());
            else
                return View(_context.Books.Find(id));
            
        }

        // POST: Books/CreateOrEdit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrEdit([Bind("BookId,Title,Author,Genre,Classification,NumPages,Edition")] Book book)
        {
            if (ModelState.IsValid)
            {
                if (book.BookId == 0)
                    _context.Add(book);
                else
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (_context.Books == null)
            {
                return Problem("Entity set 'BookContext.Books'  is null.");
            }
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
