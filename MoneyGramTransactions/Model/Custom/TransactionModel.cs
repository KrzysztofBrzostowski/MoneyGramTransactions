using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Custom
{
    class TransactionModel
    {
        public string CurrencySymbol { get; set; }
        public Model.Customer Customer { get; set; }
        public decimal Amount { get; set; }
    }
}
