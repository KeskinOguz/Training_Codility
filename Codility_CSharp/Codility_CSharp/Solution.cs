﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_CSharp
{
    public class Solution
    {
        public static int lesson_1_task_1(int N)
        {
            var result = 0;

            var binary = Convert.ToString(N, 2);

            while (binary.Length > 0)
            {

                var lenght = HelperMethods.GetStringBetweenCharacters(binary, '1', '1').Length;
                if (lenght > result) result = lenght;
                if (binary.IndexOf('1') == -1) break;
                binary = binary.Remove(0, binary.IndexOf('1') + 1);

            }


            return result;
        }

        //Correctness: %100
        //Performance: %25
        //needs "slight" improvements :)
        public static int lesson_2_task_1_attempt(int[] A)
        {
            int result = 0;
            bool match;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == int.MaxValue)
                    continue;

                match = false;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] == A[j])
                    {
                        A[i] = A[j] = int.MaxValue;
                        match = true;
                        break;
                    }
                }
                if (!match)
                {
                    result = A[i];
                    break;
                }
            }
            return result;
        }
        public static int lesson_2_task_1(int[] A)
        {
            var dict = new Dictionary<int, int>();

            foreach (var item in A)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 0);
                }
                dict[item]++;
            }

            return dict.FirstOrDefault(x => x.Value % 2 == 1).Key;
        }
    }
}
