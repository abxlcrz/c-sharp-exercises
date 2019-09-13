using System;

namespace delegates
{
    public class Apostador
    {   
        private Random  Number =new Random ();
        public int  Apostar()
        {   
            int number= Number.Next();
            return number;
        }

        
    }
}