using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tasks.Data;
using Tasks.Models;

namespace Tasks.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Tasks.Data.TasksContext _context;

        public DeleteModel(Tasks.Data.TasksContext context)
        {
            _context = context;
        }

        [BindProperty]
        public taskDb taskDb { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            taskDb = await _context.taskDb.FirstOrDefaultAsync(m => m.Id == id);

            if (taskDb == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            taskDb = await _context.taskDb.FindAsync(id);

            if (taskDb != null)
            {
                _context.taskDb.Remove(taskDb);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
