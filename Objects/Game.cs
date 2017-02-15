using System;
using System.Collections.Generic;

namespace RockPaperScissors.Objects


{
  public class Game
  {

    public string _user1;
    public string _user2;
    public string _output;

    public string Shoot(string input1, string input2)
    {
      if (input1 == "rock" && input2 == "scissors" || input1 == "scissors" && input2 == "paper" || input1 == "paper" && input2 == "rock")
      {
        _output = "Player One Wins";
      }
      else if (input1 == input2)
      {
        _output = "Game is a Tie";
      }
      else
      {
        _output = "Player Two Wins";
      }
      return _output;
    }
  }
}
