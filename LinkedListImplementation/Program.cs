namespace LinkedListImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Print();          
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.Print();
        }
    }
}
