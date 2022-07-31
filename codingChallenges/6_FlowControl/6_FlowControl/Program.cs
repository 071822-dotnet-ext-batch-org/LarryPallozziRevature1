
﻿using System;


namespace _6_FlowControl
{
    public class Program
    {

        public static string userName { get; set; }
        public static string password { get; set; }

        static void Main(string[] args)
        {
        }

        /// <summary>
        /// This method gets a valid temperature between -40 asnd 135 inclusive from the user

        /// and returns the valid int.

        /// </summary>
        /// <returns></returns>
        public static int GetValidTemperature()
        {

          int temp = 999;
          do
          {
            Console.WriteLine("Enter an interger somewhere between -40 and 135: ");
            string userTemp = Console.ReadLine();

            while (!int.TryParse(userTemp, out temp) || temp > 135 || temp < -40)
            {
              System.Console.WriteLine("It broke~ Try again!");
              userTemp = Console.ReadLine();
            }
          } while (temp < -40 || temp > 135);

          return temp;
           //throw new NotImplementedException($"GetValidTemperature() has not been implemented.");

        }

        /// <summary>
        /// This method has one int parameter

        /// It prints outdoor activity advice and temperature opinion to the console
        /// based on 20 degree increments starting at -20 and ending at 135

        /// n < -20, Console.Write("hella cold");
        /// -20 <= n < 0, Console.Write("pretty cold");
        ///  0 <= n < 20, Console.Write("cold");
        /// 20 <= n < 40, Console.Write("thawed out");
        /// 40 <= n < 60, Console.Write("feels like Autumn");
        /// 60 <= n < 80, Console.Write("perfect outdoor workout temperature");
        /// 80 <= n < 90, Console.Write("niiice");
        /// 90 <= n < 100, Console.Write("hella hot");
        /// 100 <= n < 135, Console.Write("hottest");
        /// </summary>
        /// <param name="temp"></param>
        public static void GiveActivityAdvice(int temp)
        {

          if (temp < -20)
          {
            System.Console.Write("hella cold");
          }
          else if (temp < 0)
          {
            System.Console.Write("pretty cold");
          }
          else if (temp < 20)
          {
            System.Console.Write("cold");
          }
          else if (temp < 40)
          {
            System.Console.Write("thawed out");
          }
          else if (temp < 60)
          {
            System.Console.Write("feels like Autumn");
          }
          else if (temp < 80)
          {
            System.Console.Write("perfect outdoor workout temperature");
          }
          else if (temp < 90)
          {
            System.Console.Write("niiice");
          }
          else if (temp < 100)
          {
            System.Console.Write("hella hot");
          }
          else if (temp < 135)
          {
            System.Console.Write("hottest");
          }
          else
          {
            System.Console.Write("If you are seeing this something went wrong!");
          }

            //throw new NotImplementedException($"GiveActivityAdvice() has not been implemented.");

        }

        /// <summary>
        /// This method gets a username and password from the user

        /// and stores that data in the global variables of the

        /// names in the method.
        /// </summary>
        public static void Register()
        {

          Console.WriteLine("Enter Username: ");
          userName = Console.ReadLine();

          Console.WriteLine("Enter password: ");
          password = Console.ReadLine();

          Console.WriteLine("The Username and Password you entered are now saved!");

            //throw new NotImplementedException($"Register() has not been implemented.");

        }

        /// <summary>
        /// This method gets username and password from the user and
        /// compares them with the username and password names provided in Register().

        /// If the password and username match, the method returns true.

        /// If they do not match, the user is reprompted for the username and password
        /// until the exact matches are inputted.
        /// </summary>
        /// <returns></returns>
        public static bool Login()
        {

          string user;
          string passwd;

          do
          {
            System.Console.WriteLine("Enter you Username: ");
            user = Console.ReadLine();

            System.Console.WriteLine("Enter password: ");
            passwd = Console.ReadLine();
          }

          while (Equals(userName, user) && Equals(password, passwd));
          return true;

            //throw new NotImplementedException($"Login() has not been implemented.");

        }

        /// <summary>
        /// This method has one int parameter.
        /// It checks if the int is <=42, Console.WriteLine($"{temp} is too cold!");
        /// between 43 and 78 inclusive, Console.WriteLine($"{temp} is an ok temperature");
        /// or > 78, Console.WriteLine($"{temp} is too hot!");

        /// For each temperature range, a different advice is given.

        /// </summary>
        /// <param name="temp"></param>
        public static void GetTemperatureTernary(int temp)
        {

          if (temp <= 42)
          {
            System.Console.WriteLine($"{temp} is too cold!");
          }
          else if (temp <= 78)
          {
            System.Console.WriteLine($"{temp} is an ok temperature");
          }
          else if (temp > 78)
          {
            System.Console.WriteLine($"{temp} is too hot!");
          }
            //throw new NotImplementedException($"GetTemperatureTernary() has not been implemented.");

        }
    }//EoP
}//EoN
