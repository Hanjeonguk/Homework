using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Shortespath
{
    internal class Dijkstra
    {
        const int INF = 99999;
        public static void ShortestPath(in int[,]graph, in int start, out bool[] visited, out int[] distance, out int[] parents)
        {
            visited = new bool[graph.GetLength(0)];
            distance = new int[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
                distance[i] = INF;
                parents[i] = -1;
            }
            distance[start] = 0;

            for (int i = 0;i < graph.GetLength(0); i++)
            {
                // 1. 방문하지 않은 정점 중 가장 가까운 정점부터 탐색
                int next = -1;
                int minDistance = INF;

                for (int j = 0; j < graph.GetLength(0); j++)
                {
                    if (!visited[j] && distance[j] < minDistance)
                    {
                        next= j;
                        minDistance = distance[j];
                    }
                }
                if(next < 0)
                {
                    break;
                }

                // 2. 직접연결된 거리보다 다른 정점을 거쳐서 더 짧아진다면 갱신.
                for(int j=0; j < graph.GetLength(0); j++)
                {
                    if (distance[j] > distance[next] + graph[next, j])
                    {
                        distance[j] = distance[next] + graph[next, j];
                        parents[j] = next;
                    }
                }
                visited[next] = true;

            }
        }
       
                
            
        

               
                
                
    }
}

