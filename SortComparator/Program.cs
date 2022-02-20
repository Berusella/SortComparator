using System;

namespace SortComparator
{

    class Program
    {
        public static Stoper stoper = new Stoper();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to sort comparator \n1:full comparsion\n2:select sort");
            var line = Console.Read();
            switch (line)
            {
                case '1':
                    TableCreation table = new TableCreation();
                    var run = new Runner();

                    run.Run();
                    table.Create(stoper.times);
                    break;

                case '2':
                    Console.WriteLine("m - mergeSort\nq - quickSort\ns - shellSort\nc - combSort\n b - bucketSort\nn - babelekSort");
                    line = Console.Read();
                    switch (line)
                    {
                        case 'm':

                            break;
                        case 'q':

                            break;
                        case 's':

                            break;
                        case 'c':

                            break;
                        case 'b':

                            break;
                        case 'n':

                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("Thank you for using me UwU");
        }

    }
}
