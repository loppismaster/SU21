using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

    class Decoder
    {
        string[] Alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q" , "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string[] MorseAlphabet = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", "-...", "-.-", ".-..", "--", "-.", "---",
                ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."}; //1=short 2=long the alphabet to morse
        string[] MorseNumbers = new string[] { "----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." }; //1=short 2=long 0-9 in morse
        
        const char Aprostophe = (char)39;
       


        public string decode(string morseCode)
        {
            List<string> decodeList = new List<string>();
            List<string> decodedList = new List<string>();
            List<string> MorseCode = new List<string>();
            MorseCode.Add(morseCode);
            string tempStr = "";

            foreach(char c in morseCode)
            {

                if (c == '/')
                {
                    Console.WriteLine(tempStr);
                    decodeList.Add(tempStr);
                    tempStr = "";
                    
                    
                }
                else if (c == ' ')
                {
                    if (morseCode.IndexOf(c) == morseCode.Length && c.ToString() != " ") tempStr += c;
                    decodeList.Add(tempStr);
                    Console.WriteLine(tempStr);
                    tempStr = "";
                   
                    
                }
                
                else
                {

                    tempStr += c;
                    
                }
            }
            decodeList.Add(tempStr);
            Console.WriteLine(tempStr);
            
            tempStr = "";
            

            foreach (string s in decodeList)
            {
                switch (s)
                {
                    case ".-.-.-":
                        decodedList.Add(".");
                        
                        continue;
                    case "--..--":
                        decodedList.Add(",");
                        continue;
                    case "---...":
                        decodedList.Add(":");
                        continue;
                    case "-.-.-.":
                        decodedList.Add(";");
                        continue;
                    case "-....-":
                        decodedList.Add("-"); ;
                        continue;
                    case "..--.-":
                        decodedList.Add("_");
                        continue;
                    case ".----.":
                        decodedList.Add("'");
                        continue;
                    case ".-.-.":
                        decodedList.Add("+");
                        continue;
                    case "..--..":
                        decodedList.Add("?");
                        continue;
                    case "-...-":
                        decodedList.Add("=");
                        continue;
                    case "-.--.-":
                        decodedList.Add(")");
                        continue;
                    case "-.--.":
                        decodedList.Add("(");
                        continue;
                    case ".-...":
                        decodedList.Add("&");
                        continue;
                    case "...-..-":
                        decodedList.Add("$");
                        continue;
                    case "-.-.--":
                        decodedList.Add("!");
                        continue;
                    case ".-..-.":
                        decodedList.Add(((char)34).ToString());
                        continue;        
                    default:
                        break;
                }

                try
                {
                    int index = Array.IndexOf(MorseAlphabet, s);
                    if(index!=-1)
                    {
                        decodedList.Add(Alphabet[index]);

                    } else
                    {
                        decodedList.Add(" ");
                    }
                }
                catch(IndexOutOfRangeException)
                {
                    int index = Array.IndexOf(MorseNumbers, s);
                    if (index != -1)
                    {
                        decodedList.Add(" ");
                    }
                    else
                    {
                        decodedList.Add(index.ToString());

                    }

                }

                //int tempPos;
                //tempPos = Array.IndexOf(MorseAlphabet, s);
                //try
                //{
                //    decodedList.Add(Alphabet[tempPos].ToString());
                //}
                //catch(IndexOutOfRangeException)
                //{               
                //    break;
                //}
                //try
                //{
                //    tempPos = Array.IndexOf(MorseNumbers, s);
                //    decodedList.Add(tempPos.ToString());
                //}
                //catch (IndexOutOfRangeException)
                //{
                //    Console.WriteLine("can't find the value");
                //    break;
                //}


            }

            string result = "";
            foreach(string str2 in decodedList)
            {
                result += str2;
            }
            return result;
        }


    }




