using Day2;

string input = File.ReadAllText(@"C:\Users\Cecilia\source\repos\AdventOfCode\Day2\Day2\Input.txt");
string[] rounds = input.Split("\r\n");

CalculatingScore calculatingScore = new CalculatingScore();

Console.WriteLine(calculatingScore.GettingOutcome(rounds));
