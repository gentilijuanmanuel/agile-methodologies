using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Clase_03_04
{
    public class StringCalculator
    {
        //public int add(string numbers)
        //{
        //    if (numbers == "")
        //    {
        //        return 0;
        //    }
        //    string[] array = numbers.Split(new char[] { ',', '\n'});
        //    if (array.Length == 1)
        //    {
        //        return Convert.ToInt32(numbers);
        //    }
        //    int result = 0;
        //    for (var i = 0; i < array.Length; i++)
        //    {
        //        result = result + Convert.ToInt32(array[i]);
        //    }
        //    return result;
        //}

        public int add(string numbers)
        {
            if (numbers == "")
            {
                return 0;
            }
            String pattern = @"[^0-9]";
            String[] array = Regex.Split(numbers, pattern);
            int result = 0;
            for (var i = 0; i < array.Length; i++)
            {
                result = result + Convert.ToInt32(array[i]);
            }
            return result;
        }
    }
}
