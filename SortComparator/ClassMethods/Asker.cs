using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SortComparator
{
    class Asker
    {
        public int anwser;
        public int Ask()
        {
            Console.WriteLine("tell me how big table you want");
            var number = Console.ReadLine();
            Task getnumber = Task.Run(() =>
            {
                var number = Console.ReadLine();
                while (Int32.TryParse(number, out this.anwser) == false)
                {
                    number = Console.ReadLine();
                }
            }
            );
            getnumber.Wait();
            return this.anwser;
        }
    }
}
