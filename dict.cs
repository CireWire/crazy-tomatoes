using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) 
  {
   Dictionary<string, int> x = new Dictionary<string, int>();
   x.Add ("Kyle Galner", 28);
   x.Add ("Leona Trevors", 22);
   x.Add ("Damien Laguna", 26);
   x.Add ("Maya Smith", 30);

   Console.WriteLine("Our list of assets are: ");
   foreach(string n in x.Keys)
    Console.WriteLine(n + ": " + x[n] );

  }
}
