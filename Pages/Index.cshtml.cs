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
    public class IndexModel : PageModel
    {
        private readonly Tasks.Data.TasksContext _context;

        public IndexModel(Tasks.Data.TasksContext context)
        {
            _context = context;
        }

        public IList<taskDb> taskDb { get;set; }

        public async Task OnGetAsync()
        {
            taskDb = await _context.taskDb.ToListAsync();
        }
    }
}
