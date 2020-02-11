using System;

namespace TaskMM
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input < 2 || input > 10000 || input % 2 == 0)
            {
                Console.WriteLine("Please check the conditions");
                return;
            }


            int leftDash = input;

            int rightDash = input;

            int innerDash = input * 2;

            int stars = input;

            int row = input / 2 + 1;

            for (int rows = 0; rows < row; rows++)
            {

                Console.Write("{0}{1}{2}{3}"
                    , new string('-', leftDash)
                    , new string('*', stars)
                    , new string('-', rightDash)
                    , new string('*', stars));

                Console.Write("{0}", new string('-', innerDash));

                Console.Write("{0}{1}{2}{3}"
                    , new string('*', stars)
                    , new string('-', rightDash)
                    , new string('*', stars)
                    , new string('-', leftDash));

                Console.WriteLine();

                leftDash--;
                stars += 2;
                rightDash -= 2;
                innerDash -= 2;
            }

            stars = input;
            int middleStars = stars * 2 - 1;
            rightDash = 1;

            for (int rows = 0; rows < row; rows++)
            {
                Console.Write("{0}{1}{2}{3}{4}{5}"
                    , new string('-', leftDash)
                    , new string('*', stars)
                    , new string('-', rightDash)
                    , new string('*', middleStars)
                    , new string('-', rightDash)
                    , new string('*', stars));

                Console.Write("{0}", new string('-', innerDash));

                Console.Write("{0}{1}{2}{3}{4}{5}"
                    , new string('*', stars)
                    , new string('-', rightDash)
                    , new string('*', middleStars)
                    , new string('-', rightDash)
                    , new string('*', stars)
                    , new string('-', leftDash));

                Console.WriteLine();

                leftDash--;
                rightDash += 2;
                middleStars -= 2;
                innerDash -= 2;
            }
        }
    }
}
