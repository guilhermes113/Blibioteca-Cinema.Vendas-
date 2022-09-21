using CinemaVendas.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaVendas.Core.Repositores.Interfaces
{
    public  interface IFoodRepository
    {
        List<FoodItem> GetAllSold();
    }
}
