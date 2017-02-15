using System;
using System.Collections.Generic;

namespace RockPaperScissors.Objects

{
  public class Game
  {
    public string _user1;
    public string _user2;
    public string _output;

    public string Shoot(string user1, string user2)
    {
      _user1 = user1;
      _user2 = user2;

      if (user1 == "rock" && user2 == "scissors" || user1 == "scissors" && user2 == "paper" || user1 == "paper" && user2 == "rock")
      {
        _output = "Player One Wins";
      }
      else if (user1 == user2)
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
