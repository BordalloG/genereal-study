using System;
using System.Collections.Generic;
using System.Text;

namespace RecursiveCountLinkedList
{
    public class LinkedList<T>
    {
        public T Value { get; set; }
        public LinkedList<T> Next { get; set; }
    }
}
