
using System;

class MainClass {

public static double CalculateCharge (int hoursParked)
{
double totalParkingCharge = 0.0;
if (hoursParked >= 24)
{
totalParkingCharge = 10.00;
}
else if (hoursParked <= 3)
{
totalParkingCharge = 2.00;
}
else
{
totalParkingCharge = 0.50*(hoursParked-3)+2;
}
return totalParkingCharge;
}

public static void Main (string[] args) {
Console.WriteLine ("Enter number of customers");
int customers = Convert.ToInt32 (Console.ReadLine());

for (int counter = 0; counter < customers; counter++)
{
Console.WriteLine ("Enter hours parked");
int hoursParked = Convert.ToInt32 (Console.ReadLine());

double totalParkingCharge = CalculateCharge (hoursParked);
Console.WriteLine (totalParkingCharge);
}


}
}