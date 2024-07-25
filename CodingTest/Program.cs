using System;
namespace CodingTest
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
           
            Console.WriteLine("시작");
            //202407025
            //https://school.programmers.co.kr/learn/courses/30/lessons/120810?language=csharp
            int solution1(int num1, int num2)
            {
                int answer = num1 % num2;
                return answer;
            }
            //https://school.programmers.co.kr/learn/courses/30/lessons/120803
            int solution2(int num1, int num2)
            {
                int answer = num1 - num2;
                return answer;
            }
            //https://school.programmers.co.kr/learn/courses/30/lessons/120807
            int solution3(int num1, int num2)
            {
                int answer = 0;
                if (num1 == num2) { answer = 1; }
                else answer = -1;

                return answer;
            }
            //https://school.programmers.co.kr/learn/courses/30/lessons/120891
            int solution4(int order)
            {
                int answer = 0;
                string x = order.ToString();
                foreach (char i in x)
                {
                    if (i == ('3')) { answer++; }
                    else if (i == ('6')) { answer++; }
                    else if (i == ('9')) { answer++; }
                }
                return answer;
            }









        }
    }
}

