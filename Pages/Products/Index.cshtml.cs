using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ATZTech.Data;
using ATZTech.Models;

namespace ATZTech.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ATZTech.Data.ATZTechContext _context;

        public IndexModel(ATZTech.Data.ATZTechContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
