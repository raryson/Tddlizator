using System;

namespace RomanNumberConversion.FrameWork
{
    public class RomanNumberConverter
    {
        public RomanNumberConverter()
        {
        }

        public int ConvertToInt(char romanNumber)
        {
            if(romanNumber == 'V')
            {
                return 5;
            }else if(romanNumber == 'X')
            {
                return 10;
            }
            else if(romanNumber == 'I')
            {
                return 1;
            }
            else
            {
                throw new ArgumentOutOfRangeException("romanNumber");
            }
          
        }

        public int ConvertToInt(string romanNumber)
        {
            var total = 0;

            for(int i = 0; i < romanNumber.Length; i++)
            {
                var charValue = this.ConvertToInt(romanNumber[i]);
                var indiceAnterior = i - 1;
                var pastCharValue = indiceAnterior >= 0 ? this.ConvertToInt(romanNumber[indiceAnterior]) : charValue;

                if(charValue > pastCharValue)
                {
                    total = charValue - total;
                }
                else
                {
                    total += charValue;
                }
           
            }

            return total;
        }
    }
}