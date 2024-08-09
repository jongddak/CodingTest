namespace StringCustomSorting
{//https://school.programmers.co.kr/learn/courses/30/lessons/12915
    internal class Program
    {
        public string[] solution(string[] strings, int n)
        {
            string[] answer = new string[strings.Length];
            for (int i = 0; i < strings.Length; i++) 
            {
                answer[i] = strings[i][n] + strings[i];  // n= 1일때  abce -> babce 로 만들어서 정렬 
            }
            Array.Sort(answer);
            for (int i = 0; i < answer.Length; i++) 
            {
                answer[i]  = answer[i].Substring(1);    // 단어 원상복구 
            }
            
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
