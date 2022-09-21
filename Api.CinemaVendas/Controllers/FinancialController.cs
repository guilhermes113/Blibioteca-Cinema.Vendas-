using CinemaVendas.Core.Services;
using CinemaVendas.Core.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.CinemaVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialController : ControllerBase
    {
        private readonly IFinancialsService _financialsService;
        public FinancialController(IFinancialsService financialsService)
        {
            _financialsService = financialsService;
        }
        public IActionResult GetTotalSold()
        {
            return Ok(_financialsService.GetTotalSold());
        }
        
        
    }
}
