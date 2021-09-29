using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 

namespace MVCCreditApp1.Models
{
    public class CreditsDbInitializer : DropCreateDatabaseIfModelChanges<CreditContext>
    {
        protected override void Seed(CreditContext context)
        {
            context.Credits.Add(new Credit { Head = "Mortgage loan", Period = 10, Sum = 1000000, Percent = 3 });
            context.Credits.Add(new Credit { Head = "College loan", Period = 7, Sum = 300000, Percent = 3 });
            context.Credits.Add(new Credit { Head = "Consumer loan", Period = 3, Sum = 500000, Percent = 3 });
            base.Seed(context);
        }
    }
}