using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_CSharp
{
    public class Solution
    {
        //Lesson 1 Task 1 (BinaryGap)
        //Correctness: %100
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

        //Lesson 2 Task 1 (OddOccurrencesInArray)
        //Correctness: %100
        //Performance: %100
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

        //Lesson 2 Task 2 (CyclicRotation)
        //Correctness %100
        public static int[] lesson_2_task_2(int[] A, int K)
        {
            int[] result = new int[A.Length];

            if (A.Length <= 0)
                return result;

            if (K >= A.Length)
                K = K % A.Length;

            for (int i = K; i < A.Length; i++)
            {
                result[i] = A[i - K];
            }
            for (int i = 0; i < K; i++)
            {
                result[i] = A[A.Length - K + i];
            }
            return result;
        }
        //Lesson 3 Task 1 (PermMissingElem)
        //Correctness 100%
        //Performance 100%
        public static int lesson_3_task_1(int[] A)
        {
            Array.Sort(A);
            if (A.Length == 0 || A[0] != 1) return 1;
            else {
                
                for (int i = 1; i < A.Length; i++)
                {
                    if (A[i] - A[i - 1] > 1) return A[i] - 1;

                }
            }

            return A[A.Length - 1] + 1;
        }
        //Lesson 3 Task 2 (TapeEquilibrium)
        //Correctness 100%
        //Performance 100%
        public static int lesson_3_task_2(int[] A)
        {
            int result = int.MaxValue;
            int sum = 0;
            int sumLeft = 0;
            int sumRight = 0;
            int diff = 0;

            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }
            sumRight = sum;

            for (int i = 0; i < A.Length - 1; i++)
            {
                sumLeft += A[i];
                sumRight -= A[i];
                diff = Math.Abs(sumLeft - sumRight);
                if (diff < result)
                    result = diff;
            }
            return result;
        }
        //Lesson 3 Task 3 (FrogJump)
        //Correctness 100%
        //Performance 100%
        public static int lesson_3_task_3(int X, int Y, int D)
        {
            double result = 0;
            double distance = Y - X;

            result = Math.Ceiling(distance / D);

            return (int)result;
        }

    }
}
