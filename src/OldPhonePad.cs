using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OldPhonePad
{
    public static class OldPhonePad
    {
        private static readonly Dictionary<char, string> letterMapping = new()
        {
            { '0', " " },
            { '1', "&'(" },
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        public static string Decode(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";

            var regex = new Regex(@"((\d)\2*|\*|\s)");
            var matches = regex.Matches(input);
            var message = new StringBuilder();

            foreach (Match match in matches)
            {
                var m = match.Value;
                if (m == " ") continue;
                if (m == "*")
                {
                    if (message.Length > 0) message.Length -= 1;
                    continue;
                }

                char key = m[0];
                if (!letterMapping.ContainsKey(key)) continue;

                var map = letterMapping[key];
                int pressCount = m.Length;

                int index = (pressCount - 1) % map.Length;
                message.Append(map[index]);
            }

            return message.ToString().ToUpper();
        }
    }
}