using Day3;

string input = File.ReadAllText(@"C:\Users\Cecilia\source\repos\AdventOfCode\Day3\Day3\Input.txt");
string[] compartments = input.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

Rucksack rucksack = new Rucksack();
rucksack.DivideCompartments(compartments);

Badges badges = new Badges();
badges.GetBadge(compartments);

