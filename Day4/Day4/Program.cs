using Day4;

string input = File.ReadAllText(@"C:\Users\Cecilia\source\repos\AdventOfCode\Day4\Day4\Input.txt");
string[] elfPairs = input.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

Sections sections = new Sections();

sections.DivideElfPairs(elfPairs);