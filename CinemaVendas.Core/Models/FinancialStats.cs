using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaVendas.Core.Models
{
    public class FinancialStats
    {
        [DisplayName("Avg. Ticket Profit: ")]
        [DataType(DataType.Currency)]
        public decimal AverageTicketProfit { get; set; }

        [DisplayName("Avg. Food Item Profit: ")]
        [DataType(DataType.Currency)]
        public decimal AverageFoodItemProfit { get; set; }
    }
}
