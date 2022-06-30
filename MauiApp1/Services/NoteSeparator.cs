using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FlashCards.Services
{
    public class NoteSeparator
    {
        public List<string> SeparateNotes(string text)
        {
            var regex = new Regex(@"[^.!?]*[.!?]");

            var list = new List<string>();

            var matches = regex.Matches(text);

            foreach(var match in matches)
            {
                list.Add(match.ToString());
            }

            return list;
        }
    }
}
