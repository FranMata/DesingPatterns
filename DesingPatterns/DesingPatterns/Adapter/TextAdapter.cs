namespace DesingPatterns.Adapter
{
    public class TextAdapter : ITarget
    {
        private readonly LowerText _lowerText;

        public TextAdapter(LowerText lowerText) => _lowerText = lowerText;
        public string CapitalizeText() => _lowerText.GetText().ToUpper();
    }
}
