namespace TennisKata;

public class TennisGame
{
    private int _playerOneScore;
    private int _playerTwoScore;

    public void PlayerOneScores()
    {
        _playerOneScore++;
    }

    public void PlayerTwoScores()
    {
        _playerTwoScore++;
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

        if (_playerTwoScore == 1)
        {
            return "Love-Fifteen";
        }

        if (_playerTwoScore == 2)
        {
            return "Love-Thirty";
        }

        if (_playerTwoScore == 3)
        {
            return "Love-Forty";
        }

        return "Love-All";
    }
}