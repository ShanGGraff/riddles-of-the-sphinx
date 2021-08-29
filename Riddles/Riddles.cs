using System;
using System.Collections.Generic;

namespace Sphynx {
  
  public class Riddle
  {
    public string Clue {get; set; }
    public string Answer {get; set;}
    public Riddle (string clue, string answer) {
      Clue = clue;
      Answer = answer;
    }
  }
}

