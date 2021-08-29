using System;
using System.Collections.Generic;
using Sphynx;

public class Program
  {
    public static void Main()
    {
      Riddle riddle1 = new Riddle("What gets wet while it dries?", "Towel");
      Riddle riddle2 = new Riddle("What goes on four feet in the morning, two feet at noon, and three feet in the evening?", "Human");
      Riddle riddle3 = new Riddle(
@"Voiceless it cries, 
Wingless flutters, 
Toothless bites Mouthless mutters", "Wind");

      List<Riddle> Riddles = new List<Riddle>() {riddle1, riddle2, riddle3};
      Riddle clue;
      int riddleRandom = 0;
      Random rnd = new Random();
      List<int> seen = new List<int>();
      for (int i = 0; i < 3; i++) {

        riddleRandom = rnd.Next(0, 3);
        while (seen.Contains(riddleRandom)) {
          riddleRandom = rnd.Next(0, 3);
        }
        clue = Riddles[riddleRandom];
        Console.WriteLine(clue.Clue);
        string userAnswer = Console.ReadLine();
        if (userAnswer.ToUpper() == clue.Answer.ToUpper()){
          Console.WriteLine("CORRECT\n");
          seen.Add(riddleRandom);
          if (seen.Count == 3) {
            Console.WriteLine("You have defeated the Sphynx\n");
          }
        } else {
          Console.WriteLine("THE ANSWER WAS " + clue.Answer + "\n");
          Console.WriteLine("You were eaten\n");
          break;
        }
      }
    }
  }