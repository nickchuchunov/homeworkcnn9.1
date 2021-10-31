using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson3
{
    internal class StringRevers
    {
        /*2. Реализовать метод, который в качестве входного параметра принимает строку string,
         * возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод.*/

        internal string String(string value) 
        {
            char[] ArrayValue = value.Reverse().ToArray();
            string revers = string.Concat(ArrayValue);

            Console.WriteLine(revers);
            Console.ReadLine();
            return revers;


        }



    }
}
