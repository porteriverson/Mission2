using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using Mission2;

public class Program
{
    public static void Main(string[] args)
    {
        // Welcome the user and get the number of rolls to do
        int numRolls = Welcome();
        // Pass the number of rolls and get an array of the results back
        int[] results = Dice.Simulation(numRolls);
        // Pass in the array and the number of rolls to calculate percentage. 
        MakeHisto(results, numRolls);
        Console.WriteLine("Thank you for rolling the dice!");
    }
    
    public static int Welcome()
    {
        Console.WriteLine("Welcome to the Dice Rolling simulator! \n");
        Console.WriteLine("How many rolls would you like to simulate?");
        string numRollsInput = Console.ReadLine();
        
        if (int.TryParse(numRollsInput, out int numRolls))
        {
            Console.WriteLine($"Rolling the dice {numRolls} time(s)...");
            return numRolls;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return Welcome();
        }
    }

    public static void MakeHisto(int[] results, int numRolls)
    {
        Console.WriteLine("Calculating the percentages now...");
        for (int i = 0; i < results.Length; i++)
        {
            char character = '*';
            int percentage = ((results[i] * 100) / numRolls);
            string output = new string(character, percentage);
            Console.WriteLine($"{i + 2}: {output}") ;
        }
    }
    
}

