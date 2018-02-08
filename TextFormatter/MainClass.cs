using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFormatter;

namespace TextFormatter
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris elementum eu est in mattis. Sed ullamcorper sapien nec lectus elementum, in pellentesque urna ultrices. Curabitur id nisl non metus ultricies blandit. Praesent tincidunt, felis sed facilisis convallis, erat ipsum lacinia massa, sed ullamcorper felis lorem eget ligula. Proin ultrices sagittis velit, mattis ullamcorper tellus posuere vitae. Aliquam mollis eros sed fermentum consequat. In aliquam, nibh a posuere accumsan, mauris lorem ultricies metus, et ultrices nisi ex id justo. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Integer in sapien eu magna auctor finibus. Aliquam molestie eget sapien sit amet tincidunt.";
            string outString = TextFormatter.Justify(text, 30);
            Console.WriteLine(outString);
        }
    }
}
