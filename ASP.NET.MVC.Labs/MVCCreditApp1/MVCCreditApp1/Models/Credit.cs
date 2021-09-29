using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCreditApp1.Models
{
    public class Credit
    {
        // Credit ID
         public virtual int CreditId { get; set; }
        // Name 
         public virtual string Head { get; set; }
        // Credit time frame 
         public virtual int Period { get; set; }
        // Max sum
         public virtual int Sum { get; set; }
        // Interest rate
         public virtual int Percent { get; set; }
    }
}
