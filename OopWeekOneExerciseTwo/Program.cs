
// 1.10 Activity: Coding challenges 1
// Exercise 2
// Create an application named ConvertMilesToKilometers whose Main() method prompts a user for a number of miles, passes the value to a method that converts the value
// to kilometres, and then returns the value to the Main() method, where it is displayed. A mile is 1.60934 kilometres.

class ConvertMilesToKilometers
{
    static void Main(string[] args)
    {
        double numberOfMiles;
        double kiloMetres;

        // promote user to input the number of miles 
        Console.WriteLine("What is the number of miles you want to convert? ");

        numberOfMiles = Convert.ToDouble(Console.ReadLine());

        // call the method ConvertToKilometers() to convert user input to kilometres 
        kiloMetres = ConvertToKilometers(numberOfMiles);

        // display the return value 
        Console.WriteLine("For {0} mile(s), the number of kilometre(s): {1} km.", numberOfMiles, kiloMetres); 

    }

    public static double ConvertToKilometers(double numberOfMiles)
    {       
       // method accepts miles = has one parameters 

        const double conversionRate = 1.6094;
        double result;

        // converts miles to kilometres 
        result = numberOfMiles * conversionRate;

        return result;
    }
}