using System.Security.Cryptography.X509Certificates;

internal class Program
{ static void Main(string[] args)
    {
        MakeSomeGarbge();
        Console.WriteLine($"Memory used Before Collection{GC.GetTotalMemory(false):N0}");
        GC.Collect();
        Console.WriteLine($"Memory used after collection:{GC.GetTotalMemory (true):N0}");
    }
    static void MakeSomeGarbge()
    {
        Version v;
        for (int i = 0; i < 1000; i++)
        {
            v = new Version();
        }
    }
  /*  private static void Main(string[] args)
      {
     var p =new Person();
        p.Name = "Ali";
    }
}
class Person
{ public string Name
    { get; set; } 

    public Person()
    {
        Console.WriteLine("This is persont constructure"); 
    }
     ~Person()
    {
        Console.WriteLine("This is persont constructure");
    }*/
}