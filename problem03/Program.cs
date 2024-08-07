
namespace problem03
{
    internal class Program
    {
        //    static void Main(string[] args)
        //        {
        //            int[] array = { 1, 3, 5, 7, 9, 8, 6, 4, 2, 0 };
        //            Console.Write("배열 : ");
        //            foreach (int value in array)
        //            {
        //                Console.Write($" {value} ");
        //            }
        //            Console.WriteLine();

        //            int index1 = Util.IndexOf(array, 3);
        //            int index2 = Array.IndexOf(array, 3);
        //            Console.WriteLine($"순차탐색 결과 위치 : {index2}");
        //            Console.WriteLine();

        //            int index3 = Util.BinarySearch(array, 2);
        //            Console.WriteLine($"이진탐색 결과 위치 : {index3}");

        //            Array.Sort(array);
        //            Console.Write("배열 : ");
        //            foreach (int value in array)
        //            {
        //                Console.Write($" {value} ");
        //            }
        //            Console.WriteLine();
        //            int index4 = Util.BinarySearch(array, 2);
        //            int index5 = Array.BinarySearch(array, 2);
        //            Console.WriteLine($"이진탐색 결과 위치 : {index5}");
        //            Console.WriteLine();


        //            bool[,] graph = new bool[8, 8]
        //            {
        //            //  0      1      2      3      4      5      6      7
        //            { false,  true, false, false,  true, false, false, false },
        //            {  true, false,  true,  true, false,  true,  true, false },
        //            { false,  true, false, false, false,  true, false, false },
        //            { false,  true, false, false, false, false, false, false },
        //            {  true, false, false, false, false, false,  true, false },
        //            { false,  true,  true, false, false, false,  true, false },
        //            { false,  true, false, false,  true,  true, false, false },
        //            { false, false, false, false, false, false, false, false },
        //            };
        //        }
        //    }

        //    public class Util
        //    {
        //        // <순차 탐색>
        //        // 자료구조에서 순차적으로 찾고자 하는 데이터를 탐색
        //        // 시간복잡도 - O(n)
        //        public static int IndexOf(int[] array, int target)
        //        {
        //            int result = -1;
        //            for (int i = 0; i < array.Length; i++)
        //            {
        //                if (array[i] == target)
        //                {
        //                    result = i;
        //                    break;
        //                }
        //            }

        //            return result;
        //        }

        //        // <이진 탐색>
        //        // 정렬이 되어있는 자료구조에서 2분할을 통해 데이터를 탐색
        //        // 단, 이진 탐색은 정렬이 되어 있는 자료에만 적용 가능
        //        // 시간복잡도 - O(logn)
        //        public static int BinarySearch(int[] array, int target)
        //        {
        //            int result = -1;
        //            int min = 0;
        //            int max = array.Length - 1;

        //            while (min <= max)
        //            {
        //                int mid = (min + max) / 2;  // 중간 위치

        //                if (array[mid] < target)
        //                {
        //                    min = mid + 1;
        //                }
        //                else if (array[mid] > target)
        //                {
        //                    max = mid - 1;
        //                }
        //                else // if (array[mid] == target)
        //                {
        //                    result = mid;
        //                    break;
        //                }
        //            }

        //            return result;
        //        }


        //        // <깊이 우선 탐색 (Depth-First Search)>
        //        // 그래프의 분기를 만났을 때 최대한 깊이 내려간 뒤,
        //        // 분기의 탐색을 마쳤을 때 다음 분기를 탐색
        //        // 재귀(스택)을 통해 구현 ,  최단경로를 보장하지 않음  , 현재 탐색중인 경로만 메모리에 저장  
        //        public static void DFS(bool[,] graph, int start, out bool[] visited, out int[] parent)
        //        {
        //            int size = graph.GetLength(0);      // size : 그래프의 정점갯수
        //            visited = new bool[size];           // visited : 탐색 여부
        //            parent = new int[size];             // parent : 정점을 탐색한 정점이 누구인지 (역순으로 따라가면 경로)

        //            // 초기 세팅 (처음으로 가져야 되는 값들)
        //            for (int i = 0; i < size; i++)
        //            {
        //                visited[i] = false;
        //                parent[i] = -1;
        //            }

        //            SearchNode(graph, start, visited, parent);  // 처음 정점부터 탐색 시작
        //        }

