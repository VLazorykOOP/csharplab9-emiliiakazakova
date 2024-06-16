using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    internal class ReverseCheckArray
    {
        public bool IsReverse(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            ArrayList list1 = new ArrayList(s1.ToCharArray());
            list1.Reverse();

            ArrayList list2 = new ArrayList(s2.ToCharArray());
            return Enumerable.SequenceEqual(list1.Cast<char>(), list2.Cast<char>());
        }

        public void Run()
        {
            string str1 = "hello";
            string str2 = "olleh";

            if (IsReverse(str1, str2))
                Console.WriteLine("Рядок s2 є зворотнім до s1.");
            else
                Console.WriteLine("Рядок s2 не є зворотнім до s1.");
        }
    }
}
