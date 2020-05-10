using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webtest.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string Item { get; set; }
        public int Price { get; set; }
        public int Cost { get; set; }
        public bool Status { get; set; }
    }
}