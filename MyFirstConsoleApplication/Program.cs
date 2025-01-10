using System;

class Program
{

    static void Main()
    {
        string name = "Gage Smith";
        string location = "Boise, Id, United States";

        Console.WriteLine($"My name is: {name} and I am from: {location}");
        string currentDate = DateTime.Now.ToString("MM/dd/yyyy");
        Console.WriteLine($"Current date: {currentDate}");
        //days until christmas
        DateTime dateNow = DateTime.Now;
        DateTime christmasDate = new DateTime(dateNow.Year, 12, 25);
        TimeSpan difference = christmasDate - dateNow;
        int daysUntilChristmas = (int)difference.TotalDays;
        Console.WriteLine($"Days until Christmas: {daysUntilChristmas}");

        GlazerCalc();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void GlazerCalc ()
    {
        Console.WriteLine("Enter the width of the glazer in meters: ");
        string widthString = Console.ReadLine();
        double width = double.Parse(widthString);

        Console.WriteLine("Enter the height of the glazer in meters: ");
        string heightString = Console.ReadLine();
        double height = double.Parse(heightString);

        double woodLength = 2 * ( width + height ) * 3.25 ;  
        double glassArea = 2 * ( width * height ) ;

        Console.WriteLine ( $"The length of the wood is {woodLength} feet" ) ;
        Console.WriteLine( $"The area of the glass is {glassArea} square metres" ) ;
        
    }
} 