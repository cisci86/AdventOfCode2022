namespace Day8
{
    public class TreeCount
    {
        public int[,] MakeForest(string[] treeRows)
        {
            int[,] forest = new int[treeRows.Length, treeRows[0].Length];
            for (int r = 0; r < treeRows.Length; r++)
            {
                for (int c = 0; c < treeRows[0].Length; c++)
                {
                    string value = treeRows[r][c].ToString();
                    forest[r, c] = int.Parse(value);
                }
            }
            return forest;
        }

        public void CheckVisability(string[] treeRows)
        {
            var forest = MakeForest(treeRows);

            var visableTrees = 0;

            for (int r = 0; r < forest.GetLength(0); r++)
            {
                for (int c = 0; c < forest.GetLength(1); c++)
                {
                    bool visable = false;
                    if (c == 0 || r == 0 || r == forest.GetLength(0) - 1 || c == forest.GetLength(1) - 1)
                    {
                        visableTrees++;
                        continue;
                    }
                    for (int l = 0; l < c; l++)
                    {
                        if (forest[r, l] < forest[r, c])
                            visable = true;
                        else
                        {
                            visable = false;
                            break;
                        }
                    }
                    if (visable)
                    {
                        visableTrees++;
                        continue;
                    }
                    for (int rh = c + 1; rh < forest.GetLength(1); rh++)
                    {
                        if (forest[r, rh] < forest[r, c])
                            visable = true;
                        else
                        {
                            visable = false;
                            break;
                        }
                    }
                    if (visable)
                    {
                        visableTrees++;
                        continue;
                    }
                    for (int u = 0; u < r; u++)
                    {
                        if (forest[u, c] < forest[r, c])
                            visable = true;
                        else
                        {
                            visable = false;
                            break;
                        }
                    }
                    if (visable)
                    {
                        visableTrees++;
                        continue;
                    }
                    for (int d = r + 1; d < forest.GetLength(0); d++)
                    {
                        if (forest[d, c] < forest[r, c])
                            visable = true;
                        else
                        {
                            visable = false;
                            break;
                        }
                    }
                    if (visable)
                        visableTrees++;

                }
            }
            Console.WriteLine(visableTrees);
        }

        public void CheckForTreeHousePlace(string[] treeRows)
        {
            var forest = MakeForest(treeRows);

            var highestScenicScore = 0;

            for (int r = 0; r < forest.GetLength(0); r++)
            {
                for (int c = 0; c < forest.GetLength(1); c++)
                {
                    int score = 0;
                    if (c == 0 || r == 0 || r == forest.GetLength(0) - 1 || c == forest.GetLength(1) - 1)
                    {
                        continue;
                    }
                    int scoreL = 0;
                    for (int l = c - 1; l >= 0; l--)
                    {
                        
                        if (forest[r, l] < forest[r, c])
                        {
                            scoreL += 1;
                        }
                        else
                        {
                            scoreL++;
                            break;
                        }
                    }
                    score += scoreL;
                    int scoreR = 0;
                    for (int rh = c + 1; rh < forest.GetLength(1); rh++)
                    {
                       
                        if (forest[r, rh] < forest[r, c])
                            scoreR++;
                        else
                        {
                            scoreR++;
                            break;
                        }
                    }
                    score *= scoreR;
                    int scoreU = 0;
                    for (int u = r - 1; u >= 0; u--)
                    {
                        
                        if (forest[u, c] < forest[r, c])
                            scoreU++;
                        else
                        {
                            scoreU++;
                            break;
                        }
                    }
                    score *= scoreU;
                    int scoreD = 0;
                    for (int d = r + 1; d < forest.GetLength(0); d++)
                    {
                        
                        if (forest[d, c] < forest[r, c])
                            scoreD++;
                        else
                        {
                            scoreD++;
                            break;
                        }
                    }
                    score *= scoreD;

                    if (score > highestScenicScore)
                        highestScenicScore = score;
                }
            }
            Console.WriteLine(highestScenicScore);
        }
    }
}
