using Xunit;
using RockPaperScissors.Objects;

namespace RockPaperScissors

{
  public class GameTest
  {
    [Fact]
    public void Shoot_Player2PaperBeatsRock_paper()
    {
      // Arrange
      int playerOneInput = 1; //1 is the integer for Rock.
      int playerTwoInput = 2; //2 is the integer for Paper.
      string expected = "Player Two Wins"; //expected outcome.
      // Act
      string output = Game.Shoot(playerOneInput, playerTwoInput);
      // Assert
      Assert.Equal(expected, output);
    }

    [Fact]
    public void Shoot_Player1PaperBeatsRock_paper()
    {
      // Arrange
      int playerOneInput = 2; //paper
      int playerTwoInput = 1; //rock
      string expected = "Player One Wins";
      // Act
      string output = Game.Shoot(playerOneInput, playerTwoInput);
      // Assert
      Assert.Equal(expected, output);
    }

  }
}
