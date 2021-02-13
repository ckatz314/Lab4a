using System;

class MainClass {
  public static void Main (string[] args) {
    /*This program calculates the average speed of 7 cars.*/
    double totalspeed=0;
    for(int carnum=1;carnum<8;carnum++)
    {
      Console.WriteLine("Enter the distance covered by Car#"+carnum+" in miles:");
      double distance=Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter the time taken by Car#"+carnum+" in hours:");
      double time=Convert.ToDouble(Console.ReadLine());
      double speed=distance/time;
      Console.WriteLine("The speed of this car is "+speed+" miles per hour.");
      totalspeed=totalspeed+speed;
    }
    double avgspeed=totalspeed/7;
    Console.WriteLine("The average speed of the 7 cars is "+avgspeed+" miles per hour.");


  }
}