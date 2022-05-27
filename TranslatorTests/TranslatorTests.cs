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
        public void TestSingleCharH()
        {
            Translator translator = new Translator();
            var english = "H";
            var runeH = "\u16BA";
            Assert.AreEqual(runeH, translator.ToRune(english));
        }

        [Test]
        public void TestSingleCharI()
        {
            Translator translator = new Translator();
            var english = "I";
            var runeH = "\u16C1";
            Assert.AreEqual(runeH, translator.ToRune(english));
        }

        [Test]
        public void TestSingleCharZ()
        {
            Translator translator = new Translator();
            var english = "Z";
            var runeH = "\u16C9";
            Assert.AreEqual(runeH, translator.ToRune(english));
        }

        [Test]
        public void TestSingleCharN()
        {
            Translator translator = new Translator();
            var english = "N";
            var runeH = "\u16BE";
            Assert.AreEqual(runeH, translator.ToRune(english));
        }

        [Test]
        public void TestWord()
        {
            Translator translator = new Translator();
            var word = "hello";
            var runes = "\u16A0\u16D6\u16DA\u16DA\u16DF";
        }

        [Test]
        public void TestSentenceWithWhiteSpace()
        {
            Translator translator = new Translator();
            var word = "hello hello";
            var runes = "\u16A0\u16D6\u16DA\u16DA\u16DF \u16A0\u16D6\u16DA\u16DA\u16DF";
        }

        [Test]
        public void TestPunctuation()
        {
            Translator translator = new Translator();
            var word = "hello.";
            var runes = "\u16A0\u16D6\u16DA\u16DA\u16DF.";
        }
    }
}