using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class Runner
    {
        public void Run()
        {
            var methods = new List<SortMethod>() {
                new SortMethod("merge",new Merge()),
                new SortMethod("bubble",new Bubble()),
                new SortMethod("quick",new Quick()),
                new SortMethod("shell",new Shell()),
                new SortMethod("bucket",new Bucket()),
                new SortMethod("comb",new Comb()),
            };
            var call = new DoubleTrouble();
            var yourChoice = new Asker();
            var anwser = yourChoice.Ask();

            call.Caller(new QuanInizalition(200), methods);
            call.Caller(new QuanInizalition(500), methods);
            call.Caller(new QuanInizalition(1000), methods);
            call.Caller(new QuanInizalition(anwser), methods);

            new TableCreation().Create(methods);
        }
    }
}
