namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Name = "Oliver";
            int Age = 29;
            char lastInitial = 'D';
            bool isOliverTired = true;
            double hoursOfSleep = 6.5;
            decimal costOfLatte = 5m; 

            Console.WriteLine($"My name is {Name}, and I'm {Age} years old. My last initial is {lastInitial}, and it's {isOliverTired} that I'm tired, though I got {hoursOfSleep} last night. Hopefully a latte will wake me up, even though it costs {decimal} dollars.");
            
        }
    }
}
