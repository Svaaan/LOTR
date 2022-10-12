internal class Program
{
    private static void Main(string[] args)
    {
      string MenySelection;

      while(true)
      {
        System.Console.WriteLine("[1]Spela");
        System.Console.WriteLine("[2]Karaktärsinformation");
        System.Console.WriteLine("[3]Om spelet");
        System.Console.WriteLine("[4]Avsluta");

        MenySelection = Console.ReadLine();

        if (MenySelection == "1")
        {
          System.Console.WriteLine("spela spel");
        }
        else if(MenySelection == "2")
        {
          System.Console.WriteLine("Information");
        }
        else if (MenySelection == "3")
        {
          System.Console.WriteLine("information om spelet");
        }
        else if (MenySelection == "4")
        {
          break;
        }
        else
        {
          System.Console.WriteLine("Ogiltigt val");
        }
      }

      
    }
}