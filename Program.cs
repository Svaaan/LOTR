internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        //ArraySyntax = Flera olika variabler i en och samma datatyp(string)

        string [] datorspel = { "Csgo", "dota2", "Eu4", "7daystodie", "fornite" };

        for (int i = 0; i < datorspel.Length; i++) // For loop med datorspel.length då det det gör arrayen lättare att förstå
        {

            int rank = i + 1;  
             
             // rank + . + nuvarande loop på datorspelets placering i loppen (i)
            System.Console.WriteLine(rank + ". " + datorspel[i]); 
        }
            Console.WriteLine("");
            
            // Text efter loopen då den ej är en del av listan.
            Console.WriteLine("Ovanför är en lista på spelen jag spela senast i ordning"); 
            
            string[] datorspel1 = new string[5]; //Skappar en lista dock med en begränsning på 5

            System.Console.WriteLine("Skriv in dina favorit spel: "); 

            Console.WriteLine("");

            for (int i = 0; i < datorspel1.Length; i++) 
            {
                datorspel1[i]=Console.ReadLine(); // Användaren fyller i favorit spel
            }
            
            Console.WriteLine("Here they are in alphabetical order: "); //Bara en irrelevant sak. Läs readme.

            Console.WriteLine("");

            Array.Sort(datorspel1); // Sorterar de inskrivna spelen i lista. 

            for (int i = 0; i < datorspel1.Length; i++)
            {
                System.Console.WriteLine(datorspel1[i]); //skriver ut spelen i alfabetisk ordning
            } 

        
          Console.ReadLine();
    }
}