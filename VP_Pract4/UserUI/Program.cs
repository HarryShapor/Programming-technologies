using CollectionLibrary;
namespace UserUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DynamicArray<int> array = new DynamicArray<int>();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            Console.WriteLine("Параметр Capacity:");
            Console.WriteLine(array.Capacity);
            Console.WriteLine("Коллекция:");
            Console.WriteLine(array.ToString());
            Console.WriteLine("Параметр Count:");
            Console.WriteLine(array.Count);
            array.IncreaseCapacity(300);
            Console.WriteLine("Параметр Capacity после увеличения:");
            Console.WriteLine(array.Capacity);
            array.RemoveAt(3);
            Console.WriteLine("Коллекция после удаления элемента:");
            Console.WriteLine(array.ToString());
            Console.WriteLine("Параметр Count после удаления элемента:");
            Console.WriteLine(array.Count);
            array.Insert(15,2);
            Console.WriteLine("Коллекция после добавления элемента по позиции:");
            Console.WriteLine(array.ToString());
            Console.WriteLine("Параметр Count после добавления элемента по позиции:");
            Console.WriteLine(array.Count);
            List<int> elements = new List<int> { 33, 13, 69 };
            array.Add(elements);
            Console.WriteLine("Коллекция после добавления коллекции:");
            Console.WriteLine(array.ToString());
            Console.WriteLine("Параметр Count после добавления коллекции:");
            Console.WriteLine(array.Count);
        }
    }
}
