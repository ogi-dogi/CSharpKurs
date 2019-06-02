using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];
            Console.WriteLine("Hello World! " + name);
            Console.WriteLine();

            //foreach (var item in args)
            //{
            //    Console.WriteLine("witaj " + item);
            //}
            
        }
    }
}

/*using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {



                Console.Write("Wpisz swoje imię ");
                string name = Console.ReadLine();
                //string name = args[0];
                Console.WriteLine("Hello " + name);

                Console.Write("Wpisz ile masz lat ");

                int age;
                bool result = int.TryParse(Console.ReadLine(), out age);

                if (age > 18)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Brawo! JEsteś pełnoletni, możesz wypić browara");
                }
                else if (result == false)
                {
                    Console.WriteLine("Wprowadziłeś niepoprawny wiek, popraw to!");
                }
                else
                {
                    Console.WriteLine("Możemy Ci zaoferować mleko");
                }

                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();
            }

            //foreach (var item in args)
            //{
            //    Console.WriteLine("hello " + item);
            //}
        }
    }
} */
