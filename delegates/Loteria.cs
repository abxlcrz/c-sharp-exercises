using System;

namespace delegates
{
    public class Loteria
    {
        private Random  Number =new Random ();

        
        public int Notify()
        {   int winner= Number.Next() ;
            return winner;
        } 
    }
}