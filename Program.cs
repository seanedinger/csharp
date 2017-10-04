using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class ParkingLotSolution
{

    public static void Main(string[] args)
    {
        string test1 = "10:00";
        string test2 = "13:21";
        string test3 = "09:00";
        string test4 = "11:40";

        int answer;
        int answer2;

        ParkingLotSolution c = new ParkingLotSolution();
        answer = c.solution(test1, test2);
        answer2 = c.solution(test3, test4);

        Console.WriteLine("The answer for test 1 is : " + answer);
        Console.WriteLine("The answer for test 2 is : " + answer2);
        Console.ReadLine();
    }

    public int solution(string E, string L)
    {
        int entranceFee = 2;
        int firstHourCost = 3;
        int after1HourCost = 4;
        double totalCost;

        TimeSpan entryTime = TimeSpan.Parse(E);
        TimeSpan exitTime = TimeSpan.Parse(L);
        double duration = (exitTime - entryTime).TotalMinutes;

        Console.WriteLine(duration);

        double newDuration = Math.Ceiling(duration / 60);

        Console.WriteLine(newDuration);

        if (newDuration >= 2)
        {
            totalCost = entranceFee + firstHourCost + ((newDuration - 1) * after1HourCost);
        }
        else
        {
            totalCost = entranceFee + firstHourCost;
        }

        return (int)totalCost;
    }
}