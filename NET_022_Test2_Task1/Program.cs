namespace NET_022_Test2_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestCollection<int> collection = new TestCollection<int>();

            collection.AddItem(12);
            collection.AddItem(21);
                
            collection.AddItem(3);
            collection.AddItem(43);
                
            collection.AddItem(5);
            collection.AddItem(6);

            Console.WriteLine($"The third item is {collection.GetItem(3)}");
            
            var sortedcoll = collection.GetDescSorted();

            for (int i = 0; i < sortedcoll.Count; i++) Console.WriteLine(sortedcoll[i]);

            Console.WriteLine();
        }
    }
}