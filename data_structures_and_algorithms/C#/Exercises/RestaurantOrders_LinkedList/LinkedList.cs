using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrders_LinkedList
{
    public class LinkedList<T>
    {
        public T Value { get; set; }
        public LinkedList<T> Next { get; set; }
    }
}
