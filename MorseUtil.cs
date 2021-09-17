using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

    class MorseUtil
    {

        public void Play(string morseCode)
        {
            foreach(char m in morseCode)
            {
                if(m == '.')
                {
                    Console.Beep(3000, 50);
                }
                else if(m == '-')
                {
                    Console.Beep(3000, 150);

                }
                else
                {
                    continue;
                }

            Thread.Sleep(100);
            }
        }

        public void EncodeAndPlay(string morseCode, Encoder encoder)
        {
           encoder.Encode(encoder.Encode(morseCode));
        }

    }

