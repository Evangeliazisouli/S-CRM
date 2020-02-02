using System;
using System.Collections.Generic;
using System.Text;

namespace S_CRM
{
    class Customer
    {
        public int CustomerId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Order> Order { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="LastName"></param>
        public Customer(string LastName) { }
    }
}
