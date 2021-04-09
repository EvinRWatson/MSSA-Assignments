using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConversion
{
    public class Util
    {
        public static string dec2bin(int number)
        {
            string binary = "";
            while(number > 0)
            {
                binary = number % 2 + binary;
                number /= 2;
            }
            return binary;
        }

        public static string dec2oct(int number)
        {
            string Octal = "";
            int remainder;
            while(number > 0)
            {
                remainder = number % 8;
                Octal = remainder.ToString() + Octal;
                number /= 8;
            }
            return Octal;
        }

        public static int bin2dec(int binary)
        {
            int Decimal = 0;
            int count = 0;
            while(true)
            {
                if (binary == 0)
                    break;
                else
                {
                    int temp = binary % 10;
                    Decimal += (int)(temp * Math.Pow(2, count));
                    binary /= 10;
                    count++;
                }
            }
            return Decimal;
        }

        public static string bin2oct(int number)
        {
            int Decimal = bin2dec(number);
            return dec2oct(Decimal);
        }

        public static string oct2bin(int number)
        {
            int Decimal = oct2dec(number);
            return dec2bin(Decimal);
        }

        public static int oct2dec(int number)
        {
            int Decimal = 0;
            int i = 0;
            while(number != 0)
            {
                Decimal += (int)((number % 10) * Math.Pow(8, i));
                i++;
                number /= 10;
            }
            return Decimal;
        }
    }
}
