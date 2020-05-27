using System;

namespace LiSECUtilities
{
    public class LiUtilities
    {
        public static void PrintString(string value)
        {
            for(int i=0; i<value.Length; i++)
            {
                Console.WriteLine($"The character at {i} is : {value[i]}");
            }
        }

        public static string ToUpperCase(string str)
        {
            Console.WriteLine("String entered " + str);
            return str.ToUpper();
        }

        public static string ToLowerCase(string str)
        {
            Console.WriteLine("String entered " + str);
            return str.ToLower();
        }
		
		public static string HelloWorld(string str)
        {
            Console.WriteLine("String entered " + str);
            return str.ToLower();
        }
		
		public static string SayHello(string str)
        {
            Console.WriteLine("String entered " + str);
            return str.ToLower();
        }
    }
}
