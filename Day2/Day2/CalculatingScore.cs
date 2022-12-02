using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class CalculatingScore
    {
        int totalScore = 0;
        public int GettingOutcome(string[] rounds)
        {
            foreach (var round in rounds)
            {
                string[] plays = round.Split(' ');
                if (plays[0] == "A")
                {
                    switch (plays[1])
                    {
                        case "X":
                            CalculatingRoundScore(3, 0);
                            break;
                        case "Y":
                            CalculatingRoundScore(1, 3);
                            break;
                        case "Z":
                            CalculatingRoundScore(2, 6);
                            break;
                        default:
                            break;
                    }
                }
                else if (plays[0] == "B")
                {
                    switch (plays[1])
                    {
                        case "X":
                            CalculatingRoundScore(1, 0);
                            break;
                        case "Y":
                            CalculatingRoundScore(2, 3);
                            break;
                        case "Z":
                            CalculatingRoundScore(3, 6);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (plays[1])
                    {
                        case "X":
                            CalculatingRoundScore(2, 0);
                            break;
                        case "Y":
                            CalculatingRoundScore(3, 3);
                            break;
                        case "Z":
                            CalculatingRoundScore(1, 6);
                            break;
                        default:
                            break;
                    }
                }
            }
            return totalScore;
        }

        public void CalculatingRoundScore(int shapeScore, int outcome)
        {
            totalScore += shapeScore + outcome;
        }
    }
}
