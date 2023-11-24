using System;

namespace uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n ? ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("m ? ");
            int n = int.Parse(Console.ReadLine());

            List<char> word = new List<char>();

            int xDelimitor = 0; int yDelimitor = 0;

            //Skapa arrayen
            string[] map = new string[m];
            /*string filler = new string(' ', n);

            for(int b = 0; b < m; b++)
            {
                map[b] = filler;
            }*/

            for (int i = 0; i < m; i++)
            {
                Console.Write("Rad " + (i + 1) + " ? ");
                string currentInput = Console.ReadLine();
                if (currentInput.Length > n)
                {
                    Console.WriteLine("Det är ett för långt svar");
                    break;
                }
                map[i] = currentInput;
            }

            for (int y = 0; y < m;y++)
            {
                int xHolder = 0;

                for (int x = 0; x < map[y].Length; x++)
                {
                    if (isChar(map[y][x]) && x >= xDelimitor)
                    //if (map[y][x] != '.' && x >= xDelimitor)
                    {
                        word.Add(map[y][x]);
                        xHolder = x;
                    }
                }
                xDelimitor = xHolder;
            }
            Console.Write("Svar: ");
            foreach(char c in word)
            {
                Console.Write(c);
            }
            
        }


        // Namnet är helt fel. Det borde heta isLetter, men jag vågar inte röra det.
        static bool isChar(char charToCompare)
        {
            bool check = false;

            // Jag är så otroligt ledsen att detta var ända sättet jag hittade för att veta om karaktären var en bokstav
            // Jag önskar jag kunde säga att det inte var jag som skrev det.

            if (charToCompare == 'a' ||
                charToCompare == 'b' ||
                charToCompare == 'c' ||
                charToCompare == 'd' ||
                charToCompare == 'e' ||
                charToCompare == 'f' ||
                charToCompare == 'g' ||
                charToCompare == 'h' ||
                charToCompare == 'i' ||
                charToCompare == 'j' ||
                charToCompare == 'k' ||
                charToCompare == 'l' ||
                charToCompare == 'm' ||
                charToCompare == 'n' ||
                charToCompare == 'o' ||
                charToCompare == 'p' ||
                charToCompare == 'q' ||
                charToCompare == 'r' ||
                charToCompare == 's' ||
                charToCompare == 't' ||
                charToCompare == 'u' ||
                charToCompare == 'v' ||
                charToCompare == 'w' ||
                charToCompare == 'x' ||
                charToCompare == 'y' ||
                charToCompare == 'z' ||
                charToCompare == 'å' ||
                charToCompare == 'ä' ||
                charToCompare == 'ö'
                )
            {
                check = true;

            }

            if (charToCompare == 'A' ||
                charToCompare == 'B' ||
                charToCompare == 'C' ||
                charToCompare == 'D' ||
                charToCompare == 'E' ||
                charToCompare == 'F' ||
                charToCompare == 'G' ||
                charToCompare == 'H' ||
                charToCompare == 'I' ||
                charToCompare == 'J' ||
                charToCompare == 'K' ||
                charToCompare == 'L' ||
                charToCompare == 'M' ||
                charToCompare == 'N' ||
                charToCompare == 'O' ||
                charToCompare == 'P' ||
                charToCompare == 'Q' ||
                charToCompare == 'R' ||
                charToCompare == 'S' ||
                charToCompare == 'T' ||
                charToCompare == 'U' ||
                charToCompare == 'V' ||
                charToCompare == 'W' ||
                charToCompare == 'X' ||
                charToCompare == 'Y' ||
                charToCompare == 'Z' ||
                charToCompare == 'Å' ||
                charToCompare == 'Ä' ||
                charToCompare == 'Ö'
                )
            {
                check = true;

            }


            /*if ((int)(charToCompare - '0') <= 97 && (int)(charToCompare - '0') >= 122)
            {
                check = true;
            }*/

            return check;
        }
    }
}