using Utilities;
using System;

namespace Application
{

    public class Car
    {
        public int Amount { get; set; }
        public Car(int amount)
        {
            Amount = amount;
        }
    }
    class Program
    {
        public static void Test(ref int a)
        {
            a++;

        }
        public static void Test2(Car car)
        {
            car = new Car(4);
            // car.Amount = 4;

        }
        #region IList<T>
        public static void CallMyListGeneric()
        {
            var test = new MyList<string>();

            // Populate the List.
            Console.WriteLine("Populate the List");
            test.Add("one");
            test.Add("two");
            test.Add("three");
            test.Add("four");
            test.Add("five");
            test.Add("six");
            test.Add("seven");
            test.Add("eight");
            test.PrintContents();
            Console.WriteLine();

            // Remove elements from the list.
            Console.WriteLine("Remove elements from the list");
            test.Remove("six");
            test.Remove("eight");
            test.PrintContents();
            Console.WriteLine();

            // Add an element to the end of the list.
            Console.WriteLine("Add an element to the end of the list");
            test.Add("nine");
            test.PrintContents();
            Console.WriteLine();

            // Insert an element into the middle of the list.
            Console.WriteLine("Insert an element into the middle of the list");
            test.Insert(5, "number");
            test.PrintContents();
            Console.WriteLine();

            // Check for specific elements in the list.
            Console.WriteLine("Check for specific elements in the list");
            Console.WriteLine($"List contains \"three\": {test.Contains("three")}");
            Console.WriteLine($"List contains \"ten\": {test.Contains("ten")}");

            //test.Clear();
            Console.WriteLine("Copy To method");
            var array = new string[9];
            test.CopyTo(array, 0);
            test.PrintContents();
            Console.WriteLine();
        }
        public static void CallMyListGenericWithClasses()
        {
            var test = new MyList<Employee>();
            var employee1 = new Employee("Mohamed","Hrizi","123");
            var employee2 = new Employee("Maria", "Roussou", "456");
            var employee3 = new Employee("Jack", "Bouzard", "789");
            // Populate the List.
            Console.WriteLine("Populate the List");
            test.Add(employee1);
            test.Add(employee2);
            test.Add(employee1);
            test.Add(employee3);
            test.PrintContents();
            Console.WriteLine();

            // Remove elements from the list.
            Console.WriteLine("Remove elements from the list");
            test.Remove(employee1);
            test.Remove(employee2);
            test.PrintContents();
            Console.WriteLine();

            // Add an element to the end of the list.
            Console.WriteLine("Add an element to the end of the list");
            test.Add(employee2);
            test.PrintContents();
            Console.WriteLine();

            // Insert an element into the middle of the list.
            Console.WriteLine("Insert an element into the middle of the list");
            test.Insert(5, employee3);
            test.PrintContents();
            Console.WriteLine();

            // Check for specific elements in the list.
            Console.WriteLine("Check for specific elements in the list");
            Console.WriteLine($"List contains \"three\": {test.Contains(employee2)}");
            Console.WriteLine($"List contains \"ten\": {test.Contains(employee3)}");

            //test.Clear();
            Console.WriteLine("Copy To method");
            var array = new Employee[9];
            test.CopyTo(array, 0);
            test.PrintContents();
            Console.WriteLine();
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 3;
            Test(ref x);
            Console.WriteLine(x);
            Car car = new Car(3);
            Test2(car);
            Console.WriteLine(car.Amount);
            CallMyListGeneric();
            CallMyListGenericWithClasses();
            Console.ReadLine();

        }
    }
}
