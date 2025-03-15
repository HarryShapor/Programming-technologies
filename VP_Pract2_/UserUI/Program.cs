using StudentsLibrary;
namespace UserUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new(100, "Алёна", "Табачкова", "Максимовна",
                new DateOnly(2004,09,08), "Рязань", "7-930-870-84-50");
            Student student2 = new(38, "Андрей", "Шапоренко", "Сергеевич",
                new DateOnly(2003, 12, 13), "Москва", "7-920-954-49-30");
            Student student3 = new(15, "Андрей", "Иваков", "Валерьевич",
                new DateOnly(2004, 09, 22), "Москва", "7-920-954-49-30");
            Student student4 = new(3, "Игорь", "Климкин", "Александрович",
                new DateOnly(2004, 06, 09), "Москва", "7-920-954-49-30");
            Student student5 = new(105, "Александр", "Шапоренко", "Сергеевич",
               new DateOnly(2010, 06, 01), "Москва", "7-920-954-49-30");
            Console.WriteLine("Работа метода ToString:\n" + student.ToString());
            Console.WriteLine("Работа метода Equals:\t" + student.Equals(student2));
            Group group246 = new Group(246);
            group246.Add(student4);
            group246.Add(student2);
            group246.Add(student3);
            group246.Add(student5);
            group246.Students[100] = student;
            Console.WriteLine("До сортировки");
            Console.WriteLine(group246.GetList());
            Console.WriteLine("После сортировки");
            Console.WriteLine(group246.GetInfo());
            group246.Remove(student);
            Console.WriteLine(group246.GetList());
        }
    }
}
