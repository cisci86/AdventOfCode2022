namespace Day12
{
    public class FindPath
    {
        public char[,] MakeMountain(string[] hightCoordinates)
        {
            char[,] mountain = new char[hightCoordinates.Length, hightCoordinates[0].Length];
            for (int r = 0; r < hightCoordinates.Length; r++)
            {
                for (int c = 0; c < hightCoordinates[0].Length; c++)
                {
                    mountain[r, c] = hightCoordinates[r][c];
                }
            }
            return mountain;
        }

        public Tuple<int, int> FindStart(char[,] mountain)
        {
            var x = 0;
            var y = 0;

            for (int r = 0; r < mountain.GetLength(0); r++)
            {
                for (int c = 0; c < mountain.GetLength(1); c++)
                {
                    if (mountain[r, c] == 'S')
                    {
                        x = r;
                        y = c;
                        return Tuple.Create(x, y);
                    }
                }
            }
            return Tuple.Create(x, y);
        }

        public void FindShortesPath(string[] hightCoordinates)
        {
            var mountain = MakeMountain(hightCoordinates);
            var xBiggest = mountain.GetLength(0);
            var yBiggest = mountain.GetLength(1);
            int shortestPath = int.MaxValue;
            List<(int, int)> visited = new List<(int, int)>();
            Queue<int[]> queue = new Queue<int[]>();
            var startXY = FindStart(mountain);
            int[] start = { startXY.Item1, startXY.Item2, 1 };
            mountain[startXY.Item1, startXY.Item2] = 'a';
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                visited.Add((current[0], current[1]));
                Console.WriteLine(mountain[current[0], current[1]]);
                if (mountain[current[0], current[1]] == 'E')
                {
                    Console.WriteLine(current[2]);
                    if (shortestPath > current[2])
                    {
                        shortestPath = current[2];
                        continue;
                    }
                }
                if (CheckOutofBound(current[0] + 1, xBiggest))
                {
                    Console.WriteLine(mountain[current[0] + 1, current[1]]);
                    if (mountain[current[0] + 1, current[1]] >= mountain[current[0], current[1]] || mountain[current[0], current[1]] == 'E')
                    {
                        int[] next = { current[0] + 1, current[1], current[2] + 1 };
                        if (!visited.Contains((next[0], next[1])))
                        {
                            queue.Enqueue(next);
                            visited.Add((next[0], next[1]));
                        }

                    }
                }
                if (CheckOutofBound(current[0] - 1, xBiggest))
                {
                    Console.WriteLine(mountain[current[0] - 1, current[1]]);
                    if (mountain[current[0] - 1, current[1]] >= mountain[current[0], current[1]] || mountain[current[0], current[1]] == 'E')
                    {
                        int[] next = { current[0] - 1, current[1], current[2] + 1 };
                        var nextAsString = string.Format("{0},{1}", next[0], next[1]);
                        if (!visited.Contains((next[0], next[1])))
                        {
                            queue.Enqueue(next);
                            visited.Add((next[0], next[1]));
                        }
                    }
                }
                if (CheckOutofBound(current[1] + 1, yBiggest))
                {
                    if (mountain[current[0], current[1] + 1] >= mountain[current[0], current[1]] || mountain[current[0], current[1]] == 'E')
                    {
                        Console.WriteLine(mountain[current[0], current[1] + 1]);
                        int[] next = { current[0], current[1] + 1, current[2] + 1 };
                        if (!visited.Contains((next[0], next[1])))
                        {
                            queue.Enqueue(next);
                            visited.Add((next[0], next[1]));
                        }
                    }
                }
                if (CheckOutofBound(current[1] - 1, yBiggest))
                {
                    Console.WriteLine(mountain[current[0], current[1] - 1]);
                    if (mountain[current[0], current[1] - 1] >= mountain[current[0], current[1]] || mountain[current[0], current[1]] == 'E')
                    {
                        int[] next = { current[0], current[1] - 1, current[2] + 1 };
                        var nextAsString = string.Format("{0},{1}", next[0], next[1]);
                        if (!visited.Contains((next[0], next[1])))
                        {
                            queue.Enqueue(next);
                            visited.Add((next[0], next[1]));
                        }
                    }
                }

            }

            Console.WriteLine(shortestPath);

        }

        private bool CheckOutofBound(int pos, int end)
        {
            if (pos < 0 || pos >= end)
            {
                return false;
            }
            return true;
        }
    }
}
