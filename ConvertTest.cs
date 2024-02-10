namespace Convert.Test;

public class ConvertTest1
{
    public void

    Console.Writeline("Welcome to the Converter");
            Console.Writeline("Please enter the ammount of inches you want to convert")
            Console.Writeline("Results will be given in millimiters, centimeters, and meters")
            Console.Writeline("or MM, CM, and M")
            String input = Console.Readline();

            if (millimeters < 11)
        {
            unit = "mm";
            value = millimeters;
        }
        else if (millimeters < 100)
        {
            unit = "cm";
            value = millimeters / 10; // Convert to centimeters
        }
        else
        {
            unit = "m";
            value = millimeters / 1000; // Convert to meters
        }

        Console.WriteLine($"{inches} inches is {value} {unit}");



    }