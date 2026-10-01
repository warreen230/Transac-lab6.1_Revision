using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PresseMots.Models;
using PresseMots.Models.Data;

namespace PresseMots.Controllers
{
    public class TagsController : Controller
    {
        private readonly PresseMotsDbContext _context;

        public TagsController(PresseMotsDbContext context)
        {
            _context = context;
        }

        // GET: Tags
        public async Task<IActionResult> Index()
        {
              return View(/*...*/);
        }

        // GET: Tags/Create
        public IActionResult Create()
        {
            Tag tag = new Tag();
            return View(tag);
        }

        // POST: Tags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Object model,[Bind("Id,Name")] Tag tag)
        {
            if (ModelState.IsValid)
            {
                _context.tags.Add(tag);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tag);
        }

        // GET: Tags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            Tag? tag = _context.tags.Find(id);
            if(tag == null)
            {
                return NotFound();
            }

            return View(tag);
        }

        // POST: Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Tag? tag = _context.tags.Find(id);
            if(tag == null)
            {
                return NotFound();
            }
            _context.tags.Remove(tag);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
