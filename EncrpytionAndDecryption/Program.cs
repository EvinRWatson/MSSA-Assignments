using System;

namespace EncrpytionAndDecryption
{
    class Program
    {
        public static string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the message you want to encrypt: ");
            string word = Console.ReadLine();

            Console.WriteLine("Input key for single-key encryption(single character a-z):");
            string key = Console.ReadLine();
            Console.WriteLine($"'{word}' encrypted using single key ({key}): {SingleKeyEncrypt(word, key)}");
            Console.WriteLine($"'{word}' decrypted using single key ({key}): {SingleKeyDecrypt(SingleKeyEncrypt(word, key), key)}");

            Console.WriteLine("Input key for multi-key encryption(any number of characters a-z):");
            key = Console.ReadLine();
            Console.WriteLine($"'{word}' encrypted using multi key ({key}): {MultiKeyEncrypt(word, "cat")}");
            Console.WriteLine($"'{word}' decrypted using multi key ({key}): {MultiKeyDecrypt(MultiKeyEncrypt(word, "cat"), "cat")}");

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
                            delta += 26;
                        if (delta > 25)
                            delta -= 26;
                        output += Alphabet[delta];
                    }
            return output;
        }
        public static string SingleKeyDecrypt(string input, string key)
        {
            input = CleanString(input);
            int keyNum = getKeyNum(key);
            string output = "";
            for (int i = 0; i < input.Length; i++)
                for (int j = 0; j < Alphabet.Length; j++)
                    if (input[i] == Alphabet[j])
                    {
                        int delta = j - keyNum;
                        if (delta < 0)
                            delta += 26;
                        if (delta > 25)
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
                            delta += 26;
                        if (delta > 25)
                            delta -= 26;
                        output += Alphabet[delta];
                        if (keyIndex == key.Length - 1)
                            keyIndex = 0;
                        else
                            keyIndex++;
                    }
            return output;
        }

        public static string MultiKeyDecrypt(string input, string key)
        {
            input = CleanString(input);
            string output = "";
            int keyIndex = 0;
            for (int i = 0; i < input.Length; i++)
                for (int j = 0; j < Alphabet.Length; j++)
                    if (input[i] == Alphabet[j])
                    {
                        int keyNum = getKeyNum(key[keyIndex].ToString());
                        int delta = j - keyNum;
                        if (delta < 0)
                            delta += 26;
                        if (delta > 25)
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
