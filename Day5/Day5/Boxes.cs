namespace Day5
{
    public class Boxes
    {
        static char[] a1 = new char[] { 'F', 'C', 'P', 'G', 'Q', 'R' };
        Stack<char> s1 = new Stack<char>(a1);
        string p1 = new string(a1);
        static char[] a2 = new char[] { 'W', 'T', 'C', 'P' };
        Stack<char> s2 = new Stack<char>(a2);
        string p2 = new string(a2);
        static char[] a3 = new char[] { 'B', 'H', 'P', 'M', 'C' };
        Stack<char> s3 = new Stack<char>(a3);
        string p3 = new string(a3);
        static char[] a4 = new char[] { 'L', 'T', 'Q', 'S', 'M', 'P', 'R' };
        Stack<char> s4 = new Stack<char>(a4);
        string p4 = new string(a4);
        static char[] a5 = new char[] { 'P', 'H', 'J', 'Z', 'V', 'G', 'N' };
        Stack<char> s5 = new Stack<char>(a5);
        string p5 = new string(a5);
        static char[] a6 = new char[] { 'D', 'P', 'J' };
        Stack<char> s6 = new Stack<char>(a6);
        string p6 = new string(a6);
        static char[] a7 = new char[] { 'L', 'G', 'P', 'Z', 'F', 'J', 'T', 'R' };
        Stack<char> s7 = new Stack<char>(a7);
        string p7 = new string(a7);
        static char[] a8 = new char[] { 'N', 'L', 'H', 'C', 'F', 'P', 'T', 'J' };
        Stack<char> s8 = new Stack<char>(a8);
        string p8 = new string(a8);
        static char[] a9 = new char[] { 'G', 'V', 'Z', 'Q', 'H', 'T', 'C', 'W' };
        Stack<char> s9 = new Stack<char>(a9);
        string p9 = new string(a9);

        public void DivideMoveOrders(string[] boxMoves)
        {
            foreach (var move in boxMoves)
            {
                var splits = move.Split(' ');
                int[] moveOrders = { int.Parse(splits[1]), int.Parse(splits[3]), int.Parse(splits[5]) };
                MoveBoxes(moveOrders);

            }
            string topBoxes = s1.Pop().ToString() + s2.Pop().ToString() + s3.Pop() + s4.Pop().ToString() + s5.Pop() + s6.Pop() + s7.Pop() + s8.Pop() + s9.Pop();
            Console.WriteLine(topBoxes);
            string topboxes2 = p1[p1.Length - 1].ToString() + p2[p2.Length - 1] + p3[p3.Length - 1] + p4[p4.Length - 1] + p5[p5.Length - 1] + p6[p6.Length - 1] + p7[p7.Length - 1] + p8[p8.Length - 1] + p9[p9.Length - 1];
            Console.WriteLine(topboxes2);
        }

        public void MoveBoxes(int[] moveOrders)
        {
            for (int i = 0; i < moveOrders[0]; i++)
            {
                char boxToMove = MoveFrom(moveOrders[1]);
                MoveTo(moveOrders[2], boxToMove);
            }
            string boxesToMove = MoveBoxesFrom(moveOrders[1], moveOrders[0]);
            MoveBoxesTo(moveOrders[2], boxesToMove);
        }

        public char MoveFrom(int from)
        {
            char boxToMove = ' ';
            switch (from)
            {
                case 1:
                    boxToMove = s1.Pop();
                    break;
                case 2:
                    boxToMove = s2.Pop();
                    break;
                case 3:
                    boxToMove = s3.Pop();
                    break;
                case 4:
                    boxToMove = s4.Pop();
                    break;
                case 5:
                    boxToMove = s5.Pop();
                    break;
                case 6:
                    boxToMove = s6.Pop();
                    break;
                case 7:
                    boxToMove = s7.Pop();
                    break;
                case 8:
                    boxToMove = s8.Pop();
                    break;
                case 9:
                    boxToMove = s9.Pop();
                    break;

                default:
                    break;

            }
            return boxToMove;
        }

        public void MoveTo(int to, char box)
        {
            switch (to)
            {
                case 1:
                    s1.Push(box);
                    break;
                case 2:
                    s2.Push(box);
                    break;
                case 3:
                    s3.Push(box);
                    break;
                case 4:
                    s4.Push(box);
                    break;
                case 5:
                    s5.Push(box);
                    break;
                case 6:
                    s6.Push(box);
                    break;
                case 7:
                    s7.Push(box);
                    break;
                case 8:
                    s8.Push(box);
                    break;
                case 9:
                    s9.Push(box);
                    break;

                default:
                    break;

            }
        }

        public string MoveBoxesFrom(int from, int amount)
        {
            string boxesToMove = "";
            switch (from)
            {
                case 1:
                    boxesToMove = p1.Substring(p1.Length - amount);
                    p1 = p1.Remove(p1.Length - amount);
                    break;
                case 2:
                    boxesToMove = p2.Substring(p2.Length - amount);
                    p2 = p2.Remove(p2.Length - amount);
                    break;
                case 3:
                    boxesToMove = p3.Substring(p3.Length - amount);
                    p3 = p3.Remove(p3.Length - amount);
                    break;
                case 4:
                    boxesToMove = p4.Substring(p4.Length - amount);
                    p4 = p4.Remove(p4.Length - amount);
                    break;
                case 5:
                    boxesToMove = p5.Substring(p5.Length - amount);
                    p5 = p5.Remove(p5.Length - amount);
                    break;
                case 6:
                    boxesToMove = p6.Substring(p6.Length - amount);
                    p6 = p6.Remove(p6.Length - amount);
                    break;
                case 7:
                    boxesToMove = p7.Substring(p7.Length - amount);
                    p7 = p7.Remove(p7.Length - amount);
                    break;
                case 8:
                    boxesToMove = p8.Substring(p8.Length - amount);
                    p8 = p8.Remove(p8.Length - amount);
                    break;
                case 9:
                    boxesToMove = p9.Substring(p9.Length - amount);
                    p9 = p9.Remove(p9.Length - amount);
                    break;

                default:
                    break;

            }
            return boxesToMove;
        }

        public void MoveBoxesTo(int to, string boxes)
        {
            switch (to)
            {
                case 1:
                    p1 += boxes;
                    break;
                case 2:
                    p2 += boxes;
                    break;
                case 3:
                    p3 += boxes;
                    break;
                case 4:
                    p4 += boxes;
                    break;
                case 5:
                    p5 += boxes;
                    break;
                case 6:
                    p6 += boxes;
                    break;
                case 7:
                    p7 += boxes;
                    break;
                case 8:
                    p8 += boxes;
                    break;
                case 9:
                    p9 += boxes;
                    break;

                default:
                    break;

            }
        }
    }
}
