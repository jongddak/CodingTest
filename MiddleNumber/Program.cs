using System;

namespace MiddleNumber

{
    //https://school.programmers.co.kr/learn/courses/30/lessons/120811?language=csharp
    internal class Program
    {
        public int solution(int[] array)
        {
            int answer = 0;
            Array.Sort(array);
            answer = array[array.Length/2];


            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
