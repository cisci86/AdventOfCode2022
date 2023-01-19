using Day8;

string input = File.ReadAllText(@"C:\Users\Cecilia\source\repos\AdventOfCode\Day8\Day8\Input.txt");
string[] treeRows = input.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

TreeCount tc = new TreeCount();

tc.CheckVisability(treeRows);

tc.CheckForTreeHousePlace(treeRows);