using System;

namespace EncrpytionAndDecryption
{
    class Program
    {
        public static string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        static void Main(string[] args)
        {
            Console.WriteLine(SingleKeyEncrypt("we attack at dawn", "c"));
            Console.WriteLine(MultiKeyEncrypt("we attack at dawn", "cat"));

        }

        public static string CleanString(string input)
        {
            input = input.ToLower();
            input = input.Trim();
            string output = "";

            for (int i = 0; i < input.Length; i++)
                for (int j = 0; j < Alphabet.Length; j++)
                    if (input[i] == Alphabet[j])
                        output += Alphabet[j];


            return output;
        }

        public static int getKeyNum(string key)
        {
            int keyNum = 0;
            for (int i = 0; i < Alphabet.Length; i++)
            {
                if (Alphabet[i] == char.Parse(key))
                    i = Alphabet.Length - 1;
                keyNum++;
            }
            return keyNum;
        }

        public static string SingleKeyEncrypt(string input, string key)
        {
            input = CleanString(input);
            int keyNum = getKeyNum(key);
            string output = "";
            for (int i = 0; i < input.Length; i++)
                for (int j = 0; j < Alphabet.Length; j++)
                    if (input[i] == Alphabet[j])
                    {
                        int delta = j + keyNum;
                        if (delta < 0)
                            delta -= 26;
                        output += Alphabet[delta];
                    }
            return output;
        }

        public static string MultiKeyEncrypt(string input, string key)
        {
            input = CleanString(input);
            string output = "";
            int keyIndex = 0;
            for (int i = 0; i < input.Length; i++)
                for (int j = 0; j < Alphabet.Length; j++)
                    if (input[i] == Alphabet[j])
                    {
                        int keyNum = getKeyNum(key[keyIndex].ToString());
                        int delta = j + keyNum;
                        if (delta < 0)
                            delta -= 26;
                        output += Alphabet[delta];
                        if (keyIndex == key.Length - 1)
                            keyIndex = 0;
                        else
                            keyIndex++;
                    }
            return output;
        }
    }
}
