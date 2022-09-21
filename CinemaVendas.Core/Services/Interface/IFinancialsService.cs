using CinemaVendas.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaVendas.Core.Services.Interface
{
    public interface IFinancialsService
    {
        decimal GetTotalSold();
        FinancialStats GetStats();
    }
}
