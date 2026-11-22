namespace LinkedListImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            LinkedList list = new LinkedList();
            Console.WriteLine("Празен списък:");
            list.Print();

            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            Console.WriteLine("\nСписък:");
            list.Print();

            Console.WriteLine("\nТърсене на 30:");
            Console.WriteLine(list.Contains(30));
            Console.WriteLine("\nТърсене на 50:");
            Console.WriteLine(list.Contains(50));

            Console.WriteLine("\nПремахване на 20:");
            list.Remove(20);
            list.Print();

            Console.WriteLine("\nПремахване на първия елемент:");
            list.Remove(10);
            list.Print();

            Console.WriteLine("\nПремахване на последния елемент:");
            list.Remove(40);
            list.Print();

            Console.WriteLine("\nПремахване на несъществуващ елемент (99):");
            list.Remove(99);
            list.Print();

            Console.WriteLine("\nПремахване на единствения елемент:");
            list.Remove(30);
            list.Print();

            Console.WriteLine("\nCount, AddFirst, Clear:");
            list.AddLast(2);
            list.AddFirst(1);
            list.AddLast(3);
            list.Print();
            Console.WriteLine("Count: " + list.Count());
            list.Clear();
            list.Print();
        }
    }
}
