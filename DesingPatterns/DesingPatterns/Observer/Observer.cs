using System.Collections.Generic;

namespace DesingPatterns.Observer
{
    public class Observer
    {
        private static List<IObserver> _suscribers = new List<IObserver>();

        public static void Attach(IObserver suscriber) => _suscribers.Add(suscriber);        
        public static void Notify(string message) => _suscribers.ForEach(e => e.RefreshMessage(message));
        public static void Detach(IObserver suscriber) => _suscribers.Remove(suscriber);
    }
}