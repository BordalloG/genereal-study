using System;

namespace RestaurantOrders_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> head = null;
            LinkedList<string> tail = null;
            int resp;
            do
            {
                Console.WriteLine("1 - Place a new order.");
                Console.WriteLine("2 - Get an order.");
                Console.WriteLine("3 - List all orders.");
                Console.WriteLine("4 - Exit.");
                resp = int.Parse(Console.ReadLine());
                switch (resp) {
                    case 1:
                        PlaceOrder(ref head, ref tail);
                        break;
                    case 2:
                        GetOrder(ref head);
                        break;
                    case 3:
                        PrintAllOrders(head);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Not Valid Option, Try Again");
                        break;
                }

            } while (resp != 4);
        }

        static void PlaceOrder(ref LinkedList<string> head, ref LinkedList<string> tail) // O(1)
        {
            Console.WriteLine("What is the order?");
            var value = Console.ReadLine();

            if (head == null)
            {
                head = new LinkedList<string> { Next = null, Value = value };
                tail = head;
            }
            
            else
            {
                tail.Next = new LinkedList<string>() { Value = value, Next = null };
                tail = tail.Next;
            }
        }
        static void GetOrder(ref LinkedList<string> head) // O(1)
        {
            if (head == null)
            {
                Console.WriteLine("\nThere's not orders avaliable\n");
                return;
            }
            var order = head.Value;
            head = head.Next;

            Console.WriteLine($"Your order is: {order}");
        }

        static void PrintAllOrders(LinkedList<string> head) // O(n)
        {
            var t = head;
            if (t == null) { Console.WriteLine("\nThere's not orders avaliable\n"); return; }
            while(t != null)
            {
                Console.WriteLine(t.Value);
                t = t.Next;
            }
        }
    }
}
