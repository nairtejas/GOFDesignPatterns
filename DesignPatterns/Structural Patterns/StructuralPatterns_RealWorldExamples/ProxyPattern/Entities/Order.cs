﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<OrderDetail> Details { get; set; }
    }
}
