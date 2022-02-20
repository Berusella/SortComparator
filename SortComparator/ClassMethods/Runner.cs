using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace SortComparator
{
    class Runner
    {
        public int anwser;
        public static double max_B = 0;
        public void Run()
        {
            var randomNumbers = new QuanInizalition();
            var call = new DoubleTrouble();
            var quan = randomNumbers.Quan(200);

            Console.WriteLine("tell me how big table you want");
            var number = Console.ReadLine();
            Task getnumber = Task.Run(() =>
            {
                Console.WriteLine("tell me how big table you want");
                var number = Console.ReadLine();
                if (Int32.TryParse(number, out this.anwser) == false)
                {
                    return;
                }
            }
            );
            getnumber.Wait();

            call.caller(quan, 0);
            quan = randomNumbers.Quan(500);
            call.caller(quan, 1);
            quan = randomNumbers.Quan(1000);
            call.caller(quan, 2);
            quan = randomNumbers.Quan(this.anwser);
            call.caller(quan, 3);
        }
    }
}
