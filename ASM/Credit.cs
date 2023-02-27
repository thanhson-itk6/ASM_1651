using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
   public class Credit : Payment
    {
        public int number;
        public string type;
        public DateTime expDate;
        public Credit(int number, string type, string expDate, int ammount)
        {
            this.number = number;
            this.type = type;
            try
            {
                DateTime expDate_dt = DateTime.ParseExact(expDate, "dd-MM-yyyy",
                                           System.Globalization.CultureInfo.InvariantCulture);
                this.expDate = expDate_dt;

            }
            catch { throw new("date ERROR"); }
            this.ammount = ammount;

        }
        public override string? ToString()
        {
            return $"Credit: {ammount}";
        }
    }
}
