using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneTranslator
{
    internal class RuneDictonary
    {
        private Dictionary<char, string> _runes;
        public RuneDictonary()
        {
            _runes = new Dictionary<char, string>();
            buildDictonary();
        }

        private void buildDictonary()
        {
            _runes.Add('A', "\u16A8");
            _runes.Add('B', "\u16D2");
            _runes.Add('C', "\u16B2");
            _runes.Add('D', "\u16DE");
            _runes.Add('E', "\u16D6");
            _runes.Add('F', "\u16A0");
            _runes.Add('G', "\u16B7");
            _runes.Add('H', "\u16A0");
            _runes.Add('I', "\u16BB");
            _runes.Add('J', "\u16C3");
            _runes.Add('K', "\u16B2");
            _runes.Add('L', "\u16DA");
            _runes.Add('M', "\u16D7");
            _runes.Add('N', "\u16BE");
            _runes.Add('O', "\u16DF");
            _runes.Add('P', "\u16C8");
            _runes.Add('Q', "\u16B2");
            _runes.Add('R', "\u16B1");
            _runes.Add('S', "\u16CA");
            _runes.Add('T', "\u16CF");
            _runes.Add('U', "\u16A2");
            _runes.Add('V', "\u16A0");
            _runes.Add('W', "\u16B9");
            _runes.Add('X', "\u16DA\u16CA");
            _runes.Add('Y', "\u16BB\u16A2");
            _runes.Add('Z', "\u16C9");
        }

        public string GetRune(char englishChar)
        {
            return _runes.GetValueOrDefault(englishChar);
        }
    }
}
