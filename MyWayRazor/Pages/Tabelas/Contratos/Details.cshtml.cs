﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWayRazor.Data;
using MyWayRazor.Models;

namespace MyWayRazor.Pages.Tabelas.Contratos
{
    public class DetailsModel : PageModel
    {
        private readonly MyWayRazor.Data.MywayDbContext _context;

        public DetailsModel(MyWayRazor.Data.MywayDbContext context)
        {
            _context = context;
        }

        public Contrato Contrato { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contrato = await _context.Contratos.FirstOrDefaultAsync(m => m.ContratoId == id);

            if (Contrato == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}