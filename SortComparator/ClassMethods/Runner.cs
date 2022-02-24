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
                new SortMethod("bubble",new Bubble()),
                new SortMethod("merge",new Merge()),
                new SortMethod("quick",new Quick()),
                new SortMethod("shell",new Shell()),
                new SortMethod("bucket",new Bucket()),
                new SortMethod("comb",new Comb()),
            };
            var call = new DoubleTrouble();
            var yourChoice = new Asker();
            var anwser = yourChoice.Ask();
            //QuanInizalition test = new QuanInizalition(200);
            call.Caller(new QuanInizalition(new QuanInizalition(20000)), methods);
            call.Caller(new QuanInizalition(new QuanInizalition(50000)), methods);
            call.Caller(new QuanInizalition(new QuanInizalition(100000)), methods);
            call.Caller(new QuanInizalition(new QuanInizalition(anwser)), methods);

            new TableCreation().Create(methods);
        }
    }
}
