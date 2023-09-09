using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RaptorsCoreRazor.Data;
using RaptorsCoreRazor.Models;

namespace RaptorsCoreRazor.Pages.Raptors
{
    public class IndexModel : PageModel
    {
        private readonly RaptorsCoreRazor.Data.RaptorsCoreRazorContext _context;

        public IndexModel(RaptorsCoreRazor.Data.RaptorsCoreRazorContext context)
        {
            _context = context;
        }

        public IList<Raptor> Raptor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Raptor != null)
            {
                Raptor = await _context.Raptor.ToListAsync();
            }
        }
    }
}
