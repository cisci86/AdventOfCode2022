namespace Day6
{
    public class StartOfPacket
    {
        public int GetStartOfPacket(string input)
        {
            Queue<char> sop = new Queue<char>();
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                sop.Enqueue(input[i]);
                if (!sop.Contains(input[i + 1]))
                {
                    sop.Enqueue(input[i + 1]);
                }
                else
                {
                    sop.Clear();
                    continue;
                }
                if (!sop.Contains(input[i + 2]))
                {
                    sop.Enqueue(input[i + 2]);
                }
                else
                {
                    sop.Clear();
                    continue;
                }
                if (!sop.Contains(input[i + 3]))
                {
                    sop.Enqueue(input[i + 3]);
                    foreach (var item in sop)
                    {
                        output += item;
                    }
                    return input.IndexOf(output) + 4;
                }
                else
                {
                    sop.Clear();
                    continue;
                }
            }

            return 0;
        }
    }
}
