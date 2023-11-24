using System;

namespace uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Björns protein ? ");
            string inputProtein = Console.ReadLine();

            Console.Write("k ? ");
            int k = int.Parse(Console.ReadLine());

            char[] protein = new char[inputProtein.Length];
            for(int i = 0; i < inputProtein.Length; i++)
            {
                protein[i] = inputProtein[i];
            }


            //Hela denna del hittar vilka chars som finns k ganger.
            List<char> fulfillsK = new List<char>();
            
            for(int i = 0; i < inputProtein.Length; i++)
            {
                int iterationsOfChar = 0;
                char character = protein[i];

                for(int j = 0; j < inputProtein.Length; j++)
                {
                    if(character == protein[j])
                    {
                        iterationsOfChar++;
                    }
                }
                if(iterationsOfChar == k)
                {
                    bool exists = false;
                    for (int h = 0; h < fulfillsK.Count(); h++)
                    {
                        if(character == fulfillsK[h])
                        {
                            exists = true;
                        }
                    }

                    if(exists == false)
                    {
                        fulfillsK.Add(character);

                    }

                }
            }


            int highestCutCount = 0;
            for(int i =0; i < fulfillsK.Count(); i++)
            {
                int cutCount = -1;
                int startCount = 0;
                char currentChar = fulfillsK[i];
                bool flipper = false;
                for(int j = 0;j < inputProtein.Length; j++)
                {
                    if (currentChar != inputProtein[j])
                    { 
                        if(flipper == false)
                        {
                            flipper = true;
                            cutCount++;
                        }
                    }
                    else if(flipper == true)
                    {
                        flipper = false;
                        cutCount++;
                    }
                }

                if(cutCount > highestCutCount)
                {
                    highestCutCount = cutCount;
                }
            }

            Console.WriteLine("Svar: " + highestCutCount);
        }
    }
}