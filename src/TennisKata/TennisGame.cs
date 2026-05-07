namespace TennisKata;

public class TennisGame
{
    private const int MinimumPointsToWin = 4;
    private const int MinimumPointsForDeuce = 3;
    private const int RequiredLeadToWin = 2;
    private const int RequiredLeadForAdvantage = 1;

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
        if (HasWinner())
        {
            return $"Win for {GetLeadingPlayerName()}";
        }

        if (IsDeuce())
        {
            return "Deuce";
        }

        if (HasAdvantage())
        {
            return $"Advantage {GetLeadingPlayerName()}";
        }

        if (ScoresAreEqual())
        {
            return $"{GetPointName(_playerOneScore)}-All";
        }

        return $"{GetPointName(_playerOneScore)}-{GetPointName(_playerTwoScore)}";
    }

    private bool HasWinner()
    {
        return HasPlayerReachedMinimumPointsToWin() &&
               GetScoreDifference() >= RequiredLeadToWin;
    }

    private bool HasPlayerReachedMinimumPointsToWin()
    {
        return _playerOneScore >= MinimumPointsToWin ||
               _playerTwoScore >= MinimumPointsToWin;
    }

    private bool IsDeuce()
    {
        return BothPlayersReachedDeuceRange() &&
               ScoresAreEqual();
    }

    private bool HasAdvantage()
    {
        return BothPlayersReachedDeuceRange() &&
               GetScoreDifference() == RequiredLeadForAdvantage;
    }

    private bool BothPlayersReachedDeuceRange()
    {
        return _playerOneScore >= MinimumPointsForDeuce &&
               _playerTwoScore >= MinimumPointsForDeuce;
    }

    private bool ScoresAreEqual()
    {
        return _playerOneScore == _playerTwoScore;
    }

    private int GetScoreDifference()
    {
        return Math.Abs(_playerOneScore - _playerTwoScore);
    }

    private string GetLeadingPlayerName()
    {
        if (_playerOneScore > _playerTwoScore)
        {
            return "Player One";
        }

        return "Player Two";
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