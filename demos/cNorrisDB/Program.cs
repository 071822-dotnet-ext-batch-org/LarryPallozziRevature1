// See https://aka.ms/new-console-template for more information
// Get libraries
using System;
using System.Threading.Tasks;
using System.Net;

namespace cNorrisDB //
{
  class Program
  {
    static void Main(string[] args)
    {
      string url = "http://api.icndb.com/jokes/random";
      string json = GetJson(url);
      string newJson = json.Replace("Chuck Norris", "Mark Moore");
      Console.WriteLine(newJson);
      string urlTwo = "http://api.icndb.com/jokes/";
      Console.WriteLine("Please enter a number between 1 and 619");
      string numberString = Console.ReadLine();
      string newUrl = $"{urlTwo}{numberString}";
      string jsonTwo = GetJson2(newUrl);
      // print the json to the console
      Console.WriteLine(jsonTwo);
    }

    static string GetJson(string url)
    {
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
      HttpWebResponse response = (HttpWebResponse)request.GetResponse();
      string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
      return json;
    }
    // create a new method which asks the user to input a number between 1 and 619 put that number on the back of url: http://api.icndb.com/jokes/ and returns the result of the http request
    static string GetJson2(string newUrl)
    {
      // ask the user to input a number between 1 and 619
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(newUrl);
      HttpWebResponse response = (HttpWebResponse)request.GetResponse();
      string jsonTwo = new StreamReader(response.GetResponseStream()).ReadToEnd();
      return jsonTwo;
    }

    static void Main(string[] args)
    {
      string url = "http://api.icndb.com/jokes/random";
      string json = GetJson(url);
      string newJson = json.Replace("Norris", "Carmichael");
      Console.WriteLine(newJson);
    }
    static string GetJson(string url)
    {
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
      HttpWebResponse response = (HttpWebResponse)request.GetResponse();
      string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
      return json;
    }

  }

}
