namespace Homework_Class04
{
    public class PrintInConsole
    {
        public void Print<T>(T item)
        {
            Console.WriteLine(item);
        }
        public void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

