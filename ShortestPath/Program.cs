namespace ShortestPath
{   //https://school.programmers.co.kr/learn/courses/30/lessons/1844
    internal class Program
    {
        public static int Solution(int[,] maps)
        {
            int n = maps.GetLength(0);
            int m = maps.GetLength(1);
            int curPositionX = 0;
            int curPositionY = 0;
            int enemyPositionX = n;
            int enemyPositionY = m;
            int count = 0;

            bool[,] visited = new bool[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    visited[i, j] = false;
                }
            }
            visited[0, 0] = true;

            //현재 포지션에서 탐색 - > 벽이 아니고 방문하지 않은 곳이면 이동
            //탐색을 어떻게 해야하나
            Queue<(int, int)> q = new Queue<(int, int)>();
            q.Enqueue((curPositionX, curPositionY));  // 시작지점

            while (q.Count > 0)
            {
                (curPositionX, curPositionY) = q.Dequeue();

                for (int i = curPositionX-1; i < curPositionX+2; i++)  //주변 9칸 탐색 , 인덱스를 범위를 벗어나버리는 문제....
                {
                    for (int j = curPositionY-1; j < curPositionY+2; j++)
                    {
                        if (i >= 0 && j >= 0) //맵 바깥이 아니고 
                        {
                            if (maps[i, j] == 1) // 벽이 아니고
                            {
                                if (visited[i, j] == false)//방문하지 않았던 곳이면
                                {
                                    visited[i, j] = true;
                                    curPositionX = i;
                                    curPositionY = j;
                                    q.Enqueue((curPositionX, curPositionY));
                                    count++;
                                }
                            }
                        }
                    }

                }
            }

            return count;
        }
        //시작은 1,1 목적지는 n,m(맵 반대편 끝)
        static void Main(string[] args)
        {
            int[,] ints = new int[,] 
            {
                {1, 0, 1, 1, 1 },
                {1, 0, 1, 0, 1 },
                {1, 0, 1, 1, 1 }, 
                {1, 1, 1, 0, 1 }, 
                {0, 0, 0, 0, 1 }
            };

            Console.WriteLine(Solution(ints));
        }

    }
}
