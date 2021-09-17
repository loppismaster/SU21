using System;
using System.Threading;



    public class Encoder
    {
    string Alphabet = "abcdefghijklmnopqrstuvwxyz";
    int[] MorseAlphabet = new int[] { 12, 2111, 2121, 211, 1, 1121, 221, 1111, 11, 1222, 212, 1211, 22, 21, 222,
                1221, 2212, 121, 111, 2, 112, 1112, 122, 2112, 2122, 2211}; //1=short 2=long the alphabet to morse
    int[] MorseNumbers = new int[] { 22222, 12222, 11222, 11122, 11112, 11111, 21111, 22111, 22211, 22221 }; //1=short 2=long 0-9 in morse
    const char Aprostophe = (char)39;



    public Encoder()
        {

        }

        public void Play(string morsecode)
        {
           
            foreach(char c in morsecode)
            {
                if(c.ToString() == " ")
                {
                Console.WriteLine('/');
                    continue;
                }

                if(c == '.')
                {
                Console.Beep(2000, 50);
                Console.Write('.');
                }
                else if (c == '-')
                {
                Console.Beep(2000, 150);
                Console.Write('-');
            }
                else
                {
                Console.Write(c);
                }
                Thread.Sleep(50);
        }
        }

        public string Encode(string text)
        {

            

            int NumberInAlphabet = 0;

            int morseNumber = 0;
            int tempMorse = 0;
            string morseString;
            string fullMorse = "";
            int parseResult;
            bool SpecialSymbol = false;
            foreach (char c in text)
            {

                switch (c)
                {
                    case '.':
                        tempMorse = 121212;
                        SpecialSymbol = true;
                        break;
                    case ',':
                        tempMorse = 221122;
                        SpecialSymbol = true;
                        break;
                    case '-':
                        tempMorse = 211112;
                        SpecialSymbol = true;
                        break;
                    case '_':
                        tempMorse = 112212;
                        SpecialSymbol = true;
                        break;
                    case ':':
                        tempMorse = 222111;
                        SpecialSymbol = true;
                        break;
                    case ';':
                        tempMorse = 212121;
                        SpecialSymbol = true;
                        break;
                    case '/':
                        tempMorse = 21121;
                        SpecialSymbol = true;
                        break;
                    case '+':
                        tempMorse = 12121;
                        SpecialSymbol = true;
                        break;
                    case '!':
                        tempMorse = 212122;
                        SpecialSymbol = true;
                        break;
                    case '"':
                        tempMorse = 121121;
                        SpecialSymbol = true;
                        break;
                    case '&':
                        tempMorse = 12111;
                        SpecialSymbol = true;
                        break;
                    case '(':
                        tempMorse = 21221;
                        SpecialSymbol = true;
                        break;
                    case ')':
                        tempMorse = 212212;
                        SpecialSymbol = true;
                        break;
                    case '=':
                        tempMorse = 21112;
                        SpecialSymbol = true;
                        break;
                    case '?':
                        tempMorse = 112211;
                        SpecialSymbol = true;
                        break;
                    case '@':
                        tempMorse = 122121;
                        SpecialSymbol = true;
                        break;
                    case '$':
                        tempMorse = 1112112;
                        SpecialSymbol = true;
                        break;
                    case Aprostophe:
                        tempMorse = 122221;
                        SpecialSymbol = true;
                        break;



                    default:
                        break;
                }

                if (int.TryParse(c.ToString(), out parseResult))
                {
                    
                    morseNumber = MorseNumbers[int.Parse(c.ToString())];
                    SpecialSymbol = false;
                }
                else if (char.IsLower(c))
                {
                    if (!SpecialSymbol)
                    {
                        NumberInAlphabet = Alphabet.IndexOf(c) + 1;
                        morseNumber = MorseAlphabet[Alphabet.IndexOf(c)];
                        SpecialSymbol = false;

                    }
                }
                else if (c.ToString() == " ")
                {
                    fullMorse += "/";
                    SpecialSymbol = false;
                    continue;
                }
                else
                {
                    if (!SpecialSymbol)
                    {


                        char[] lowerCase = c.ToString().ToLower().ToCharArray();
                        NumberInAlphabet = Alphabet.IndexOf(lowerCase[0]) + 1;
                        morseNumber = MorseAlphabet[NumberInAlphabet - 1];
                        SpecialSymbol = false;

                    }
                }

                morseString = morseNumber.ToString();

                if (!SpecialSymbol)
                {

                    foreach (char m in morseString)
                    {
                        if (m == '1')
                        {

                            fullMorse += ".";

                        }
                        else if (m == '2')
                        {




                            fullMorse += "-";
                        }
                    }
                    SpecialSymbol = false;

                }
                else
                {
                    morseString = tempMorse.ToString();
                    foreach (char m in morseString)
                    {
                        if (m == '1')
                        {



                            fullMorse += ".";

                        }
                        else if (m == '2')
                        {


                            fullMorse += "-";
                        }
                    }
                    SpecialSymbol = false;

                }
                fullMorse += "\u2009";

                // Thread.Sleep(200);

            }


            return fullMorse;



        }

    }
