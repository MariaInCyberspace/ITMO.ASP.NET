using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCCreditApp1.Models
{
    public class Bid
    {
        public virtual int BidId { get; set; }
        public virtual string Name { get; set; }
        [Display(Name = "Credit Head")]

        public virtual string CreditHead { get; set; }
        [Display(Name = "Bid Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]

        public virtual DateTime bidDate { get; set; }
    }
}