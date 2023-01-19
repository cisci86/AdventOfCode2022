namespace Day3
{
    public class Badges
    {
        Rucksack rs = new Rucksack();
        public void GetBadge(string[] sacks)
        {
            int sum = 0;
            for (int i = 0; i < sacks.Length; i = i + 3)
            {
                char[] elf2 = new char[sacks[i + 1].Length];
                for(int j = 0; j < sacks[i + 1].Length; j++)
                {
                    elf2[j] = sacks[i + 1][j];
                }
                char[] elf3 = new char[sacks[i + 2].Length];
                for (int j = 0; j < sacks[i + 2].Length; j++)
                {
                    elf3[j] = sacks[i + 2][j];
                }
                foreach (char item in sacks[i])
                {
                    if (Array.Exists(elf2, e2i => e2i == item) && Array.Exists(elf3, e3i => e3i == item))
                    {
                        sum += rs.GetPriority(item);
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
