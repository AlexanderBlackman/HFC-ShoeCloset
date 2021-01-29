using System;

namespace HFC_ShoeCloset
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoeCloset myCloset = new ShoeCloset();
            while (true)
                myCloset.DisplayOptions();
            
        }
    }
}
