namespace Mission2;
public class Dice
{

    public Dice()
    {
        //this method is called 1 time on setup in the beginning
    }
    
    
    // Method to roll the Dice object
    public int Roll()
    {
        Random random = new Random(); 
        int randNum = random.Next(1,7);
        return randNum;
    }

    // Method to return the integer of results after rolling them. 
    public static int[] Simulation(int numRolls)
    {
        int[] results = new int[11];

        int total;
        Dice dice1 = new Dice();
        Dice dice2 = new Dice();
        
        for (int i = 0; i < numRolls; i++)
        {
            total = dice1.Roll() + dice2.Roll();
            results[total-2] += 1;
        }
        return results;
    }

}
