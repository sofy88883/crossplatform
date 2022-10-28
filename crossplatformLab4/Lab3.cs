using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossplatformLab4
{
    public struct Edge
    {
        public int u;
        public int v;
        public int w;
    }
    internal class Lab3
    {
        
        
            public static int N;
            public static readonly int INF = 100000000;
            public static readonly int NOEDGE = 100000;

            public static List<Edge> edges = new List<Edge>();

            public static string findNegativeCycle()
            {
                List<int> dist = new List<int>(Enumerable.Range(1, N).Select(x => 0));
                List<int> p = new List<int>(Enumerable.Range(1, N).Select(x => -1));
                int x = 0;
                dist[0] = 0;

                for (int i = 0; i < N; ++i)
                {
                    x = -1;
                    for (int j = 0; j < edges.Count; ++j)
                    {
                        int u = edges[j].u;
                        int v = edges[j].v;
                        int w = edges[j].w;
                        if (dist[v] > dist[u] + w)
                        {
                            dist[v] = Math.Max(-INF, dist[u] + w);
                            p[v] = u;
                            x = v;
                        }
                    }
                }

                if (x == -1)
                {
                    Console.Write("NO");
                    Console.Write("\n");
                    return "NO";
                }
                else
                {
                    Console.Write("YES");
                    Console.Write("\n");
                    List<int> cycle = new List<int>();
                    int y = x;

                    for (int i = 0; i < N; ++i)
                    {
                        y = p[y];
                    }

                    for (int cur = y; ; cur = p[cur])
                    {
                        cycle.Add(cur);
                        if (cur == y && cycle.Count > 1)
                        {
                            break;
                        }
                    }

                    cycle.Reverse();

                    Console.Write(cycle.Count - 1);
                    Console.Write("\n");
                    for (int i = 1; i < cycle.Count; ++i)
                    {
                        Console.Write(cycle[i] + 1);
                        if (i != cycle.Count - 1)
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.Write("\n");
                    return "YES";
                }
            }

            public static void Main(string input, string output)
            {
                //string input2 = "../../../Put to lab 3.txt";
                //string output2 = "../../../Result to lab 3.txt";
                string input2 = input;
                string output2 = output;
                string[] inputData = File.ReadAllLines(input2, Encoding.UTF8);
                N = int.Parse(inputData[0]);
                inputData = inputData.Skip(1).ToArray();
                string[] inputArr = string.Concat(inputData).Split(" ");
                int inputIndex = 0;

                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < N; ++j)
                    {
                        var w = int.Parse(inputArr[inputIndex++]);
                        if (w != NOEDGE)
                        {
                            edges.Add(new Edge() { u = i, v = j, w = w });
                        }
                    }
                }
                File.WriteAllLines(output2, new String[] { findNegativeCycle() });
            }
        
    }
}
