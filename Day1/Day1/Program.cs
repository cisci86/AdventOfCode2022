using Day1;

string input = File.ReadAllText(@"C:\Users\Cecilia\source\repos\AdventOfCode\Day1\Day1\Input.txt");
string[] eachElfsFood = input.Split(new string[] {"\r\n\r\n"}, StringSplitOptions.RemoveEmptyEntries);

CaloriesCalc caloriesCalc = new CaloriesCalc();
caloriesCalc.CalculationElfCalories(eachElfsFood);

Console.WriteLine(caloriesCalc.GetTheThreeHigestCalories());