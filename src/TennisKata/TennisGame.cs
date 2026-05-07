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
        if (IsDeuce())
        {
            return "Deuce";
        }

        if (_playerOneScore == _playerTwoScore)
        {
            return $"{GetPointName(_playerOneScore)}-All";
        }

        return $"{GetPointName(_playerOneScore)}-{GetPointName(_playerTwoScore)}";
    }

    private bool IsDeuce()
    {
        return _playerOneScore >= 3 &&
               _playerTwoScore >= 3 &&
               _playerOneScore == _playerTwoScore;
    }

    private static string GetPointName(int score)
    {
        if (score == 0)
        {
            return "Love";
        }

        if (score == 1)
        {
            return "Fifteen";
        }

        if (score == 2)
        {
            return "Thirty";
        }

        return "Forty";
    }
}