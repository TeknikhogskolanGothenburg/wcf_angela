using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalService
{
    public class ContractCustomer: Customer
    {
        public Decimal Discount { get; set; }
    }
}
