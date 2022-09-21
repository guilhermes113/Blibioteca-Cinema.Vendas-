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
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;
        public FoodController(IFoodService foodservice)
        {
            _foodService = foodservice;
        }
        public IActionResult GetTicket()
        {
            return Ok(_foodService.GetAllSold());
        }
    }
}
