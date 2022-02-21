using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class Runner
    {
        public void Run()
        {
            var call = new DoubleTrouble();
            var yourChoice = new Asker();
            var anwser = yourChoice.Ask();

            call.caller(new QuanInizalition(200), 0);
            call.caller(new QuanInizalition(500), 1);
            call.caller(new QuanInizalition(1000), 2);
            call.caller(new QuanInizalition(anwser), 3);
        }
    }
}
