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
    public class IndexModel : PageModel
    {
        private readonly ATZTech.Data.ATZTechContext _context;

        public IndexModel(ATZTech.Data.ATZTechContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order
                .Include(o => o.Product)
                .Include(o => o.User).ToListAsync();
        }
    }
}
