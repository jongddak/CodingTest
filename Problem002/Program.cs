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

        //https://school.programmers.co.kr/learn/courses/30/lessons/12925
        //  int.Parse(s); 하면 한방에 끝날걸 문자열 쪼개서 배열에 넣고 아스키 코드 기준으로
        //  뺀 뒤에 자릿수를 곱하려 했는데  너무 빙빙 돈듯함

        public static int solution3(string s)
        {
            int answer = 0;
            answer = int.Parse(s);
            return answer;
        }



        static void Main(string[] args)
        {
           
        }
    }
}
