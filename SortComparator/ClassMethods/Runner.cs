using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class Runner
    {
        public static double max_B = 0;
        public void Run()
        {
            var randomNumbers = new QuanInizalition();
            var call = new DoubleTrouble();
            var quan = randomNumbers.Quan(200);
            var yourChoice = new Asker();
            var anwser = yourChoice.Ask();

            call.caller(quan, 0);
            quan = randomNumbers.Quan(500);
            call.caller(quan, 1);
            quan = randomNumbers.Quan(1000);
            call.caller(quan, 2);
            quan = randomNumbers.Quan(anwser);
            call.caller(quan, 3);
        }
    }
}
