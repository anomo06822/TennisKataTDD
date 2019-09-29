using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;
        private int _secondPlayerTimes;

        private readonly Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };


        public string GetScore()
        {
            if (IsDeuce())
            {
                return DeuceScore();
            }

            if (IsSameScore())
            {
                return SameScore();
            }

            if (IsDifferentScore())
            {
                return LookupScore();
            }

            return SameScore();
        }

        private string LookupScore()
        {
            return $"{_lookupScore[_firstPlayerTimes]} {_lookupScore[_secondPlayerTimes]}";
        }

        private bool IsDifferentScore()
        {
            return _firstPlayerTimes != _secondPlayerTimes && (_firstPlayerTimes > 0 || _secondPlayerTimes > 0);
        }

        private string SameScore()
        {
            return $"{_lookupScore[_firstPlayerTimes]} All";
        }

        private bool IsSameScore()
        {
            return _firstPlayerTimes == _secondPlayerTimes && _firstPlayerTimes > 0;
        }

        private static string DeuceScore()
        {
            return $"Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerTimes == _secondPlayerTimes && _firstPlayerTimes >= 3;
        }

        public void FirstPlayerTimes()
        {
            _firstPlayerTimes++;
        }

        public void SecondPlayerTimes()
        {
            _secondPlayerTimes++;
        }
    }
}