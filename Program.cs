using System;
using System.Threading;



namespace Selection
{



    class Program
    {
       


        static void Main(string[] args)
        {
            
            string Alphabet = "abcdefghijklmnopqrstuvwxyz";
            int[] MorseAlphabet = new int[] { 12, 2111, 2121, 211, 1, 1121, 221, 1111, 11, 1222, 212, 1211, 22, 21, 222,
                1221, 2212, 121, 111, 2, 112, 1112, 122, 2122, 2211}; //1=short 2=long the alphabet to morse
            int[] MorseNumbers = new int[]{ 22222, 12222, 11222, 11122, 11112, 11111, 21111, 22111, 22211, 22221,  }; //1=short 2=long 0-9 in morse
            Console.WriteLine("write something to be translated to morse code! ");
            String usrInput = Console.ReadLine();
            int NumberInAlphabet = 0;
            
            int total = 0;
            string concatenatedTotal = "";
            int morseNumber;
            string morseString;
            string fullMorse = "";
            int upperCaseLetter;
            int parseResult;
            Console.WriteLine(Alphabet);
           
            foreach (char c in usrInput)
            {
                if (int.TryParse(c.ToString(), out parseResult))
                {
                    char[] charArr = c.ToString().ToCharArray();
                    morseNumber = MorseNumbers[int.Parse(charArr[0].ToString())];

                }
                else if (char.IsLower(c)) {
                    NumberInAlphabet = Alphabet.IndexOf(c) + 1;
                    Console.WriteLine(c);
                    morseNumber = MorseAlphabet[NumberInAlphabet - 1];
                }
                else if (c.ToString() == " ")
                {
                    fullMorse += "\u2000";
                    continue;
                }
                else
                {
                    char[] lowerCase = c.ToString().ToLower().ToCharArray();
                    NumberInAlphabet = Alphabet.IndexOf(lowerCase[0])+1;
                    morseNumber = MorseAlphabet[NumberInAlphabet - 1];

                }
                Console.WriteLine("\n" + c + " Number In Alphabet: " + NumberInAlphabet);
               
                
                
                morseString = morseNumber.ToString();
                
                foreach(char m in morseString)
                {
                    if (m == '1')
                    {
                        Console.Beep(2000, 80);
                       
                        Console.WriteLine(".");
                        fullMorse += ".";
                        Thread.Sleep(100);

                    }
                    else if (m == '2')
                    {
                        Console.Beep(2000, 240);
                       
                        Console.WriteLine("-");
                        fullMorse += "-";
                        Thread.Sleep(260);
                    }
                }
                fullMorse += "\u2009";

                Thread.Sleep(200);
              
            }

          
            Console.WriteLine(" Full Morse Code " + fullMorse);
           

           Console.WriteLine("did you like this program? 1) yes 2)no");
            string usrIn = Console.ReadLine();
            int intIn = 0;
            if (usrIn == "yes") intIn = 1;
            if (usrIn == "no") intIn = 2;

            switch(intIn)
            {
                case 1:
                    Console.WriteLine("thank you, atleast someone can apriecate someones work!");
                    break;
                case 2:
                    Console.WriteLine("Go eat a male prostate ");
                    Console.WriteLine("activating bomb");
                    Thread.Sleep(200);
                    while(true)
                    {
                        Console.Beep(3000, 100);
                        Thread.Sleep(110);
                    }
                    break;
                defualt:
                    break;
            }

            


        
        }
    }
}
