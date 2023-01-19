namespace Day4
{
    public class Sections
    {
        int fullOverlaps = 0;
        int partallyOverlapps = 0;
        public void DivideElfPairs(string[] elfPairs)
        {
            foreach (var elfPair in elfPairs)
            {
                string[] elfs = elfPair.Split(',', StringSplitOptions.RemoveEmptyEntries);
                DivideElfsSections(elfs);

            }
            Console.WriteLine("fulloverlapps:" + fullOverlaps);
            Console.WriteLine("PartalyOverlapps:" + partallyOverlapps);
        }

        public void DivideElfsSections(string[] elfPair)
        {
            List<int> sections = new List<int>();
            foreach (var elfs in elfPair)
            {
                var elf = elfs.Split('-', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < 2; i++)
                {
                    sections.Add(int.Parse(elf[i]));
                }
            }
            CheckForFullyOverlappingSections(sections);
            CheckForPartallyOverlappingSections(sections);
        }

        public void CheckForFullyOverlappingSections(List<int> sections)
        {
            bool fullOverlapp = false;
            if (sections[0] <= sections[2] && sections[1] >= sections[3])
                fullOverlapp = true;
            if (sections[2] <= sections[0] && sections[3] >= sections[1])
                fullOverlapp = true;

            if (fullOverlapp)
                fullOverlaps++;
        }

        public void CheckForPartallyOverlappingSections(List<int> sections)
        {
            bool partlyOverlapp = false;
            if (sections[1] >= sections[2] && sections[3] >= sections[1])
                partlyOverlapp = true;
            if (sections[0] <= sections[3] && sections[2] <= sections[0])
                partlyOverlapp = true;
            if (sections[0] <= sections[2] && sections[1] >= sections[3])
                partlyOverlapp = true;
            if (sections[2] <= sections[0] && sections[3] >= sections[1])
                partlyOverlapp = true;


                if (partlyOverlapp)
                partallyOverlapps++;
        }
    }
}
