using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
       int 
       myNum = 32;
       Console.WriteLine(myNum);
       
       int x = 33, y = 4, z = 13;
       Console.WriteLine(33 + 4 + 13);
       
       double petDog = 12.3D, petCat = 22.4D, petSnake = 0.3D;
       Console.WriteLine(petDog + petCat + petSnake);
       
       float totalCost = 14F, totalHours = 66F, totalTime = 45F; 
       Console.WriteLine(totalCost + totalHours + totalTime);
       
       string solarSystemPlanets = "Venus";
       Console.WriteLine(solarSystemPlanets);
       
       string fastFood = "McDonalds";
       Console.WriteLine(fastFood);
       
       bool powerFlight = false;
       bool touchGround = true;
       Console.WriteLine("Can player fly " + powerFlight);
       
       bool powerInvisibility = true;
       bool seePlayer = false;
       Console.WriteLine("Can I see the Player? " + seePlayer);
       
       char favLetter = 'R';
       char lastLetter = 'Z';
       Console.WriteLine(lastLetter);
       Console.WriteLine(favLetter);
         
    }
  }
}
