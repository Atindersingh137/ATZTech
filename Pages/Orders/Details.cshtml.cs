using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ATZTech.Data;
using ATZTech.Models;

namespace ATZTech.Pages.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly ATZTech.Data.ATZTechContext _context;

        public DetailsModel(ATZTech.Data.ATZTechContext context)
        {
            _context = context;
        }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order
                .Include(o => o.Product)
                .Include(o => o.User).FirstOrDefaultAsync(m => m.ID == id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
