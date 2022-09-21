using CinemaVendas.Core.Models;
using CinemaVendas.Core.Repositores.Interfaces;
using CinemaVendas.Core.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaVendas.Core.Services
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _foodRepo;

        public FoodService(IFoodRepository foodRepo)
        {

        }

        public List<FoodItem> GetAllSold()
        {
            return _foodRepo.GetAllSold();
        }
    }
}
