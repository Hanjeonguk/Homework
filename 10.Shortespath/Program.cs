using _10.Shortespath;

namespace _11._ShortesPath
{
    internal class Program
    {
        const int INF = 99999;

        static void Main(string[] args)
        {
            int[,] graph = new int[8, 8]
            {
                { INF, INF, INF, 5, 4, INF, INF, INF },
                { INF, INF, 6, INF, INF, INF, INF, INF },
                { 6, INF, INF, INF, INF, 8, INF, INF},
                { INF, INF, INF,INF, INF, 6, INF, INF },
                { INF, INF, 6, INF, INF, INF, INF, INF},
                { INF, INF, INF, INF, INF, INF, 4, 6},
                { INF, INF, 9, INF, INF, 1, INF, INF},
                { INF, INF, INF, INF, INF, INF, INF, INF },

            };

            Dijkstra.ShortestPath(in graph, 0, out bool[] visited, out int[] distance, out int[] parents);

            Console.WriteLine("<Dijkstra>");
            PrintDijkstra(distance, parents);
        }

        private static void PrintDijkstra(int[] distance, int[] parents)
        {
            Console.WriteLine($"{"Vertex",8}{"Distance",10}{"Parents",10}");

            for (int i = 0; i < distance.Length; i++)
            {
                Console.Write($"{i,8}");

                if (distance[i] >= INF)
                {
                    Console.Write($"{"INF",10}");
                }
                else
                {
                    Console.Write($"{distance[i],10}");
                }

                Console.WriteLine($"{parents[i],10}");
            }
        }
    }
}