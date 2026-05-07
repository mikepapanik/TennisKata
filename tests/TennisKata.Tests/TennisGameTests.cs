using TennisKata;

namespace TennisKata.Tests;

public class TennisGameTests
{
    [Fact]
    public void NewGame_ShouldStartWithLoveAll()
    {
        var game = new TennisGame();

        var score = game.GetScore();

        Assert.Equal("Love-All", score);
    }
}