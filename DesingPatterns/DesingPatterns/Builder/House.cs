using System.Collections.Generic;

namespace DesingPatterns.Builder
{
    public class House
    {
        private List<string> _parts = new List<string>();
        public void Add(string part) => _parts.Add(part);

        public string GetPartsList()
        {
            string listParts = "";

            _parts.ForEach(e => listParts += e + "\n");

            return listParts;
        }
    }
}