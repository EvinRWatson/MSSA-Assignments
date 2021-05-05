using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        /*************************
        * read CSV with embedded commas
        * parse CSV into separate fields and
        * ignore commas within quoted string
        * ***********************/
        Console.WriteLine("Reading CSV with embedded commas");
        List<string> myList = new List<string>();
        string input1 = "\"a,b\",c";
        myList.Add(input1);
        string input2 = "\"Obama, Barack\",\"August 4, 1961\",\"Washington, D.C.\"";
        myList.Add(input2);
        string input3 = "\"Ft. Benning, Georgia\",32.3632N,84.9493W," +
        "\"Ft. Stewart, Georgia\",31.8691N,81.6090W," +
        "\"Ft. Gordon, Georgia\",33.4302N,82.1267W";
        myList.Add(input3);
        foreach (string s in myList)
        {
            Console.WriteLine($"Current input is {s}");
            List<string> output = getCSV(s);
            int len = output.Count;
            Console.WriteLine($"This line has {len} fields. They are:");
            foreach (string s1 in output)
                Console.WriteLine(s1);
        }
    }

    public static List<string> getCSV(string input)
    {
        List<string> outputList = new List<string>();
        var result = Regex.Split(input, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
        foreach (var n in result)
        {
            outputList.Add(n);
        }
        return outputList;

        //List<string> outputList = new List<string>();
        //int minIndex = 0;
        //bool isInQuotes = false;

        //for (int i = 0; i < input.Length - 1; i++)
        //{
        //    int counter = 0;


        //    if (input[i] == '"' && isInQuotes == true)
        //    {
        //        isInQuotes = false;
        //        continue;
        //    }

        //    if (input[i] == '"' && isInQuotes == false)
        //    {
        //        isInQuotes = true;
        //        continue;
        //    }


        //    if (input[i].Equals(','))
        //    {
        //        if(!isInQuotes)
        //        {
        //            minIndex = i + 1;
        //            for (int j = i + 1; j < input.Length - 1 && !input[j].Equals(','); j++)
        //            {
        //                counter++;
        //            }
        //            string newEntry = input.Substring(minIndex + 1, counter);
        //            outputList.Add(newEntry);
        //        }

        //        if (isInQuotes)
        //        {
        //            minIndex = i + 1;
        //            for (int j = i + 1; j < input.Length - 1 && !input[j].Equals('"'); j++)
        //            {
        //                counter++;
        //            }
        //            string newEntry = input.Substring(minIndex + 1, counter);
        //            outputList.Add(newEntry);
        //        }
        //    }

        //}
        //return outputList;
    }
}