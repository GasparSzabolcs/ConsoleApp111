using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace CA201007

{

    class Program

    {

        static Random rnd = new Random();

        static int[] tomb = new int[100];

        static char[] inf = "INFORMATIKA".ToCharArray();

        static void Main()

        {

            //dolog d = (dolog)rnd.Next(3);
            //Console.WriteLine(d);

            //Feltolt();

            //Kiir();

            //for (int i = 0; i < 1000; i++)

            //{

            //    RandomSzin();

            //    RandomHelyreIr();

            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.Write(RandomChar());
            //}
            Console.WriteLine(RandomJelszo());

            kever();
            Console.WriteLine(new string(inf));

            Console.ReadKey();

        }

        static void Feltolt()

        {

            for (int i = 0; i < tomb.Length; i++)

            {

                tomb[i] = rnd.Next(10, 100);

            }

        }

        static void Kiir()

        {

            for (int i = 0; i < tomb.Length; i++)

            {

                Console.Write($"{tomb[i]} ");

                if ((i + 1) % 10 == 0) Console.Write("\n");

            }

        }

        static void RandomHelyreIr()

        {

            Console.SetCursorPosition(

                rnd.Next(Console.WindowWidth),

                rnd.Next(Console.WindowHeight));

            Console.Write("*");

        }

        //enum dolog
        //{
        //    szánkó,
        //    mikulás,
        //    szarvas,
        //}

        static void RandomSzin()

        {



            //ConsoleColor[] szinek =

            //{

            //    ConsoleColor.Green,

            //    ConsoleColor.Blue,

            //    ConsoleColor.Yellow,

            //    ConsoleColor.Red,

            //    ConsoleColor.Magenta,

            //};

            Console.ForegroundColor = (ConsoleColor)rnd.Next(1,16);

        }

        static char RandomChar() => (char) rnd.Next(65, 91);

        static string RandomJelszo()
        {
            string pw = "";
            for (int i = 0; i < 6; i++)
            {
                pw += RandomChar();
            }
            return pw;
        }


        static void kever()
        {
            for (int i = 0; i < inf.Length / 2; i++)
            {
                int x = rnd.Next(inf.Length);
                int y = rnd.Next(inf.Length);

                char s = inf[x];
                inf[x] = inf[y];
                inf[y] = s;
            }
        }
    }

}