        //        public static void SearchNode(bool[,] graph, int vertex, bool[] visited, int[] parent)
        //        {
        //            int size = graph.GetLength(0);  // 정점의 갯수
        //            visited[vertex] = true;         // 탐색한 정점을 탐색 완료 표시

        //            for (int i = 0; i < size; i++)  // 전체 정점들을 전부 확인하면서
        //            {
        //                if (graph[vertex, i] == true &&     // 연결되어 있는 정점
        //                    visited[i] == false)            // 찾은적 없는 정점
        //                {
        //                    parent[i] = vertex;             // 해당 정점을 탐색한 정점 표시
        //                    SearchNode(graph, i, visited, parent);  // 정점 탐색 시작
        //                }
        //            }
        //        }


        //        // <너비 우선 탐색 (Breadth-First Search)>
        //        // 그래프의 분기를 만났을 때 모든 분기들을 탐색한 뒤,
        //        // 다음 깊이의 분기들을 탐색
        //        // 큐를 통해서 구현 , 최단 경로 보장  , 다음으로 방문해야하는 정점을 모두 메모리에 담고 있음 
        //        public static void BFS(bool[,] graph, int start, out bool[] visited, out int[] parent)
        //        {
        //            int size = graph.GetLength(0);      // size : 그래프 정점의 갯수
        //            visited = new bool[size];           // visited : 정점의 탐색 여부
        //            parent = new int[size];             // parent : 해당 정점을 누가 찾았았는지 (역순으로 따라가면 경로)

        //            // 초기 설정
        //            for (int i = 0; i < size; i++)
        //            {
        //                visited[i] = false;
        //                parent[i] = -1;
        //            }

        //            Queue<int> queue = new Queue<int>();    // 큐 : 탐색해야하는 정점들의 대기열
        //            queue.Enqueue(start);           // 처음으로 탐색해야하는 정점은 시작 정점
        //            visited[start] = true;          // 탐색 여부 체크

        //            while (queue.Count > 0)         // 대기열에 아무것도 없을 때까지
        //            {
        //                int vertex = queue.Dequeue();   // 다음으로 탐색해야하는 정점 나오게 된다

        //                for (int i = 0; i < size; i++)  // 모든 정점들을 확인
        //                {
        //                    if (graph[vertex, i] == true &&   // 연결되어 있는 정점
        //                        visited[i] == false)          // 찾은적 없는 정점
        //                    {
        //                        visited[i] = true;  // 탐색 여부 체크
        //                        parent[i] = vertex; // 탐색하게되는 정점을 표시
        //                        queue.Enqueue(i);   // 탐색해야하는 정점을 대기열에 추가
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        /********************************************************************
        * 다익스트라 알고리즘 (Dijkstra Algorithm)
        * 
        * 특정한 노드에서 출발하여 다른 노드로 가는 각각의 최단 경로를 구함
        * 방문하지 않은 노드 중에서 최단 거리가 가장 짧은 노드를 선택 후,
        * 해당 노드를 거쳐 다른 노드로 가는 비용 계산
        ********************************************************************/

        //const int INF = 99999;

        //static void Main123(string[] args)
        //{
        //    int[,] graph = new int[8, 8]
        //    {
        //                // 0    1    2    3    4    5    6    7 
        //                {   0,   1,   8,   9, INF, INF, INF, INF},
        //                {   1,   0, INF, INF, INF,   3, INF, INF},
        //                {   8, INF,   0, INF,   1, INF,   3, INF},
        //                {   9, INF, INF,   0, INF,   9, INF,   1},
        //                { INF, INF,   1, INF,   0, INF,   9, INF},
        //                { INF,   3, INF,   9, INF,   0,   3, INF},
        //                { INF, INF,   3, INF,   9,   3,   0,   9},
        //                { INF, INF, INF,   1, INF, INF,   9,   0}
        //    };

        //    Dijkstra(graph, 0, out bool[] visited, out int[] distance, out int[] parent);

        //    for (int i = 0; i < graph.GetLength(0); i++)
        //    {
        //        Console.Write($" {i} ");
        //        Console.Write($" {visited[i]} ");
        //        Console.Write($" {distance[i]} ");
        //        Console.Write($" {parent[i]} ");
        //        Console.WriteLine();

        //    }
        //}

