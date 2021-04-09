using System;
using System.Text;
using System.Security.Cryptography;
namespace PasswordEncAuth
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] Users = new User[10];
            int UserIndex = 0;
            int TotalUsers = 0;
            bool isComplete = false;
            while (!isComplete)
            {
                Console.WriteLine("PASSWORD AUTHENTICATION SYSTEM");
                Console.WriteLine("\nOPTIONS:");
                Console.WriteLine("\t1 - New User Account");
                Console.WriteLine("\t2 - Authentice User");
                Console.WriteLine("\t3 - Exit System\n");
                Console.WriteLine("Selection: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter Username: ");
                        string UserName = Console.ReadLine();
                        Console.WriteLine("Enter Password: ");
                        string Password = Console.ReadLine();
                        bool uniqueUser = true;
                        for (int i = 0; i < TotalUsers; i++)
                            if(UserName == Users[i].UserName)
                            {
                                Console.WriteLine("\n\n--USER ALREADY EXISTS--\n");
                                uniqueUser = false;
                                break;
                            }
                        if (uniqueUser)
                        {
                            Console.WriteLine($"User #{UserIndex}: {UserName}\n\n");
                            Users[UserIndex] = AddUser(UserName, Password);
                            TotalUsers++;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter Username: ");
                        string inUserName = Console.ReadLine();
                        bool Authenticated = false;

                        for (int i = 0; i < TotalUsers; i++)
                            if (inUserName == Users[i].UserName)
                            {
                                Console.WriteLine($"Enter Password for {inUserName}");
                                string inPassword = User.Encrypt(Console.ReadLine());
                                if(inPassword == Users[i].Password)
                                    Authenticated = true;
                            }

                        if(Authenticated == true)
                            Console.WriteLine($"\n--USER AUTHENTICATED-- : {inUserName}\n\n");
                        else
                            Console.WriteLine($"\n--USER NOT AUTHENTICATED-- : {inUserName}\n\n");
                        break;
                    case "3":
                        isComplete = true;
                        Console.WriteLine("--EXITING PROGRAM--");
                        break;
                    default:
                        Console.WriteLine("--INVALID INPUT--");
                        break;
                }
                if(UserIndex >= 9)
                {
                    isComplete = true;
                    Console.WriteLine("\n--USER LIMIT REACHED - EXITING PROGRAM--");
                }
            }
        }

        static User AddUser(string UserName, string Password) => new User(UserName, Password);

    }

    public class User
    {
        public string UserName { get; }
        public string Password { get; }
        public User(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Encrypt(Password);
        }

        public static string Encrypt(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(input));
            byte[] result = md5.Hash;
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
                output.Append(result[i].ToString("x2"));
            return output.ToString();
        }
    }
}
