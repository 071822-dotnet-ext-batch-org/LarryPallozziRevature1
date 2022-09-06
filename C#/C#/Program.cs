using System.Reflection;

namespace ReflectionsDemo;
class Program
{
  public string MyMood { get; set; } = "Cheery";
  public int MyPopsicleSticks { get; set; } = 4;
  private static int a = 1, b = 2, c = 3;

  static void Main(string[] args)
  {
    //Use Reflection to get local variables data
    Type programType = typeof(Program);

    MemberInfo[] memberInfoArray = programType.GetMember("MyMood");

    foreach (MemberInfo mi in memberInfoArray)
    {
      Console.WriteLine($"{mi.DeclaringType} decalred {mi.Name}.");
    }

    //Get fields info
    FieldInfo? fi = programType.GetField("a", BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);
    if (fi != null)
    {
      Console.WriteLine($"{fi?.Name} is a/an {fi?.GetType()} and it's new value is {fi?.GetValue(null)}");
      fi?.SetValue(programType, 13);
      Console.WriteLine($"{fi?.Name} is a/an {fi?.GetType()} and it's new value is {fi?.GetValue(null)}");
    }
    else
    {
      Console.WriteLine("fi was null!");
    }

    //Get property info
    MemberInfo[] gps = programType.GetProperties();
    foreach (var i in gps)
    {
      Console.WriteLine($"{i.Name} is a {i.GetType} and it's value is {i.GetType()}.");
    }

    var x = programType.GetProperty("MyMood");
    x?.GetValue(programType);
  }
}
