using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatter
{
    public class TextFormatter
    {
        public static string Justify(string text, int width)
        {
            int position = 0;
            string resultString = "";
            text = text.Trim();
            
            while(true)
            {
                if (text.Length - position <= width)
                    return resultString + text.Substring(position);

                string substring = text.Substring(position, width);
                if (!substring.Contains(" ") && text.Length - 1 > position + width && text[position + width] != ' ')
                {
                    int endLongWord = text.Substring(position).IndexOf(" ");
                    endLongWord = endLongWord == -1 ? text.Length : endLongWord;
                    substring = text.Substring(position, endLongWord - position);
                    position += endLongWord + 1;
                    resultString += substring;
                    if (position >= text.Length)
                        return resultString;
                    resultString += '\n';
                    continue;
                }
                if (text[position + width] == ' ')
                {
                    position += width + 1;
                    resultString += substring + '\n';
                    continue;
                }

                position += substring.LastIndexOf(' ') + 1;
                substring = substring.Remove(substring.LastIndexOf(' '));

                int spaceNeed = width - substring.Length;
                int spaces = substring.Split(' ').Length - 1;
                resultString += getSpacedString(substring, spaceNeed, spaces) + '\n';
            }
        }

        

        private static string getSpacedString(string substring, int spaceNeed, int spaces)
        {
            string[] words = substring.Split(' ');
            string resultString = words[0];
            int count = spaces;
            for (int i = 0; i < count; i++)
            {
                int ceilingValue = (int)(Math.Ceiling((Double)spaceNeed / spaces));
                resultString = resultString.PadRight(resultString.Length + ceilingValue + 1);
                resultString += words[i + 1];
                spaceNeed -= ceilingValue;
                spaces--;
            }
            return resultString;
        }
    }
}