        //public static void Dijkstra(int[,] graph, int start, out bool[] visited, out int[] distance, out int[] parent)
        //{
        //    // 0. 초기 설정
        //    int size = graph.GetLength(0);      // size : 그래프의 정점 갯수
        //    visited = new bool[size];           // visited : 각 정점의 탐색 여부
        //    distance = new int[size];           // distance : 각 정점의 최단거리
        //    parent = new int[size];             // parent : 각 정점을 탐색한 정점이 누구인지 (역순으로 해보면 경로가 나온다)

        //    for (int i = 0; i < size; i++)
        //    {
        //        visited[i] = false;
        //        distance[i] = INF;
        //        parent[i] = -1;
        //    }
        //    distance[start] = 0;        // 처음 시작 위치의 거리는 0으로

        //    for (int i = 0; i < size; i++)
        //    {
        //        // 1. 가장 가까운 정점부터 선택
        //        int minIndex = -1;      // minIndex : 가장 작은 거리를 가진 위치를 기록해두기 위한 변수
        //        int minCost = INF;      // minCost : 가장 작은 거리 수치를 기록해두기 위한 변수
        //        for (int j = 0; j < size; j++)
        //        {
        //            if (visited[j] == false &&  // 탐색한 적이 없는 정점
        //                distance[j] < minCost)  // 거리가 가장 작은 정점
        //            {
        //                // 더 작은 거리를 찾았으면
        //                minIndex = j;           // 가장 작은 거리를 찾은 위치로
        //                minCost = distance[j];  // 가장 작은 거리의 수치를 보관
        //            }
        //        }
        //        if (minIndex < 0)               // 연결되어 있으면서 탐색한 적이 없는 정점이 없었던 경우
        //            break;                      // 탐색 종료

        //        visited[minIndex] = true;       // 다음으로 찾을 정점은 탐색했다고 표시

        //        // 2. 선택한 정점을 거쳐서 더 짧아지는 경우 갱신
        //        for (int j = 0; j < size; j++)
        //        {
        //            // distance[j] : 목적지까지 직접 연결된 거리
        //            // distance[minIndex] : 선택한 정점까지의 거리
        //            // graph[minIndex, j] : 선택한 정점에서 목적지까지의 거리

        //            // 목적지까지 직접 연결된 거리가 거쳐서가는 거리보다 더 큰 경우
        //            if (distance[j] > distance[minIndex] + graph[minIndex, j])
        //            {
        //                // 목적지까지 직접 연결된 거리를 거쳐서가는 거리로 바꿔준다
        //                distance[j] = distance[minIndex] + graph[minIndex, j];
        //                parent[j] = minIndex;   // 탐색한 정점을 변경
        //            }
        //        }
        //    }
        //}


        // https://school.programmers.co.kr/learn/courses/30/lessons/120902?language=csharp
        public int solution1(string my_string)
        {
            int answer = 0;
            var splited = my_string.Split(' ');
            answer = int.Parse(splited[0]);
            for (int i = 1; i < splited.Length; i += 2)
            {
                var num = int.Parse(splited[i + 1]);
                if (splited[i] == "+")
                    answer += num;
                else
                    answer -= num;
            }
            return answer;
        }

        //https://school.programmers.co.kr/learn/courses/30/lessons/120808
        //분수의 덧셈은 쉬웠지만 기약분수를 만들려면 최대공약수가 필요한데 이부분은 검색으로 해결함..
        public static int[] solution2(int numer1, int denom1, int numer2, int denom2)
        {
            int[] answer = new int[2];
            if (denom2 == denom1)
            {
                answer[0] = numer1 + numer2;
                answer[1] = denom1;
            }
            else 
            {   
                int nu = (numer1*denom2)+(numer2*denom1);
                int de = denom2 * denom1;
                answer[0] = nu;
                answer[1] = de;
            }
            int x = gcd(answer[0], answer[1]);
            answer[0] = answer[0]/x;
            answer[1] = answer[1]/x;
            return answer;
        }
        static int gcd(int a, int b)  // 유클리드 호제법을 이용한 최대 공약수 구하는 알고리즘 
        {
            int temp;
            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }


        public static int solution3(int[] numbers, int target)
        {
            int answer = 0;
            int sum = 0;
            Stack<int> stack = new Stack<int>();




            
            
            return answer;
        }


        static void Main(string[] args)
        {
            

        }
    }
}
