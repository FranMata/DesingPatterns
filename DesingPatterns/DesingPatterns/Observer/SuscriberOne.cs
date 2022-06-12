using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.Observer
{
    public class SuscriberOne : IObserver
    {
        public SuscriberOne() => Observer.Attach(this);
        public void RefreshMessage(string message) => Console.WriteLine("Observer one reporting new message: {0}", message);
    }
}