using Day12;
string input = File.ReadAllText(@"C:\Users\Cecilia\source\repos\AdventOfCode\Day12\Day12\Input.txt");
string[] treeRows = input.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

FindPath path = new FindPath();

path.FindShortesPath(treeRows);

