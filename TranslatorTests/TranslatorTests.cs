using RuneTranslator;

namespace TranslatorTests
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSingleChar()
        {
            Translator translator = new Translator();
            var english = "H";
            var runeH = "\u16A0";
            Assert.AreEqual(runeH, translator.ToRune(english));
        }

        [Test]
        public void TestWord()
        {
            Translator translator = new Translator();
            var word = "hello";
            var runes = "\u16A0\u16D6\u16DA\u16DA\u16DF";
        }
    }
}