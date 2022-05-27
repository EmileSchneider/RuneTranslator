using System.Text;

namespace RuneTranslator
{
    public class Translator
    {
        private RuneDictonary _runeDictonary;

        public Translator()
        {
            _runeDictonary = new RuneDictonary();
        }
        public string ToRune(String english)
        {
            var runeString = new StringBuilder();
            foreach (char c in english.ToUpper())
            {
                if(Char.IsDigit(c) || Char.IsPunctuation(c) || Char.IsWhiteSpace(c))
                {
                    runeString.Append(c);
                }
                runeString.Append(_runeDictonary.GetRune(c));
            }
            return runeString.ToString();
        }
    }
}