using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_CSharp
{
    public class Solution
    {
        public static int lesson_1_task_1(int N) {

            var result = 0;

            var binary = Convert.ToString(N, 2);

            while (binary.Length > 0) {

                var lenght = HelperMethods.GetStringBetweenCharacters(binary, '1', '1').Length;
                if (lenght > result) result = lenght;
                if (binary.IndexOf('1') == -1) break;
                binary = binary.Remove(0, binary.IndexOf('1') + 1);
                 
            }


            return result;
        }

       
    }
}
