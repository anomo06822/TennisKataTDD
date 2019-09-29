using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;
        private int _secondPlayerTimes;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen"},
            {2, "Thirty" },
            {3, "Forty" }
        };

        public string GetScore()
        {
            if (IsDifferentScore() && (_firstPlayerTimes > 0 || _secondPlayerTimes > 0))
            {
                return $"{_scoreLookup[_firstPlayerTimes]} {_scoreLookup[_secondPlayerTimes]}";
            }

            if (IsSameScore() && _firstPlayerTimes > 0)
            {
                return $"{_scoreLookup[_firstPlayerTimes]} All";
            }

            return $"{_scoreLookup[_firstPlayerTimes]}  All";
        }

        private bool IsSameScore()
        {
            return _firstPlayerTimes == _secondPlayerTimes;
        }

        private bool IsDifferentScore()
        {
            return _firstPlayerTimes != _secondPlayerTimes;
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