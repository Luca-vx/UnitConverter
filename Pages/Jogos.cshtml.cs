using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace UnitConverter.Pages
{
    public class Jogos : PageModel
    {
        private readonly ILogger<Jogos> _logger;

        public Jogos(ILogger<Jogos> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}