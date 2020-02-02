using System;
using System.Collections.Generic;
using System.Text;

namespace S_CRM
{
    class Order
    {
        public bool TotalAmount { get; internal set; }
        public object ProductList { get; internal set; }

        ProductList = new List<Product>();
    }
    /// <summary>
    /// 
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public decimal TotalAmount { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string DeliveryAddress { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<Product> ProductList { get; set; }
}
}
