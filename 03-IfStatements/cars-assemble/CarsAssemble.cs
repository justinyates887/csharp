using System;

/*
In this exercise you'll be writing code to analyze the production of an assembly line in a car factory. The assembly line's speed can range from 0 (off) to 10 (maximum).

At its lowest speed (1), 221 cars are produced each hour. The production increases linearly with the speed. So with the speed set to 4, it should produce 
4 * 221 = 884 cars per hour. However, higher speeds increase the likelihood that faulty cars are produced, which then have to be discarded.

You have three tasks.
*/

static class AssemblyLine
{

    public static double SuccessRate(int speed)
    {

        /*
            Implement the (static) AssemblyLine.SuccessRate() method to calculate the ratio of an item being created without error for a given speed. 
            The following table shows how speed influences the success rate:

            0: 0% success rate.
            1 to 4: 100% success rate.
            5 to 8: 90% success rate.
            9: 80% success rate.
            10: 77% success rate.

            While I could use a ternary return here to get it in one line, this assignment specifies if/else statements, therefore that is how I will
            implement the solution.
        */
        
        if(speed == 0){
            return 0.00;
        } else if(5 > speed && speed > 0) {
            return 1.00;
        } else if (9 > speed && speed > 4){
            return 0.90;
        } else if (speed == 9){
            return 0.80;
        } else if (speed == 10){
            return 0.77;
        } else {
            Console.WriteLine($"Error: Speed {speed} is out of bounds. Expected an int from range 0-10");
        }

        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        /*
        Implement the (static) AssemblyLine.ProductionRatePerHour() method to calculate the assembly line's production rate per hour, taking into account its success rate:
        */

        if(speed == 0){
            return 0.00;
        } else if(5 > speed && speed > 0) {
            return (speed * 221) * 1.00;
        } else if (9 > speed && speed > 4){
            return (speed * 221) * .90;
        } else if (speed == 9){
            return (speed * 221) * .80;
        } else if (speed == 10){
            return (speed * 221) * .77;
        } else {
            Console.WriteLine($"Error: Speed {speed} is out of bounds. Expected an int from range 0-10");
        }


        throw new NotImplementedException("Please implement the (static) AssemblyLine.221PerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        /*
        Implement the (static) AssemblyLine.WorkingItemsPerMinute() method to calculate how many working cars are produced per minute:

        The tests require an int as a return value.
        */

        if(speed == 0){
            return 0;
        } else if(5 > speed && speed > 0) {
            return Convert.ToInt32(Math.Floor((speed * 221) * 1.00 / 60));
        } else if (9 > speed && speed > 4){
            return Convert.ToInt32(Math.Floor((speed * 221) * .90 / 60));
        } else if (speed == 9){
            return Convert.ToInt32(Math.Floor((speed * 221) * .80 / 60));
        } else if (speed == 10){
            return Convert.ToInt32(Math.Floor((speed * 221) * .77 / 60));
        } else {
            Console.WriteLine($"Error: Speed {speed} is out of bounds. Expected an int from range 0-10");
        }

        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
