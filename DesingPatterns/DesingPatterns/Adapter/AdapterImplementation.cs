using System;

namespace DesingPatterns.Adapter
{
    public class AdapterImplementation
    {
        public void Implementation()
        {
            LowerText lowerText = new LowerText();
            ITarget target = new TextAdapter(lowerText);

            Console.WriteLine(
                "{0} DOES NOT LOOKS GOOD.\n{1} LOOKS BETTER", 
                lowerText.GetText(), 
                target.CapitalizeText()
            );
        }
    }
}
