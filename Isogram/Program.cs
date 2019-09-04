using System;
using System.Collections.Generic;
using System.Linq;

namespace Isogram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static bool isogram(string text)
        {
            char[] str = text.ToCharArray();
            char[] newstr = new char[str.Length];
            int flag = 0;
            for(int i = 0; i< str.Length; i++)
            {
                if(str[i] != ' ' && str[i] != '-')
                {
                    if (newstr.Contains(str[i]))
                    {
                        flag = 1;
                    }
                    else
                    {
                        newstr[i] = str[i];
                    }
                }
            
            }

            if(flag == 1)
            {
                return false;
            }
            return true;
        }
    }
}
