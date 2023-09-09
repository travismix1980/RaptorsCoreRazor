using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RaptorsCoreRazor.Data;
using RaptorsCoreRazor.Models;

namespace RaptorsCoreRazor.Pages.Raptors
{
    public class CreateModel : PageModel
    {
        private readonly RaptorsCoreRazor.Data.RaptorsCoreRazorContext _context;

        public CreateModel(RaptorsCoreRazor.Data.RaptorsCoreRazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Raptor Raptor { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Raptor == null || Raptor == null)
            {
                return Page();
            }

            _context.Raptor.Add(Raptor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
