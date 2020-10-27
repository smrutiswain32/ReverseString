using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string _inputstring = string.Empty;
            string _ReverseString = string.Empty;
            Console.WriteLine("Enter the string");
            _inputstring = Console.ReadLine();
            for(int i= _inputstring.Length-1; i >=0; i--)
            {
                _ReverseString += _inputstring[i];

            }
            Console.WriteLine("Reverse String is:{0}", _ReverseString);
            Console.ReadLine();
        }
    }
}
