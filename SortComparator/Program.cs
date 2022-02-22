using System;

namespace SortComparator
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to sort comparator \n1:full comparsion\n2:select sort");
            var line = Console.Read();
            switch (line)
            {
                case '1':
                    var run = new Runner();
                    run.Run();
                    break;

                case '2':
                    var select = new SpecialSelect();
                    select.Start();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Thank you for using me UwU");
        }

    }
}
