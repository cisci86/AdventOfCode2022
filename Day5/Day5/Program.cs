using Day5;

string input = File.ReadAllText(@"C:\Users\Cecilia\source\repos\AdventOfCode\Day5\Day5\Input.txt");
string[] boxMoves = input.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

Boxes boxes = new Boxes();
boxes.DivideMoveOrders(boxMoves);