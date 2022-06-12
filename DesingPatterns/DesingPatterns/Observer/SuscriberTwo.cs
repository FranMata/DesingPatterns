using System;

namespace DesingPatterns.Observer
{
    public class SuscriberTwo : IObserver
    {
        public SuscriberTwo() => Observer.Attach(this);
        public void RefreshMessage(string message) => Console.WriteLine("Observer two reporting new message: {0}", message);
    }
}
