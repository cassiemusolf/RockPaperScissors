// using Xunit;
// using RockPaperScissors.Objects;
//
// namespace RockPaperScissors
//
// {
//   public class GameTest
//   {
//     [Fact]
//     public void Shoot_GameIsATie_Tie()
//     {
//       // Arrange
//       Game obj = new Game();
//       // Act
//       string output = obj.Shoot("scissors", "scissors");
//       // Assert
//       Assert.Equal("Game is a Tie", output);
//     }
//     [Fact]
//     public void Shoot_Player1PaperBeatsRock_paper()
//     {
//       // Arrange
//       Game obj = new Game();
//       // Act
//       string output = obj.Shoot("paper", "rock");
//       // Assert
//       Assert.Equal("Player One Wins", output);
//     }
//     [Fact]
//     public void Shoot_Player2PaperBeatsRock_paper()
//     {
//       // Arrange
//       Game obj = new Game();
//       // Act
//       string output = obj.Shoot("rock", "papers");
//       // Assert
//       Assert.Equal("Player Two Wins", output);
//     }
//   }
// }
