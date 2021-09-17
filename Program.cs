using System;
using System.Threading;



    

    class Program
    {

    static void Main(string[] args)
        {

            MorseUtil util = new MorseUtil();
        
            bool running = true;
            bool encoding = false;
            bool decoding = false;
         

            

            Console.WriteLine("Do you want to decode or encode?");
            Thread.Sleep(2000);
            string usrInput = Console.ReadLine();

            switch (usrInput)
            {
                case "decode":
                    decoding = true;
                    break;
                case "encode":
                    encoding = true;
                    break;
                default:
                    break;
            }

            while (running)
            {

              

                while (decoding)
                {
                    Console.Clear();
                    Console.WriteLine("Enter morse code to be decoded");
                    string usrIn = Console.ReadLine();
                    Decoder decoder = new Decoder();
                    Console.WriteLine(decoder.decode(usrIn));
                    Console.WriteLine("Want to do another one?");
                    usrIn = Console.ReadLine();
                    switch(usrIn)
                    {
                        case "yes":
                            decoding = true;
                            break;
                        case "no":
                            
                            decoding = false;
                            Console.WriteLine("Do you want to encode?");
                            usrIn = Console.ReadLine();
                            if(usrIn == "yes")
                            {
                                encoding = true;
                            }
                            else
                            {
                                System.Environment.Exit(0);
                            }
                            break;

                    }


                }

                while(encoding)
                {
                    Console.Clear();
                    Console.WriteLine("Enter text to be encoded");
                    string usrIn = Console.ReadLine();
                    Encoder encoder = new Encoder();
                    
                    string morseCode = encoder.Encode(usrIn);
                    Console.WriteLine(morseCode);
                    Console.WriteLine("Want to play it?");
                    usrIn = Console.ReadLine();
                    switch (usrIn)
                    {
                        case "yes":
                            util.Play(morseCode);
                            break;
                        case "no":

                            encoding = false;
                            Console.WriteLine("Do you want to decode?");
                            usrIn = Console.ReadLine();
                            if (usrIn == "yes")
                            {
                                decoding = true;
                            }
                            else
                            {
                            encoding = true;
                            decoding = false;
                            }
                            break;

                    }


                }
            }

            }

        }
    

