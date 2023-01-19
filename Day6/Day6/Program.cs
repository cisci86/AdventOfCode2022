using Day6;

string input = File.ReadAllText(@"C:\Users\Cecilia\source\repos\AdventOfCode\Day6\Day6\Input.txt");

StartOfPacket sop = new StartOfPacket();

Console.WriteLine(sop.GetStartOfPacket(input));

StartOfMessage som = new StartOfMessage();
Console.WriteLine(som.GetStartOfMessage(input));