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

        // search string contains text users enter into search box
        //[BindProperty] binds form values and query strings with the same name as property
        // SupportsGet = true is required for binding on GET requests
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Raptor != null)
            {
                var pos = from m in _context.Raptor select m;
                if(!string.IsNullOrEmpty(SearchString) )
                {
                    pos = pos.Where(s => s.PlayerPosition.Contains(SearchString));
                }
                Raptor = await pos.ToListAsync();
                //Raptor = await _context.Raptor.ToListAsync();
            }
        }
    }
}
