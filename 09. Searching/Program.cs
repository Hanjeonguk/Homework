using System.Collections.Immutable;

namespace _09._Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, 8, 6, 4, 2, 0 };
            foreach (int i in array)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();
            Console.Write("순차 탐색: ");
            Console.WriteLine($"{Searching.SequentialSearch(array, 4)}");
     
            Array.Sort( array );
            Console.WriteLine("정렬");
            foreach (int i in array)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();
            Console.Write("이진 탐색: ");
            Console.WriteLine($"{Searching.BinarySearch(array,4)}") ;


            bool[,] graph = new bool[8, 8]
               {
                { false,  true, false, false, false, false, false, false },
                {  true, false,  true, false, false,  true, false, false },
                { false,  true, false, false,  true,  true, false, false },
                { false, false, false, false, false,  true, false, false },
                { false, false,  true, false, false, false,  true,  true },
                { false,  true,  true,  true, false, false, false, false },
                { false, false, false, false,  true, false, false, false },
                { false, false, false, false,  true, false, false, false },
               };

            Searching.DFS(in graph, 0, out bool[] dvisited, out int[] dparents);
            PrintGraphSearch(dvisited, dparents);
        }
        public static void PrintGraphSearch(bool[] visited, int[] parents)
        {
            for (int i = 0; i < visited.Length; i++)
            {
                Console.WriteLine($"{i,5}{visited[i],5}{parents[i],5}");
            }
        }
    }
}
