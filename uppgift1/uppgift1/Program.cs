using System;

namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sluta = false;
            while (sluta == false)
            {
                Console.WriteLine("Skriv ett ord");
                string word = Console.ReadLine();

                if (word.Length > 9)
                {
                    Console.WriteLine("Ordet är för långt. Det får vara max 9 bokstäver");
                    sluta = true;
                    break;
                }

                Console.WriteLine("Hur många gånger skall det upprepas?");
                int iterations = int.Parse(Console.ReadLine());

                if (iterations > 9 || iterations < 1)
                {
                    Console.WriteLine("Det är för många upprepningar, det får vara max 9");
                    sluta = true;
                    break;
                }

                Console.Write("\n");
                Console.Write("Svar: ");
                for (int i = 0; i < iterations; i++)
                {

                    
                    Console.Write(word);
                    sluta = true;
                }
            }
            

        }
    }
}