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

    [Fact]
    public void PlayerOneScoresFirstPoint_ShouldReturnFifteenLove()
    {
        var game = new TennisGame();

        game.PlayerOneScores();

        var score = game.GetScore();

        Assert.Equal("Fifteen-Love", score);
    }

    [Fact]
    public void PlayerOneScoresSecondPoint_ShouldReturnThirtyLove()
    {
        var game = new TennisGame();

        game.PlayerOneScores();
        game.PlayerOneScores();

        var score = game.GetScore();

        Assert.Equal("Thirty-Love", score);
    }

    [Fact]
    public void PlayerOneScoresThirdPoint_ShouldReturnFortyLove()
    {
        var game = new TennisGame();

        game.PlayerOneScores();
        game.PlayerOneScores();
        game.PlayerOneScores();

        var score = game.GetScore();

        Assert.Equal("Forty-Love", score);
    }

    [Fact]
    public void PlayerTwoScoresFirstPoint_ShouldReturnLoveFifteen()
    {
        var game = new TennisGame();

        game.PlayerTwoScores();

        var score = game.GetScore();

        Assert.Equal("Love-Fifteen", score);
    }

    [Fact]
    public void PlayerTwoScoresSecondPoint_ShouldReturnLoveThirty()
    {
        var game = new TennisGame();

        game.PlayerTwoScores();
        game.PlayerTwoScores();

        var score = game.GetScore();

        Assert.Equal("Love-Thirty", score);
    }

    [Fact]
    public void PlayerTwoScoresThirdPoint_ShouldReturnLoveForty()
    {
        var game = new TennisGame();

        game.PlayerTwoScores();
        game.PlayerTwoScores();
        game.PlayerTwoScores();

        var score = game.GetScore();

        Assert.Equal("Love-Forty", score);
    }
}