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
            foreach (char c in english)
            {
                runeString.Append(_runeDictonary.GetRune(c));
            }
            return runeString.ToString();
        }
    }
}