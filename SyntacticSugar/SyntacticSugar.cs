using System;

namespace SyntacticSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WhoPlays());
        }

        /*
        Santactic sugar is when you use one method with optional parameter which allows to to avoid using
        multiple overloading which saves time and clutter.
        */


        //Two optional parameters
        /*
        static string WhoPlays(string player = "Player", string game = "games") 
        {
            return ($"{player} plays {game}");
        }
        */


        static string WhoPlays()
        {
            string player = "Player";
            string game = "games";
            return ($"{player} plays {game}");
        }

        static string WhoPlays(string player, string game)
        {
            return ($"{player} plays {game}");
        }

        static string WhoPlays(string player)
        {
            string game = "game";
            return ($"{player} plays {game}");
        }
    }
}
