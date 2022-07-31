

using System;
using System.Collections.Generic;

namespace _8_LoopsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {

      /* Your code here */


        }

        /// <summary>
        /// Return the number of elements in the List<int> that are odd.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseFor(List<int> x)
        {

          int numOdds = 0;

          foreach (int i in x)
          {
            if (i % 2 == 1)
            {
              numOdds++;
            }
          }
          return numOdds;


            //throw new NotImplementedException("UseFor() is not implemented yet.");
        }

        /// <summary>
        /// This method counts the even entries from the provided List<object>

            throw new NotImplementedException("UseFor() is not implemented yet.");
        }

        /// and returns the total number found.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForEach(List<object> x)
        {

          int numEvens = 0;

          foreach (object y in x)
          {
            if (y is double || y is float || y is sbyte || y is byte || y is short ||
            y is ushort || y is long)
            {
              if ((long) y % 2 == 0) numEvens++;
              }
              else if (y is int)
              {
              if ((int) y % 2 == 0) numEvens++;
              }
              else if (y is uint)
              {
              if ((uint)y % 2 == 0) numEvens++;
              }
              else if (y is ulong)
              {
              if ((ulong)y % 2 == 0) numEvens++;
              }
            }

          return numEvens;
            //throw new NotImplementedException("UseForEach() is not implemented yet.");
        }

        /// <summary>
        /// This method counts the multiples of 4 from the provided List<int>.

        /// Exit the loop when the integer 1234 is found.
        /// Return the total number of multiples of 4.
        /// </summary>
        /// <param name="x"></param>
        public static int UseWhile(List<int> x)
        {

          int multiFour = 0 ;

          foreach (int i in x)
          {
            if (i % 4 == 0)
            {
              multiFour++;
            }
            else if (i == 1234)
            {
              break;
            }
          }
          return multiFour;


            //throw new NotImplementedException("UseFor() is not implemented yet.");
        }

        /// <summary>
        /// This method will evaluate the Int Array provided and return how many of its

        /// values are multiples of 3 and 4.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForThreeFour(int[] x)
        {

          int threeFour = 0;

          foreach (int i in x)
          {
            if (i % 3 == 0 && i % 4 == 0)
            {
              threeFour++;
            }
          }
          return threeFour;

            //throw new NotImplementedException("UseForThreeFour() is not implemented yet.");
        }

        /// <summary>
        /// This method takes an array of List<string>'s.

        /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
        /// </summary>
        /// <param name="stringListArray"></param>
        /// <returns></returns>
        public static string LoopdyLoop(List<string>[] stringListArray)
        {

          string loopdyString = "";

          for (int i = 0; i < stringListArray.Length; i++)
          {
            foreach (string s in stringListArray[i])
            {
              loopdyString += $"{s} ";
            }
          }
          return loopdyString;

            //throw new NotImplementedException("LoopdyLoop() is not implemented yet.");

        }
    }
}

//using System;
//using System.Collections.Generic;

//namespace _8_LoopsChallenge
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            /* Your code here */

//        }

//        /// <summary>
//        /// Return the number of elements in the List<int> that are odd.
//        /// </summary>
//        /// <param name="x"></param>
//        /// <returns></returns>
//        public static int UseFor(List<int> x)
//        {
//            throw new NotImplementedException("UseFor() is not implemented yet.");
//        }

//        /// <summary>

//        /// This method counts the even entries from the provided List<object>

//        /// and returns the total number found.
//        /// </summary>
//        /// <param name="x"></param>
//        /// <returns></returns>
//        public static int UseForEach(List<object> x)
//        {
//            throw new NotImplementedException("UseForEach() is not implemented yet.");
//        }

//        /// <summary>

//        /// This method counts the multiples of 4 from the provided List<int>.

//        /// Exit the loop when the integer 1234 is found.
//        /// Return the total number of multiples of 4.
//        /// </summary>
//        /// <param name="x"></param>
//        public static int UseWhile(List<int> x)
//        {
//            throw new NotImplementedException("UseFor() is not implemented yet.");
//        }

//        /// <summary>

//        /// This method will evaluate the Int Array provided and return how many of its

//        /// values are multiples of 3 and 4.
//        /// </summary>
//        /// <param name="x"></param>
//        /// <returns></returns>
//        public static int UseForThreeFour(int[] x)
//        {
//            throw new NotImplementedException("UseForThreeFour() is not implemented yet.");
//        }

//        /// <summary>

//        /// This method takes an array of List<string>'s.

//        /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
//        /// </summary>
//        /// <param name="stringListArray"></param>
//        /// <returns></returns>
//        public static string LoopdyLoop(List<string>[] stringListArray)
//        {
//            throw new NotImplementedException("LoopdyLoop() is not implemented yet.");
//        }
//    }

//}

