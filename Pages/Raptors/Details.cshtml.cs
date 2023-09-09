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
    public class DetailsModel : PageModel
    {
        private readonly RaptorsCoreRazor.Data.RaptorsCoreRazorContext _context;

        public DetailsModel(RaptorsCoreRazor.Data.RaptorsCoreRazorContext context)
        {
            _context = context;
        }

      public Raptor Raptor { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Raptor == null)
            {
                return NotFound();
            }

            var raptor = await _context.Raptor.FirstOrDefaultAsync(m => m.Id == id);
            if (raptor == null)
            {
                return NotFound();
            }
            else 
            {
                Raptor = raptor;
            }
            return Page();
        }
    }
}
