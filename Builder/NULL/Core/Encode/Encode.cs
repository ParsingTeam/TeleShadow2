using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Encode
    {
        internal static byte [] Reverse(byte [] Data) //Reverse Encode config!
        {
            byte[] Temp = new byte[Data.Length];
            for (int i = 0; i < Data.Length; i++){
                Temp[(Temp.Length - 1) - i] = Data[i];
            }
            return Temp;
        }
    }
}
