using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    static class Program
    {

        static void Main(string[] args)
        {
            String input;
            String reversedString;
            
            Console.WriteLine("This application will reverse any string that you input." +"\n"+
                              "Enter a String:");
            input = Console.ReadLine();


            reversedString = ReverseString(input);

            Console.WriteLine("The string you inputted was: " +input+ "\n When it is reveresed,"
                             +"it looks like this: "+ reversedString );
        }

        static String ReverseString(String StringInput)
        {
            char[] charArray = StringInput.ToCharArray();
            Array.Reverse(charArray);
            return String.Concat(charArray);
        }
    }
}
//originalString - 1  took place of increment