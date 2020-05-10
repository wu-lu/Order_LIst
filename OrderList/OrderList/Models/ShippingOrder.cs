using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webtest.Models
{
    public class ShippingOrder
    {
        public string ID { get; set; }
        public string OrderID { get; set; }
        
        public string Status { get; set; }

        public DateTime CreatedDateTime { get; set; }
    }
}