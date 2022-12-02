using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class CaloriesCalc
    {
        List<int> ElfsCalories = new List<int>();

        public void CalculationElfCalories(string[] elfsFood)
        {
            foreach (var elf in elfsFood)
            {
                string[] foodsCalories = elf.Split("\r\n");
                int totalCalories = 0;
                foreach (var calorie in foodsCalories)
                {
                    totalCalories += int.Parse(calorie);
                }
                ElfsCalories.Add(totalCalories);
            }
        }

        public int GetElfWithHigestCalories()
        {
            int maxCalories = ElfsCalories.Max();
            return maxCalories;
        }

        public int GetTheThreeHigestCalories()
        {
            int totalCalories = 0;
            totalCalories += GetElfWithHigestCalories();
            int calorie2 = ElfsCalories.Where(x => x < totalCalories).Max();
            int calorie3 = ElfsCalories.Where(x => x < calorie2).Max();
            return totalCalories + calorie2 + calorie3;
        }
    }
}
