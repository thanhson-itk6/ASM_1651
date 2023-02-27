using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    public class Cash : Payment
    {
        public int cashTendered;

        public Cash(int cashTendered, int ammount)
        {
            this.cashTendered = cashTendered;
            this.ammount = ammount;
        }

        public override string? ToString()
        {
            return $"Ammount: {ammount} Cash:{cashTendered}, Change:{cashTendered - ammount} ";
        }
    }
}
