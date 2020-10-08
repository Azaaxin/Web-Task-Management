using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tasks.Data;
using Tasks.Models;

namespace Tasks.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Tasks.Data.TasksContext _context;

        public CreateModel(Tasks.Data.TasksContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public taskDb taskDb { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.taskDb.Add(taskDb);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
