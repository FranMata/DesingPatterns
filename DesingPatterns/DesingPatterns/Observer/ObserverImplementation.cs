using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesingPatterns.Observer
{
    public class ObserverImplementation
    {

        public void Implementation()
        {
            SuscriberOne suscriberOne = new SuscriberOne();
            SuscriberTwo suscriberTwo = new SuscriberTwo();

            Observer.Notify("Broadcasting message one");

            Thread.Sleep(2000);

            Observer.Notify("Broadcasting message two");
        }
    }
}
