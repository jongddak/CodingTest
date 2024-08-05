namespace Problem002
{
    internal class Program
    {
        //https://school.programmers.co.kr/learn/courses/30/lessons/181936

        public int solution1(int number, int n, int m)
        {
            int answer = 0;
            if (number % n == 0)
            {
                if (number % m == 0)
                {
                    answer = 1;
                }
            }

            return answer;
        }


        //https://school.programmers.co.kr/learn/courses/30/lessons/12954
        public long[] solution2(int x, int n)
        {
            long[] answer = new long[n];
            for (int i = 0; i < n; i++)
            {
                answer[i] += (long)x * (i + 1);
            }   // 그냥 int로 냅두면 int 범위를 벗어나서 오류뜸
            return answer;
        }



        static void Main(string[] args)
        {
            
        }
    }
}
