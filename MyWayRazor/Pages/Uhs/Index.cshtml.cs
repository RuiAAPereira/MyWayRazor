﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWayRazor.Data;

namespace MyWayRazor.Pages.Uhs
{
    public class IndexModel : PageModel
    {
        private readonly MyWayRazor.Data.MywayDbContext _context;

        public IndexModel(MyWayRazor.Data.MywayDbContext context)
        {
            _context = context;
        }

        public IList<Uh> Uh { get;set; }

        public async Task OnGetAsync()
        {
            Uh = await _context.Uhs.ToListAsync();
        }
    }
}