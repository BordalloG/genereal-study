using System;

namespace RecursiveCountLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = GenerateALinkedList();
            Console.WriteLine(Count(list));
        }

        static int Count(LinkedList<int> list)
        {
            if (list == null)
                return 0;

            return Count(list.Next) + 1;
        }

        static LinkedList<int> GenerateALinkedList()
        {
            return new LinkedList<int>()
            {
                Value = 1,
                Next = new LinkedList<int>()
                {
                    Value = 2,
                    Next = new LinkedList<int>()
                    {
                        Value = 3,
                        Next = new LinkedList<int>()
                        {
                            Value = 4,
                            Next = new LinkedList<int>()
                            {
                                Value = 5,
                                Next = null
                            }
                        }
                    }
                }
            };
        }


    }
}
