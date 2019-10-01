using System.Collections.Generic;
using System.Globalization;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;

        private Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };

        private int _secondPlayerTimes;

        public string GetStore()
        {
            if (_firstPlayerTimes != _secondPlayerTimes && _firstPlayerTimes > 3 &&
                _firstPlayerTimes - _secondPlayerTimes == 1)
            {
                return "FirstPlayerName Adv";
            }

            if (_firstPlayerTimes != _secondPlayerTimes && _secondPlayerTimes > 3 &&
                _secondPlayerTimes - _firstPlayerTimes == 1)
            {
                return "SecondPlayerName Adv";
            }

            if (IsDeuce())
            {
                return "Deuce";
            }

            if (IsSameScore() && _firstPlayerTimes > 0 )
            {
                return $"{_lookupScore[_firstPlayerTimes]} All";
            }

            if (_secondPlayerTimes > 0)
            {
                return $"Love {_lookupScore[_secondPlayerTimes]}";
            }

            if (_firstPlayerTimes > 0)
            {
                return $"{_lookupScore[_firstPlayerTimes]} Love";
            }

            return "Love All";
        }

        private bool IsDeuce()
        {
            return IsSameScore() && _firstPlayerTimes == 3;
        }

        private bool IsSameScore()
        {
            return _firstPlayerTimes == _secondPlayerTimes;
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