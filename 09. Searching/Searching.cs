using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Searching
{
    internal class Searching
    {
        //순차탐색
        public static int SequentialSearch<T>(in IList<T> list, in T item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }


        //이진탐색
        public static int BinarySearch<T>(in IList<T>list, in T item)where T : IComparable<T>
        {
            int low = 0;
            int high = list.Count - 1;

            while (low <= high)
            {
                int middle = (low + high) / 2;
                int compare = list[middle].CompareTo(item);

                if (compare > 0)
                    high = middle-1;
                else if (compare < 0)
                    low = middle+1;
                else

                return middle;
            }
            return -1;
        }

        //깊이 우선 탐색
        public static void DFS(in bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            visited = new bool[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for (int i = 0;i < graph.GetLength(0); i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }

            SearchNode(graph, start, visited, parents);
        }

        public static void SearchNode(in bool[,] graph, int start, bool[] visited, int[] parents)
        {
            visited[start] = true;
            for(int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[start, i] && !visited[i])
                {
                    parents[i] = start;
                    SearchNode(graph, i, visited, parents);
                }
            }
        }







        //넓이 우선 탐색
    }
}
