namespace TennisKata;

public class TennisGame
{
    private int _playerOneScore;

    public void PlayerOneScores()
    {
        _playerOneScore++;
    }

    public string GetScore()
    {
        if (_playerOneScore == 1)
        {
            return "Fifteen-Love";
        }

        if (_playerOneScore == 2)
        {
            return "Thirty-Love";
        }

        if (_playerOneScore == 3)
        {
            return "Forty-Love";
        }

        return "Love-All";
    }
}