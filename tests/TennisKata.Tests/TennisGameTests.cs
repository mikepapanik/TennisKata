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
        var game = CreateGameWithScore(playerOneScore: 1, playerTwoScore: 0);

        var score = game.GetScore();

        Assert.Equal("Fifteen-Love", score);
    }

    [Fact]
    public void PlayerOneScoresSecondPoint_ShouldReturnThirtyLove()
    {
        var game = CreateGameWithScore(playerOneScore: 2, playerTwoScore: 0);

        var score = game.GetScore();

        Assert.Equal("Thirty-Love", score);
    }

    [Fact]
    public void PlayerOneScoresThirdPoint_ShouldReturnFortyLove()
    {
        var game = CreateGameWithScore(playerOneScore: 3, playerTwoScore: 0);

        var score = game.GetScore();

        Assert.Equal("Forty-Love", score);
    }

    [Fact]
    public void PlayerTwoScoresFirstPoint_ShouldReturnLoveFifteen()
    {
        var game = CreateGameWithScore(playerOneScore: 0, playerTwoScore: 1);

        var score = game.GetScore();

        Assert.Equal("Love-Fifteen", score);
    }

    [Fact]
    public void PlayerTwoScoresSecondPoint_ShouldReturnLoveThirty()
    {
        var game = CreateGameWithScore(playerOneScore: 0, playerTwoScore: 2);

        var score = game.GetScore();

        Assert.Equal("Love-Thirty", score);
    }

    [Fact]
    public void PlayerTwoScoresThirdPoint_ShouldReturnLoveForty()
    {
        var game = CreateGameWithScore(playerOneScore: 0, playerTwoScore: 3);

        var score = game.GetScore();

        Assert.Equal("Love-Forty", score);
    }

    [Fact]
    public void BothPlayersScoreOnePoint_ShouldReturnFifteenAll()
    {
        var game = CreateGameWithScore(playerOneScore: 1, playerTwoScore: 1);

        var score = game.GetScore();

        Assert.Equal("Fifteen-All", score);
    }

    [Fact]
    public void BothPlayersScoreTwoPoints_ShouldReturnThirtyAll()
    {
        var game = CreateGameWithScore(playerOneScore: 2, playerTwoScore: 2);

        var score = game.GetScore();

        Assert.Equal("Thirty-All", score);
    }

    [Fact]
    public void PlayerOneLeadsTwoToOne_ShouldReturnThirtyFifteen()
    {
        var game = CreateGameWithScore(playerOneScore: 2, playerTwoScore: 1);

        var score = game.GetScore();

        Assert.Equal("Thirty-Fifteen", score);
    }

    [Fact]
    public void PlayerOneLeadsThreeToTwo_ShouldReturnFortyThirty()
    {
        var game = CreateGameWithScore(playerOneScore: 3, playerTwoScore: 2);

        var score = game.GetScore();

        Assert.Equal("Forty-Thirty", score);
    }

    [Fact]
    public void PlayerTwoLeadsTwoToOne_ShouldReturnFifteenThirty()
    {
        var game = CreateGameWithScore(playerOneScore: 1, playerTwoScore: 2);

        var score = game.GetScore();

        Assert.Equal("Fifteen-Thirty", score);
    }

    [Fact]
    public void BothPlayersScoreThreePoints_ShouldReturnDeuce()
    {
        var game = CreateGameWithScore(playerOneScore: 3, playerTwoScore: 3);

        var score = game.GetScore();

        Assert.Equal("Deuce", score);
    }

    [Fact]
    public void BothPlayersScoreFourPoints_ShouldReturnDeuce()
    {
        var game = CreateGameWithScore(playerOneScore: 4, playerTwoScore: 4);

        var score = game.GetScore();

        Assert.Equal("Deuce", score);
    }

    [Fact]
    public void BothPlayersScoreFivePoints_ShouldReturnDeuce()
    {
        var game = CreateGameWithScore(playerOneScore: 5, playerTwoScore: 5);

        var score = game.GetScore();

        Assert.Equal("Deuce", score);
    }

    [Fact]
    public void PlayerOneScoresAfterDeuce_ShouldReturnAdvantagePlayerOne()
    {
        var game = CreateGameWithScore(playerOneScore: 4, playerTwoScore: 3);

        var score = game.GetScore();

        Assert.Equal("Advantage Player One", score);
    }

    [Fact]
    public void PlayerTwoScoresAfterDeuce_ShouldReturnAdvantagePlayerTwo()
    {
        var game = CreateGameWithScore(playerOneScore: 3, playerTwoScore: 4);

        var score = game.GetScore();

        Assert.Equal("Advantage Player Two", score);
    }

    [Fact]
    public void PlayerOneLeadsFiveToFour_ShouldReturnAdvantagePlayerOne()
    {
        var game = CreateGameWithScore(playerOneScore: 5, playerTwoScore: 4);

        var score = game.GetScore();

        Assert.Equal("Advantage Player One", score);
    }

    [Fact]
    public void PlayerTwoLeadsFiveToFour_ShouldReturnAdvantagePlayerTwo()
    {
        var game = CreateGameWithScore(playerOneScore: 4, playerTwoScore: 5);

        var score = game.GetScore();

        Assert.Equal("Advantage Player Two", score);
    }

    [Fact]
    public void PlayerOneScoresFourPointsWithoutOpponentScoring_ShouldReturnWinForPlayerOne()
    {
        var game = CreateGameWithScore(playerOneScore: 4, playerTwoScore: 0);

        var score = game.GetScore();

        Assert.Equal("Win for Player One", score);
    }

    [Fact]
    public void PlayerOneLeadsFourToTwo_ShouldReturnWinForPlayerOne()
    {
        var game = CreateGameWithScore(playerOneScore: 4, playerTwoScore: 2);

        var score = game.GetScore();

        Assert.Equal("Win for Player One", score);
    }

    [Fact]
    public void PlayerOneLeadsFiveToThree_ShouldReturnWinForPlayerOne()
    {
        var game = CreateGameWithScore(playerOneScore: 5, playerTwoScore: 3);

        var score = game.GetScore();

        Assert.Equal("Win for Player One", score);
    }

    [Fact]
    public void PlayerTwoScoresFourPointsWithoutOpponentScoring_ShouldReturnWinForPlayerTwo()
    {
        var game = CreateGameWithScore(playerOneScore: 0, playerTwoScore: 4);

        var score = game.GetScore();

        Assert.Equal("Win for Player Two", score);
    }

    [Fact]
    public void PlayerTwoLeadsFourToTwo_ShouldReturnWinForPlayerTwo()
    {
        var game = CreateGameWithScore(playerOneScore: 2, playerTwoScore: 4);

        var score = game.GetScore();

        Assert.Equal("Win for Player Two", score);
    }

    [Fact]
    public void PlayerTwoLeadsFiveToThree_ShouldReturnWinForPlayerTwo()
    {
        var game = CreateGameWithScore(playerOneScore: 3, playerTwoScore: 5);

        var score = game.GetScore();

        Assert.Equal("Win for Player Two", score);
    }

    private static TennisGame CreateGameWithScore(int playerOneScore, int playerTwoScore)
    {
        var game = new TennisGame();

        ScorePoints(playerOneScore, game.PlayerOneScores);
        ScorePoints(playerTwoScore, game.PlayerTwoScores);

        return game;
    }

    private static void ScorePoints(int points, Action scorePoint)
    {
        for (var i = 0; i < points; i++)
        {
            scorePoint();
        }
    }
}